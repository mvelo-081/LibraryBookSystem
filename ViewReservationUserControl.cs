using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookSystem
{
    public partial class ViewReservationUserControl : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["LibraryBookSystem.Properties.Settings.ist2koConnectionString"].ConnectionString;

        Panel homePagePanel;

        Button menuBtn;

        Button ViewReservationBtn;

        bookingsUserControl.Student studentDdata;
        public ViewReservationUserControl(Panel homePagePanel, Button menuBtn, Button ViewReservationBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;

            this.ViewReservationBtn = ViewReservationBtn;

            CancelBtn.Click += handleCancelBtn;

            bookingSubmitBtn.Click += handleBookingSubmitBtn;

            studentEmailData.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            studentEmailData.AutoCompleteSource = AutoCompleteSource.CustomSource;
            studentEmailData.AutoCompleteCustomSource = GetStudentEmails();

            bookTitleData.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bookTitleData.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bookTitleData.AutoCompleteCustomSource = GetBookTitles();

            studentEmailData.TextChanged += new EventHandler(fillStudentNamesAndSurname);
        }

        // overloaded constructor  
        public ViewReservationUserControl(Panel homePagePanel, Button menuBtn, Button ViewReservationBtn, bookingsUserControl.Student studentDdata)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;

            this.ViewReservationBtn = ViewReservationBtn;

            this.studentDdata = studentDdata;

            studentEmailData.Text = studentDdata.Email;

            studentnameSurnameTextData.Text = studentDdata.NameSurname;

            bookTitleData.Text = studentDdata.BookTitle;

            CancelBtn.Click += handleCancelBtn;

            bookingSubmitBtn.Click += handleBookingSubmitBtn;

            studentEmailData.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            studentEmailData.AutoCompleteSource = AutoCompleteSource.CustomSource;
            studentEmailData.AutoCompleteCustomSource = GetStudentEmails();

            bookTitleData.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bookTitleData.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bookTitleData.AutoCompleteCustomSource = GetBookTitles();

            studentEmailData.TextChanged += new EventHandler(fillStudentNamesAndSurname);
        }

        // Method to autocomplete && suggest book tiitles that are available inthe database
        private AutoCompleteStringCollection GetBookTitles()
        {
            AutoCompleteStringCollection bookTitles = new AutoCompleteStringCollection();

            string query = "SELECT Book_Title FROM Book";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        bookTitles.Add(reader["Book_Title"].ToString());
                    }
                }
            }

            return bookTitles;
        }

        // This autoCompletes the student emails that exits in the database
        private AutoCompleteStringCollection GetStudentEmails()
        {
            ErrorLabel.Visible = false;

            AutoCompleteStringCollection studentEmails = new AutoCompleteStringCollection();

            string query = "SELECT Student_Email FROM Student";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        studentEmails.Add(reader["Student_Email"].ToString());
                    }
                }
            }

            return studentEmails;
        }

        // fill in the name of the student usong the email that was provided above (Autocopmle by a matchinig name&surame using a student email)
        private void fillStudentNamesAndSurname(object sender, EventArgs e)
        {
            string query = "SELECT Student_FName, Student_LName FROM Student WHERE Student_Email = @email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", studentEmailData.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        studentnameSurnameTextData.Text = reader["Student_FName"].ToString() + " " + reader["Student_LName"].ToString();
                    }
                }
            }
        }


        // Handles the function of the cancel buttom
        private void handleCancelBtn(object sender, EventArgs e)
        {
            homePagePanel.Controls.Clear();

            homePagePanel.Controls.Add(new ReservationUserControl1(homePagePanel, menuBtn, ViewReservationBtn));

            ViewReservationBtn.Visible = true;

            ViewReservationBtn.Text = "Add Reservation";
        }


        // get the book id of the book to be reserved (using the book titlle )
        private String getBookId()
        {
            String bookTitle = bookTitleData.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                String query = "SELECT BookID FROM Book WHERE Book_Title = @BookTitle";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookTitle", bookTitle);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["BookID"].ToString();
                        }
                        {
                            return "";
                        }
                    }
                }
            }
        }

        // gets the studnet id that will be used to make the reservation (links the student too dthe reservation)
        private String getStudentId()
        {
            String studentEmail = studentEmailData.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                String query = "SELECT StudentID FROM Student WHERE Student_Email = @studentEmail";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentEmail", studentEmail);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["StudentID"].ToString();
                        }
                        else
                        {
                            return "not found";
                        }
                    }
                }
            }
        }

        // chhechks if tthere is a pending reservation for the book the student is going to reserve
        private Boolean isThereReservation()
        {
            String studentId;
            String bookId;
            if (studentDdata == null)
            {
                studentId = getStudentId();
                bookId = getBookId();
            }
            else
            {
                studentId = studentDdata.StudentID;
                bookId = studentDdata.BookID;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                String query = "SELECT COUNT(*) FROM Reservation WHERE StudentID = @StudentID AND BookID = @BookID AND Reservation_Status = 'Pending'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentId);
                    command.Parameters.AddWithValue("@BookID", bookId);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        ErrorLabel.Text = "This student already has a pending reservation for this book.";
                        ErrorLabel.Visible = true;
                        return true;
                    }
                    else
                    {
                        ErrorLabel.Visible = false;
                        bookingSubmitBtn.Enabled = true;
                        return false;
                    }
                }
            }
        }


        // habdles the submittion of the reservation by performing relevant actions
        private void handleBookingSubmitBtn(object sender, EventArgs e)
        {
            if (isThereReservation())
            {
                return;
            }
            String studentId;
            String bookId;
            if (studentDdata == null)
            {
                studentId = getStudentId();
                bookId = getBookId();
            }
            else
            {
                studentId = studentDdata.StudentID;
                bookId = studentDdata.BookID;
            }
            string insertQuery = @"
                    INSERT INTO Reservation (StudentID, BookID, Reserved_date, Reservation_Status)
                    VALUES (@StudentID, @BookID, @ReservationDate, @ReservationStatus)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentDdata.StudentID);
                    cmd.Parameters.AddWithValue("@BookID", studentDdata.BookID);
                    cmd.Parameters.AddWithValue("@ReservationDate", DateTime.Today); 
                    cmd.Parameters.AddWithValue("@ReservationStatus", "Pending"); 

                    try
                    {
                        cmd.ExecuteNonQuery();
                        ErrorLabel.Text = ("Reservation successfully added!");
                        ErrorLabel.ForeColor = Color.Green;
                        ErrorLabel.Visible = true;
                    }
                    catch (SqlException ex)
                    {
                        ErrorLabel.Text = "Error: " + ex.Message;
                        ErrorLabel.Visible = true;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static LibraryBookSystem.bookingsUserControl;
using Twilio.TwiML.Voice;
using System.Configuration;

namespace LibraryBookSystem
{
    public partial class bookingsUserControl : UserControl
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LibraryBookSystem.Properties.Settings.ist2koConnectionString"].ConnectionString;

        private Panel homePagePanel;

        private Button menuBtn;

        private Button ViewReservationBtn;
        public bookingsUserControl(Panel homePagePanel, Button menuBtn, Button ViewReservationBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;

            this.ViewReservationBtn = ViewReservationBtn;

            bookingSubmitBtn.Click += HandleSubmitBookingBtn;

            CancelBookingBtn.Click += HandleCancelBookingBtn;

            bookTitleData.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bookTitleData.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bookTitleData.AutoCompleteCustomSource = GetBookTitles();

            studentEmailData.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            studentEmailData.AutoCompleteSource = AutoCompleteSource.CustomSource;
            studentEmailData.AutoCompleteCustomSource = GetStudentEmails();

            studentnameSurnameTextData.Text = "";
            studentEmailData.TextChanged += new EventHandler(fillStudentNamesAndSurname);

            // default return date to 10 days from today
            returnDateData.Text = DateTime.Today.AddDays(10).ToString("yyyy-MM-dd");

        }

        // This mehtod is reponsible for auto fillinh the student name and using the email (because a srudent musst have a unique email)
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

        // This is rthen auto complete method (source) for suggesting/completing student email by exixting emails in the data base
        private AutoCompleteStringCollection GetStudentEmails() 
        {
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

        // This metjhod suggets && also complete the book title being selected that is going to be borrowed by a user
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

        // This method checks if a user has a pending reseravation for the book they are borrowing && if they have, we must autometically approve it
        private void checkPendingReservations(string studentID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Just check how many pending reservations this student has
                string countQuery = "SELECT COUNT(*) FROM Reservation WHERE StudentID = @StudentID AND Reservation_Status = 'Pending'";

                int count = 0;
                using (SqlCommand countCmd = new SqlCommand(countQuery, connection))
                {
                    countCmd.Parameters.AddWithValue("@StudentID", studentID);
                    count = (int)countCmd.ExecuteScalar();
                }

                if (count > 0)
                {
                    // Get the first pending ReservationID
                    string getReservationQuery = "SELECT TOP 1 ReservationID FROM Reservation WHERE StudentID = @StudentID AND Reservation_Status = 'Pending' ORDER BY Reserved_Date ASC";

                    string revID = null;
                    using (SqlCommand getCmd = new SqlCommand(getReservationQuery, connection))
                    {
                        getCmd.Parameters.AddWithValue("@StudentID", studentID);
                        revID = getCmd.ExecuteScalar()?.ToString();
                    }

                    if (revID != null)
                    {
                        // Approve that reservation
                        string updateQuery = "UPDATE Reservation SET Reservation_Status = 'Approved' WHERE ReservationID = @revID AND StudentID = @StudentID AND Reservation_Status = 'Pending'";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@revID", revID);
                            updateCmd.Parameters.AddWithValue("@StudentID", studentID);

                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            MessageBox.Show(rowsAffected + " reservation(s) have been approved.");
                        }
                    }

                    MessageBox.Show("This student a pending reservation for this book. \nIt was automatically approved.");
                }
            }
        }


        // Get the bookID provided their title (title acts like a secondary primary key)
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

        // Get the StudentID provided their email (email acts like a secondary primary key)
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

        // checks if a user already borrorwd this book
        private Boolean isThereBooking()
        {
            String studentId = getStudentId(); 
            String bookId = getBookId();
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                String query = "SELECT COUNT(*) FROM borrow WHERE StudentID = @StudentID AND BookID = @BookID AND Return_Date IS NULL ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentId);
                    command.Parameters.AddWithValue("@BookID", bookId);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("This student already borrowed this book!");
                        ErrorLabel.Text = "This student already borrowed this book."; // standby textbox
                        ErrorLabel.Visible = false;
                        return true;
                    }
                    else
                    {
                        ErrorLabel.Visible = false;
                        return false;
                    }
                }
            }
        }

        // This is where we handle all the procedures that must be done inorder to complete a STudent borrowing a book
        private void HandleSubmitBookingBtn(object sender, EventArgs e)
        {
            if (isThereBooking())
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(studentnameSurnameTextData.Text) ||
                string.IsNullOrWhiteSpace(bookTitleData.Text) ||
                string.IsNullOrWhiteSpace(returnDateData.Text))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = ("Please fill in all fields.");
                ErrorLabel.Visible = true;
                return;
            }

            string studentID = getStudentId();
            string bookID = getBookId();

            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(bookID))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Student or Book not found in the system." + getStudentId() + " --- " + getBookId();
                ErrorLabel.Visible = true;
                return;
            }

            if (!DateTime.TryParse(returnDateData.Text, out DateTime returnDate))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Invalid return date.";
                ErrorLabel.Visible = true;
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string checkQuery = @"SELECT 
                                        (SELECT Count(*) FROM Borrow WHERE Borrow.StudentID = @StudentID AND Borrow.BookID = @BookID AND Return_Date is NULL GROUP BY Borrow.StudentID) AS activeBorrows,
                                        (SELECT Book_Quantity FROM Book WHERE BookID = @BookID) AS TotalQuantity,
                                        (SELECT Count(*) FROM Borrow WHERE Borrow.BookID = @BookID AND Return_date is NULL) as borrowedCount";

                    int borrowedCount = 0;
                    int totalQuantity = 0;
                    int activeBorrows = 0;

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@BookID", bookID);
                        checkCmd.Parameters.AddWithValue("@StudentID", studentID);
                        using (SqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                activeBorrows = reader["activeBorrows"] == DBNull.Value ? 0 : Convert.ToInt32(reader["activeBorrows"]);
                                totalQuantity = reader["TotalQuantity"] == DBNull.Value ? 0 : Convert.ToInt32(reader["TotalQuantity"]);
                                borrowedCount = reader["borrowedCount"] == DBNull.Value ? 0 : Convert.ToInt32(reader["borrowedCount"]);
                            }
                        }
                    }

                    if (borrowedCount >= totalQuantity)
                    {
                        ErrorLabel.ForeColor = Color.Red;
                        ErrorLabel.Text = "This book is currently unavailable (all copies borrowed)."; // errorLabel must be use to show errors only
                        MessageBox.Show("This book is currently unavailable (all copies borrowed).");
                        ErrorLabel.Visible = false;

                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Would you like to make a reservations?", "Book Unavailable", buttons);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                        homePagePanel.Controls.Clear();
                        ViewReservationUserControl viewReservation = new ViewReservationUserControl(homePagePanel, menuBtn, ViewReservationBtn, new Student(studentEmailData, studentnameSurnameTextData, studentID, bookID, bookTitleData));
                        homePagePanel.Controls.Add(viewReservation);

                        return;
                    }
                    if (activeBorrows > 0)
                    {
                        ErrorLabel.ForeColor = Color.Red;
                        ErrorLabel.Text = "This student already borrowed this book!.";
                        MessageBox.Show("This student already borrowed this book!");
                        ErrorLabel.Visible = false;
                        return;
                    }


                    string insertQuery = @"
                                            INSERT INTO Borrow (StudentID, BookID,Borrow_date,Due_Date)
                                            OUTPUT INSERTED.BorrowID
                                            VALUES (@StudentID, @BookID, @Borrow_date,@Due_Date)";

                    int newBorrowId = 0;
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@StudentID", studentID);
                        insertCmd.Parameters.AddWithValue("@BookID", bookID);
                        insertCmd.Parameters.AddWithValue("@Borrow_date",DateTime.Today);
                        insertCmd.Parameters.AddWithValue("@Due_Date", returnDateData.Value);

                        newBorrowId = Convert.ToInt32(insertCmd.ExecuteScalar());
                    }

                    if (newBorrowId > 0)
                    {
                        ErrorLabel.ForeColor = Color.Green;
                        ErrorLabel.Text = $"The Student has successfully borrowed a book";
                        ErrorLabel.Visible = true;

                        checkPendingReservations(studentID);
                    }
                    else
                    {
                        ErrorLabel.ForeColor = Color.Red;
                        ErrorLabel.Text = "Failed to borrow book. Please try again.";
                        ErrorLabel.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = $"Error: {ex.Message}";
                ErrorLabel.Visible = true;
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        // Thios handle the cnacel buttons by taking the admin back to the main menu
        private void HandleCancelBookingBtn(object sender, EventArgs e)
        {
            menuBtn.Visible = false;

            homePagePanel.Controls.Clear();

            homePagePanel.Controls.Add(new MenuUserControl(homePagePanel, menuBtn));
        }

        // This is a simple class that helps us pass data between user controls (from bookings to reservations)
        public class Student
        {
            public string Email { get; set; }
            public string NameSurname { get; set; }
            public string StudentID { get; set; }
            public string BookID { get; set; }
            public string BookTitle { get; set; }

            public Student(TextBox emailTextBox, TextBox nameSurnameTextBox, string studentID, string bookID, TextBox bookTitleTextBox)
            {
                Email = emailTextBox.Text;
                NameSurname = nameSurnameTextBox.Text;
                StudentID = studentID;
                BookID = bookID;
                BookTitle = bookTitleTextBox.Text;
            }
        }
    }
}

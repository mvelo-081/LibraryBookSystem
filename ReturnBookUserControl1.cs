using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http;
using Twilio.Rest.Api.V2010.Account;

namespace LibraryBookSystem
{
    public partial class ReturnBookUserControl1 : UserControl
    {
        String studentID = "";

        string connectionString = "Data Source=143.128.146.30\\istn2;Initial Catalog=ist2ko;Persist Security Info=True;User ID=ist2ko;Password=jioeox;Encrypt=True;TrustServerCertificate=True";

        private Panel homePagePanel;

        private System.Windows.Forms.Button menuBtn; // dont know this.

        public ReturnBookUserControl1(Panel homePagePanel, System.Windows.Forms.Button menuBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;

            studentEmailData.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            studentEmailData.AutoCompleteSource = AutoCompleteSource.CustomSource;
            studentEmailData.AutoCompleteCustomSource = GetStudentEmails();

            ConfirmBookReturnBtn.Click += handleConfirmReturnBtn;

            studentEmailData.TextChanged += new EventHandler(fillStudentNamesAndSurname);

            studentnameSurnameTextData.Text = "";

            fetchBookListBtn.Click += handlefetchBookListBtn;

            BookCombBox.Items.Add("-- None --");

            BookCombBox.SelectedIndex = 0;

            CancelBtn.Click += handleCancelBtn;

        }
        private void handleCancelBtn(object sender, EventArgs e)
        {
            menuBtn.Visible = false;
            homePagePanel.Controls.Clear();

            homePagePanel.Controls.Add(new MenuUserControl(homePagePanel, menuBtn));
        }
        private void handlefetchBookListBtn(object sender, EventArgs e)
        {
            getBookNameList();
        }
        private void getBookNameList()
        {
            BookCombBox.Items.Clear();
            BookCombBox.Items.Add("-- None --");
            String query = "SELECT b.Book_Title, bb.BorrowID FROM Book b JOIN Borrow bb ON b.bookID = bb.bookID WHERE bb.StudentID = @studentID AND bb.return_date IS NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        BookCombBox.Items.Add(new comboBoxItem(reader["Book_Title"].ToString(), reader["BorrowID"].ToString()));
                    }
                }
                if(BookCombBox.Items.Count > 1)
                {
                    ErrorLabel.Text = "Books fetched successfully.";
                    ErrorLabel.ForeColor = Color.Green;
                    ErrorLabel.Visible = true;
                }
                else
                {
                    ErrorLabel.Text = "This user have no book to return.";
                    ErrorLabel.ForeColor = Color.Green;
                    ErrorLabel.Visible = true;
                }
                connection.Close();
            }
        }
        private void fillStudentNamesAndSurname(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;

            string query = "SELECT StudentID, Student_FName, Student_LName FROM Student WHERE Student_Email = @email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", studentEmailData.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        studentID = reader["StudentID"].ToString();
                        studentnameSurnameTextData.Text = reader["Student_FName"].ToString() + " " + reader["Student_LName"].ToString();
                    }
                }
            }
        }
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

        private void handleConfirmReturnBtn(object sender, EventArgs e)
        {
            String borrowid = "";
            if (BookCombBox.SelectedItem == null || BookCombBox.SelectedItem.ToString() == "-- None --" || studentEmailData.Text == "" || studentnameSurnameTextData.Text == "")
            {
                ErrorLabel.Text = "Please fill in all fields.";
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Visible = true;
                return;
            }
            else if (BookCombBox.SelectedItem is comboBoxItem selectedItem)
            {
                borrowid = selectedItem.BorrowId;
            }
            else
            {
                ErrorLabel.Text = "Please select a valid book.";
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Visible = true;
                return;
            }
            String query = "UPDATE Borrow SET return_date = @returnDate WHERE BorrowID = @borrowid";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@returnDate", DateTime.Now);
                    command.Parameters.AddWithValue("@borrowid", borrowid);

                    int result = command.ExecuteNonQuery();

                    if (result < 0)
                    {
                        ErrorLabel.Text = "Error returning book.";
                        ErrorLabel.ForeColor = Color.Red;
                        ErrorLabel.Visible = true;
                    }
                    else
                    {
                        ErrorLabel.Text = "Book returned successfully.";
                        ErrorLabel.ForeColor = Color.Green;
                        ErrorLabel.Visible = true;

                        // Notify the earliest reserved student if any. 
                        NotifyEarliestReservedStuden();

                        studentEmailData.Text = "";
                        studentnameSurnameTextData.Text = "";
                        BookCombBox.Items.Clear();
                        BookCombBox.Items.Add("-- None --");
                        BookCombBox.SelectedIndex = 0;
                    }
                }
                connection.Close();
            }


        }

        private class comboBoxItem
        {
            public string name { get; set; }
            public String BorrowId { get; set; }

            public comboBoxItem(string name, String id)
            {
                this.name = name;
                this.BorrowId = id;
            }

            public override string ToString()
            {
                return name;
            }
        }
        async private void NotifyEarliestReservedStuden() { 
            String boookTitle = BookCombBox.SelectedItem.ToString();

            String query = "SELECT TOP(1) * FROM Student WHERE Student.StudentID = ( SELECT TOP(1) Reservation.StudentID FROM Reservation WHERE Reservation.BookID = (SELECT BookID FROM Book WHERE Book_Title = @Book_Title) ORDER BY Reservation.Reserved_Date ASC, Reservation.ReservationID ASC )";


            String studentEmail = "";
            String nameSurname = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@book_Title", boookTitle);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        studentEmail = reader["Student_Email"].ToString();
                        nameSurname = reader["Student_FName"].ToString() + " " + reader["Student_LName"].ToString();

                        MessageBox.Show(
                            "Notified " + nameSurname + " at " + studentEmail +
                            "\n that the book " + boookTitle + " is now available for pickup.",
                            "Notification",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        try
                        {
                            //await SendEmailNotificationSingleAsync(studentEmail, nameSurname, boookTitle, "mvelokhumalo111@gmail", "exiidpvccirqvstn");
                        }
                        catch (Exception err)
                        { 
                            ErrorLabel.Text = "Error sending email notification.";

                            ErrorLabel.ForeColor = Color.Red;

                            ErrorLabel.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No reservations found for the book " + boookTitle,
                                        "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                connection.Close();
            }
        }
        // Inner class for SMS notifications
    }
}

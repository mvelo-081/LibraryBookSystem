using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace LibraryBookSystem
{
    public partial class ViewDatabase : UserControl
    {
        private Panel homePagePanel;

        private Button menuBtn;

        string connectionString = ConfigurationManager.ConnectionStrings["LibraryBookSystem.Properties.Settings.ist2koConnectionString"].ConnectionString;

        public ViewDatabase(Panel homePagePanel, Button menuBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;

            string[] options = { "Borrow table", "Student table", "Reservation table", "Books table", "Staff table" };
            comboBox1.Items.AddRange(options);
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void ViewDatabase_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        // When user changes the selected option
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            dataGridView1.DataSource = null;
            string query = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    switch (selected)
                    {
                        case "Books table":
                            query = "Select bookID as 'ID', book_title as 'Title', book_author as 'Author', book_category as 'Category', book_quantity as 'Quantity' FROM Book";
                            break;

                        case "Student table":
                            query = "SELECT StudentID as 'Student ID', (Student_fname + ' ' + student_lname) as 'Name and surname', student_email as 'Email', student_cellphoneno as 'Contact Number' FROM Student";
                            break;

                        case "Staff table":
                            query = "SELECT StaffID as 'Staff ID', (staff_fname + ' ' + staff_lname) as 'Name and surname', staff_username as 'Username', staff_password as 'Password', staff_role as 'Role' FROM staff";
                            break;

                        case "Borrow table":
                            query = @"SELECT (Student_Fname + ' ' + Student_lname) as 'Name and surname', book.book_title as 'Book title', Borrow.Borrow_Date as 'Borrow date', Borrow.Return_Date as 'Return date'
                                     FROM Borrow, book, student WHERE Borrow.StudentID = Student.StudentID AND Borrow.BookID = book.BookID";
                            break;

                        case "Reservation table":
                            query = @"SELECT (Student_Fname + ' ' + Student_lname) as 'Name and surname', book.book_title as 'Book title', reservation.Reserved_date as 'Reservetion date', reservation.reservation_status as 'Status'
                                     FROM reservation, book, student WHERE reservation.StudentID = Student.StudentID AND reservation.BookID = book.BookID";
                            break;

                        default:
                            MessageBox.Show("Unknown table selected.");
                            return;
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}


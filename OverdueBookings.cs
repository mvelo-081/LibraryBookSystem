using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookSystem
{
    public partial class OverdueBookings : UserControl
    {
        private Panel homePagePanel;

        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryBookSystem.Properties.Settings.ist2koConnectionString"].ConnectionString;
        public OverdueBookings(Panel homePagePanel)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;
        }

        private void OverdueBookings_Load(object sender, EventArgs e)
        {
            string query = @"SELECT Student.Student_Fname + ' ' + Student.Student_LName AS 'Name and Surname',
                            Student.Student_Email AS 'Email',   
                            Book.Book_Title AS 'Title',
                            Borrow.Borrow_Date AS 'Borrow Date',
                            Borrow.Due_Date AS 'Due Date'
                            FROM borrow, student, book
                            WHERE book.bookId = borrow.bookId AND borrow.StudentID = student.studentID AND Due_Date < GETDATE() AND Return_Date IS NULL";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                overdueBookingTable.DataSource = table;
            }
        }
    }
}

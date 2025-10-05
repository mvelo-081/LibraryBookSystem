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
    public partial class BorrowHistoryUserControl1 : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["LibraryBookSystem.Properties.Settings.ist2koConnectionString"].ConnectionString;

        public BorrowHistoryUserControl1(Panel homePagePanel, Button menuBtn)
        {
            InitializeComponent();

            fillTable();
        }
        private void fillTable()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                                SELECT 
                                    Student.Student_FName + ' ' + Student.Student_LName AS 'Name and Surname',
                                    Student.Student_Email AS 'Email',
                                    Book.Book_Title AS 'Title',
                                    Borrow.Borrow_date AS 'Taken on',
                                    Borrow.Due_date AS 'Due on',
                                    Borrow.Return_Date AS 'Returned on'
                                FROM Borrow
                                JOIN Student ON Borrow.StudentID = Student.StudentID
                                JOIN Book ON Borrow.BookID = Book.BookID";


                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView.DataSource = table;
            }
        }
    }
}

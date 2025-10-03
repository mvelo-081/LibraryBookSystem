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
    public partial class ReservationUserControl1 : UserControl
    {
        Button viewReservationBtn;
        string connectionString = ConfigurationManager.ConnectionStrings["LibraryBookSystem.Properties.Settings.ist2koConnectionString"].ConnectionString;
        public ReservationUserControl1(Panel homePagePanel, Button menuBtn, Button viewReservationBtn)
        {
            InitializeComponent();

            this.viewReservationBtn = viewReservationBtn;

            fillTable();
        }
        private void fillTable()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                Student.Student_FName + ' ' + Student.Student_LName AS [Name and Surname], 
                Student.Student_Email AS [Email], 
                Book.Book_Title AS [Title], 
                Reservation.Reserved_Date AS [Reserved Date], 
                Reservation.Reservation_Status AS [Status]
                FROM Reservation
                JOIN Student ON Reservation.StudentID = Student.StudentID
                JOIN Book ON Reservation.BookID = Book.BookID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }
    }
}

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

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2koDataSet);
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
                            query = "SELECT BookID AS [Book ID], Book_Title AS [Title], Book_Author AS [Author], Book_Category AS [Category], Book_Quantity AS [Quantity], Availability_Status AS [Status] FROM Book";
                            break;

                        case "Student table":
                            query = "SELECT StudentID AS [Student ID], Student_FName AS [First Name], Student_LName AS [Last Name], Student_Email AS [Email], Student_CellphoneNo AS [Cellphone No] FROM Student";
                            break;

                        case "Staff table":
                            query = "SELECT StaffID AS [Staff ID], Staff_FName AS [First Name], Staff_LName AS [Last Name], Staff_Username AS [Username], Staff_Role AS [Role] FROM Staff";
                            break;

                        case "Borrow table":
                            query = "SELECT BorrowID AS [Borrow ID], Borrow_Date AS [Borrow Date], Due_Date AS [Due Date], Return_Date AS [Return Date] FROM Borrow";
                            break;

                        case "Reservation table":
                            query = "SELECT ReservationID AS [Reservation ID], Reserved_Date AS [Reserved Date], Reservation_Status AS [Status] FROM Reservation";
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


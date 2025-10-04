using System;
using System.Windows.Forms;

namespace LibraryBookSystem
{
    public partial class ViewDatabase : UserControl
    {
        private Panel homePagePanel;

        private Button menuBtn; 
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
            // Optional: load a default table when control loads
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

            // Clear old data
            dataGridView1.DataSource = null;

            try
            {
                switch (selected)
                {
                    case "Books table":
                        var booksAdapter = new ist2koDataSetTableAdapters.BookTableAdapter();
                        var booksTable = new ist2koDataSet.BookDataTable();
                        booksAdapter.Fill(booksTable);
                        dataGridView1.DataSource = booksTable;
                        break;

                    case "Student table":
                        var studentAdapter = new ist2koDataSetTableAdapters.StudentTableAdapter();
                        var studentTable = new ist2koDataSet.StudentDataTable();
                        studentAdapter.Fill(studentTable);
                        dataGridView1.DataSource = studentTable;
                        break;

                    case "Reservation table":
                        var reservationAdapter = new ist2koDataSetTableAdapters.ReservationTableAdapter();
                        var reservationTable = new ist2koDataSet.ReservationDataTable();
                        reservationAdapter.Fill(reservationTable);
                        dataGridView1.DataSource = reservationTable;
                        break;

                    case "Borrow table":
                        var borrowAdapter = new ist2koDataSetTableAdapters.BorrowTableAdapter();
                        var borrowTable = new ist2koDataSet.BorrowDataTable();
                        borrowAdapter.Fill(borrowTable);
                        dataGridView1.DataSource = borrowTable;
                        break;

                    case "Staff table":
                        var staffAdapter = new ist2koDataSetTableAdapters.StaffTableAdapter();
                        var staffTable = new ist2koDataSet.StaffDataTable();
                        staffAdapter.Fill(staffTable);
                        dataGridView1.DataSource = staffTable;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data!");
            }
        }
    }
}


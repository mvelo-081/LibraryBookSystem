using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookSystem
{
    public partial class ViewDatabase : UserControl
    {

        ist2koDataSetTableAdapters.BorrowTableAdapter borrowTableAdapter = new ist2koDataSetTableAdapters.BorrowTableAdapter();
        ist2koDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter = new ist2koDataSetTableAdapters.ReservationTableAdapter();
        ist2koDataSetTableAdapters.StudentTableAdapter studentTableAdapter = new ist2koDataSetTableAdapters.StudentTableAdapter();
        ist2koDataSetTableAdapters.StaffTableAdapter staffTableAdapter = new ist2koDataSetTableAdapters.StaffTableAdapter();
        ist2koDataSetTableAdapters.BookTableAdapter bookTableAdapter = new ist2koDataSetTableAdapters.BookTableAdapter();

        public ViewDatabase()
        {
            InitializeComponent();
            LoadTableName();
        }

        private void ViewDatabase_Load(object sender, EventArgs e)
        {

        }
        public void LoadTableName()
        {
            comboBox1.Items.Clear();
            foreach (DataTable table in this.ist2koDataSet.Tables)
            {
                comboBox1.Items.Add(table.TableName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem.ToString();
            DataTable tableToDisplay = null;
            switch (selectedTable)
            {
                case "Staff":
                    this.staffTableAdapter.Fill(ist2koDataSet.Staff);
                    tableToDisplay = ist2koDataSet.Staff.Copy();
                    break;
                case "Student":
                    this.studentTableAdapter.Fill(ist2koDataSet.Student);
                    tableToDisplay = ist2koDataSet.Student.Copy();
                    break;
                case "Borrow":
                    this.borrowTableAdapter.Fill(ist2koDataSet.Borrow);
                    tableToDisplay = ist2koDataSet.Borrow.Copy();
                    break;
                case "Reservation":
                    this.reservationTableAdapter.Fill(ist2koDataSet.Reservation);
                    tableToDisplay = ist2koDataSet.Reservation.Copy();
                    break;
                case "Books":
                    this.bookTableAdapter.Fill(ist2koDataSet.Book);
                    tableToDisplay = ist2koDataSet.Book.Copy();
                    break;


            }
            if (tableToDisplay != null)
            {
                dataGridView1.DataSource = tableToDisplay;
            }
            if (dataGridView1.Columns.Contains("Staff_ID"))
            {
                dataGridView1.Columns["Staff_ID"].Visible = false;
            }
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            dataGridView1.Width =dataGridView1.PreferredSize.Width;
            dataGridView1.Height = dataGridView1.PreferredSize.Height;
        }
    }
}

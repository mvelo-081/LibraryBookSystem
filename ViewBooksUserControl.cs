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
    public partial class ViewBooksUserControl : UserControl
    {
        private Panel homePagePanel;
        private Button menuBtn;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryBookSystem.Properties.Settings.ist2koConnectionString"].ConnectionString;

        public ViewBooksUserControl()
        {
            InitializeComponent();

            bookNameData.TextChanged += new EventHandler(bookNameDataTextChanged);

            bookCategoryComboBox.Items.Add("All Categories");

            bookCategoryComboBox.SelectedIndex = 0;

            bookCategoryComboBox.SelectedIndexChanged += new EventHandler(bookCategoryComboBoxOptionChanged);

            getCategories();

            fillTable(bookCategoryComboBox.SelectedItem.ToString());
        }

        public ViewBooksUserControl(Panel homePagePanel, Button menuBtn)
        {
            InitializeComponent();
            this.homePagePanel = homePagePanel;
            this.menuBtn = menuBtn;

            bookNameData.TextChanged += new EventHandler(bookNameDataTextChanged);

            bookCategoryComboBox.Items.Add("All Categories");

            bookCategoryComboBox.SelectedIndex = 0;

            bookCategoryComboBox.SelectedIndexChanged += new EventHandler(bookCategoryComboBoxOptionChanged);

            getCategories();

            fillTable(bookCategoryComboBox.SelectedItem.ToString());

        }
        private void bookNameDataTextChanged(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Title LIKE '%{0}%'", bookNameData.Text);
        }
        private void fillTable(String option)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query;
                SqlDataAdapter adapter;

                if (option == "All Categories" || option == "")
                {
                    query = @"SELECT 
                                book_title as [Title],
	                            book_Author as [Author],
	                            book_Category as [Category],
	                            book_quantity as [Quantity]
                                FROM Book";
                    adapter = new SqlDataAdapter(query, conn);
                }
                else
                {
                    query = @"SELECT 
                                book_title as [Title],
	                            book_Author as [Author],
	                            book_Category as [Category],
	                            book_quantity as [Quantity]
                                FROM Book
                              WHERE book_category = @option";
                    adapter = new SqlDataAdapter(query, conn);

                    adapter.SelectCommand.Parameters.AddWithValue("@option", option);
                }


                

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView.DataSource = table;
            }
        }
        private void bookCategoryComboBoxOptionChanged(object sender, EventArgs e)
        {
            fillTable(bookCategoryComboBox.SelectedItem.ToString());
        }


        private void getCategories()
        {
            String query = "SELECT DISTINCT Book_Category FROM Book";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        bookCategoryComboBox.Items.Add(reader["Book_Category"].ToString());
                    }
                }
            }
        }
    }
}

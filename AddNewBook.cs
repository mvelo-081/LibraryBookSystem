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
    public partial class AddNewBook : UserControl
    {
        private Panel homePagePanel;

        private Button menuBtn;
        public AddNewBook(Panel homePagePanel, Button menuBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bookTableAdapter.AddNewBook(bookTitle.Text, bookAuthor.Text, bookCategory.Text, int.Parse(bookQuantity.Text),true);
            MessageBox.Show("New book added successfully.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homePagePanel.Controls.Clear();
            homePagePanel.Controls.Add(new ManagerMenuUserControl(homePagePanel, menuBtn));
        }
    }
}

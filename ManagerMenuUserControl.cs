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
    public partial class ManagerMenuUserControl : UserControl
    {
        Panel homePagePanel;
        public ManagerMenuUserControl(Panel homePagePanel)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;
        }

        private void CreateNewStudentBtn_Click(object sender, EventArgs e)
        {

        }

        private void returnedBookBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewBookingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {

        }

        private void availableBooksBtn_Click(object sender, EventArgs e)
        {
            ManageStaff manageStaff = new ManageStaff();
            homePagePanel.Controls.Clear();
            homePagePanel.Controls.Add(manageStaff);

        }

        private void viewBorrowHistBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

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

        private Button manMenuBtn;
        public ManagerMenuUserControl(Panel homePagePanel, Button manMenuBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.manMenuBtn = manMenuBtn;
        }

        private void CreateNewStudentBtn_Click(object sender, EventArgs e)
        {

        }
        private void switchUserControl(UserControl userControl)
        {
            homePagePanel.Controls.Clear();

            userControl.BackColor = Color.Transparent;

            homePagePanel.Controls.Add(userControl);

            manMenuBtn.Visible = true;
        }

        private void returnedBookBtn_Click(object sender, EventArgs e)
        {
            switchUserControl(new OverdueBookings(homePagePanel));
            
        }

        private void viewBookingsBtn_Click(object sender, EventArgs e)
        {
            switchUserControl(new AddNewBook(homePagePanel, manMenuBtn));
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            //switchUserControl(new ViewStatistics(homePagePanel, manMenuBtn));
        }

        private void availableBooksBtn_Click(object sender, EventArgs e)
        {
            switchUserControl(new ManageStaff(homePagePanel, manMenuBtn));

        }

        private void viewBorrowHistBtn_Click(object sender, EventArgs e)
        {

        }

        private void ManagerMenuUserControl_Load(object sender, EventArgs e)
        {

        }

        private void ViewDatabaseTableBtn_Click(object sender, EventArgs e)
        {
            switchUserControl(new ViewDatabase(homePagePanel, manMenuBtn));
        }
    }
}

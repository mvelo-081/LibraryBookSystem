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

        private Button menuBtn;
        public ManagerMenuUserControl(Panel homePagePanel, Button menuBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;
        }

        private void CreateNewStudentBtn_Click(object sender, EventArgs e)
        {

        }
        private void switchUserControl(UserControl userControl)
        {
            homePagePanel.Controls.Clear();

            homePagePanel.Controls.Add(userControl);

            menuBtn.Visible = true;
        }

        private void returnedBookBtn_Click(object sender, EventArgs e)
        {
            switchUserControl(new OverdueBookings(homePagePanel));
            
        }

        private void viewBookingsBtn_Click(object sender, EventArgs e)
        {
            switchUserControl(new AddNewBook(homePagePanel, menuBtn));
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            switchUserControl(new ViewStatistics(homePagePanel, menuBtn));
        }

        private void availableBooksBtn_Click(object sender, EventArgs e)
        {
            switchUserControl(new ManageStaff(homePagePanel, menuBtn));

        }

        private void viewBorrowHistBtn_Click(object sender, EventArgs e)
        {

        }

        private void ManagerMenuUserControl_Load(object sender, EventArgs e)
        {

        }

        private void ViewDatabaseTableBtn_Click(object sender, EventArgs e)
        {
            switchUserControl(new ViewDatabase(homePagePanel, menuBtn));
        }
    }
}

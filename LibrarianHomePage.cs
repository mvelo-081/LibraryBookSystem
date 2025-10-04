using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookSystem
{
    public partial class LibrarianHomePage : UserControl
    {
        private Boolean isAddingReservation = false;

        string connectionString = ConfigurationManager.ConnectionStrings["LibraryBookSystem.Properties.Settings.ist2koConnectionString"].ConnectionString;
        public LibrarianHomePage()
        {
            InitializeComponent();

            menuBtn.Click += handleMenuBtn;

            signoutBtn.Click += handleSignoutBtn;

            viewReservationBtn.Click += handleViewReservationBtn;   


            MenuUserControl menu = new MenuUserControl(homePagePanel, menuBtn, viewReservationBtn);

            switchUserControl(menu);

        }

        private void handleViewReservationBtn(object sender, EventArgs e)
        {
            if(isAddingReservation)
            {
                viewReservationBtn.Text = "Add Reservation";
                switchUserControl(new ReservationUserControl1(homePagePanel, menuBtn, viewReservationBtn));
            }
            else
            {
                viewReservationBtn.Text = "View Reservations";
                switchUserControl(new ViewReservationUserControl(homePagePanel, menuBtn, viewReservationBtn));
            }
            isAddingReservation = !isAddingReservation;
        }


        // handles switching userControls
        private void switchUserControl(UserControl userControl)
        {
            homePagePanel.Controls.Clear();

            //homePagePanel.Dock = DockStyle.Fill;

            homePagePanel.Controls.Add(userControl);
        }

        private void handleMenuBtn(object sender, EventArgs e)
        {
            switchUserControl(new MenuUserControl(homePagePanel, menuBtn, viewReservationBtn));

            menuBtn.Visible = false; 

            viewReservationBtn.Visible = false;
        }

        private async void handleSignoutBtn(object sender, EventArgs e)
        {

            LandingPage newLandingPage = new LandingPage();

            newLandingPage.StartPosition = FormStartPosition.Manual;

            newLandingPage.Location = new Point(this.FindForm().Location.X, this.FindForm().Location.Y);

            newLandingPage.Show();

            await Task.Delay(2000);

            this.FindForm().Hide(); // correct this, it kills ram ...
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {

        }
    }


}

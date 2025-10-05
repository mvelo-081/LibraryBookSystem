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

        private Panel landingPageMainPanel;

        string connectionString = ConfigurationManager.ConnectionStrings["LibraryBookSystem.Properties.Settings.ist2koConnectionString"].ConnectionString;
        public LibrarianHomePage(Panel LandingPageMainPanel)
        {
            InitializeComponent();

            this.landingPageMainPanel = LandingPageMainPanel;

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
            userControl.BackColor = Color.Transparent;

            homePagePanel.Controls.Add(userControl);
        }

        private void handleMenuBtn(object sender, EventArgs e)
        {
            switchUserControl(new MenuUserControl(homePagePanel, menuBtn, viewReservationBtn));

            menuBtn.Visible = false; 

            viewReservationBtn.Visible = false;
        }
        public void RemoveUserControls(Panel panel)
        {
            foreach (Control ctrl in panel.Controls.Cast<Control>().ToList())
            {
                if (ctrl.Tag != null && ctrl.Tag.ToString() == "dynamic")
                {
                    panel.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }
            }
        }


        private async void handleSignoutBtn(object sender, EventArgs e)
        {
            this.FindForm().Text = "Sign in";
            RemoveUserControls(landingPageMainPanel);
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {

        }

        private void LibrarianHomePage_Load(object sender, EventArgs e)
        {

        }
    }


}

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
    public partial class ManagerHomePage : UserControl
    {
        private Panel landingPageMainPanel;
        public ManagerHomePage(Panel landingPageMainPanel)
        {
            InitializeComponent();

            this.landingPageMainPanel = landingPageMainPanel;

            manMenuBtn.Click += handleMenuBtn;

            signoutBtn.Click += handleSignoutBtn;


            // initially have the menu
            switchUserControl(new ManagerMenuUserControl(homePagePanel, manMenuBtn));

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
            switchUserControl(new ManagerMenuUserControl(homePagePanel, manMenuBtn));

            manMenuBtn.Visible = false;
        }

        public void RemoveUserControls(Panel panel)
        {
            foreach (Control ctrl in panel.Controls.Cast<Control>().ToList())  // TODO: fix the error here!
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
            RemoveUserControls(landingPageMainPanel);
            //LandingPage newLandingPage = new LandingPage();

            //newLandingPage.StartPosition = FormStartPosition.Manual;

            //newLandingPage.Location = new Point(this.FindForm().Location.X, this.FindForm().Location.Y);

            //newLandingPage.Show();

            //await Task.Delay(2000);

            //this.FindForm().Hide(); // corret this, it kills ram ...
        }

        
    }
}

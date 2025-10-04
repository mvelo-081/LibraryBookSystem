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
        public ManagerHomePage()
        {
            InitializeComponent();

            menuBtn.Click += handleMenuBtn;

            signoutBtn.Click += handleSignoutBtn;


            // initially have the menu
            switchUserControl(new ManagerMenuUserControl(homePagePanel));

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
            switchUserControl(new MenuUserControl(homePagePanel, menuBtn));

            menuBtn.Visible = false;
        }

        private async void handleSignoutBtn(object sender, EventArgs e)
        {

            LandingPage newLandingPage = new LandingPage();

            newLandingPage.StartPosition = FormStartPosition.Manual;

            newLandingPage.Location = new Point(this.FindForm().Location.X, this.FindForm().Location.Y);

            newLandingPage.Show();

            await Task.Delay(2000);

            this.FindForm().Hide(); // corret this, it kills ram ...
        }

        
    }
}

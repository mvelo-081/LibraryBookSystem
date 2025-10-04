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
    public partial class MenuUserControl : UserControl 

    {
        private Panel homePagePanel;

        private Button menuBtn;

        private Button viewReservationBtn;
        public MenuUserControl(Panel homePagePanel, Button menuBtn, Button viewReservationBtn = null)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;   

            this.viewReservationBtn = viewReservationBtn;

            bookingBtn.Click += handleBookingBtn;

            CreateNewStudentBtn.Click += handleCreateNewStudent;

            availableBooksBtn.Click += handleAvailableBooksBtn;

            viewReservationsBtn.Click += handleViewReservationsBtn;

            viewBorrowHistBtn.Click += HandleViewBorrowHistBtn;

            returnedBookBtn.Click += HandleReturnedBookBtn;
        }
        public MenuUserControl(Panel homePagePanel, Button menuBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;

            bookingBtn.Click += handleBookingBtn;

            CreateNewStudentBtn.Click += handleCreateNewStudent;

            availableBooksBtn.Click += handleAvailableBooksBtn;

            viewReservationsBtn.Click += handleViewReservationsBtn;

            viewBorrowHistBtn.Click += HandleViewBorrowHistBtn;

            returnedBookBtn.Click += HandleReturnedBookBtn;
        }
        private void switchUserControl(UserControl userControl)
        {
            menuBtn.Visible = true;

            homePagePanel.Controls.Clear();

            homePagePanel.Controls.Add(userControl);
        }
        private void handleBookingBtn(object sender, EventArgs e)
        {
            switchUserControl(new bookingsUserControl(homePagePanel, menuBtn, viewReservationBtn));
        }

        private void handleCreateNewStudent(object sender, EventArgs e)
        { 
            switchUserControl(new NewStudentUserControl1(homePagePanel, menuBtn));
        }

        private void handleAvailableBooksBtn(object sender, EventArgs e)
        {
            switchUserControl(new ViewBooksUserControl(homePagePanel, menuBtn)); 
        }

        private void handleViewReservationsBtn(object sender, EventArgs e)
        {

            switchUserControl(new ReservationUserControl1(homePagePanel, menuBtn, viewReservationBtn));
            try
            { 
                viewReservationBtn.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured when click view reservatio, Please try again!.");
            }            
        }

        private void HandleViewBorrowHistBtn(object sender, EventArgs e)
        {
            switchUserControl(new BorrowHistoryUserControl1(homePagePanel, menuBtn));
        }
        private void HandleReturnedBookBtn(object sender, EventArgs e)
        {
            switchUserControl(new ReturnBookUserControl1(homePagePanel, menuBtn)); // returnedBookBtn
        }
    }
}
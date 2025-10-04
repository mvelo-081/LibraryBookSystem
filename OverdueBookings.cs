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
    public partial class OverdueBookings : UserControl
    {
        private Panel homePagePanel;
        public OverdueBookings(Panel homePagePanel)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;
        }

        private void borrowBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.borrowBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2koDataSet);

        }

        private void fillByOverDueBookingsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.borrowTableAdapter.FillByOverDueBookings(this.ist2koDataSet.Borrow);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

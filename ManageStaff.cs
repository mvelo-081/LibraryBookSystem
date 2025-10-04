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
    public partial class ManageStaff : UserControl
    {
        private Panel homePagePanel;

        private Button menuBtn;
        public ManageStaff(Panel homePagePanel, Button menuBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;
            //bindingNavigatorAddNewItem.PerformClick();
        }

        private void ManageStaff_Load(object sender, EventArgs e)
        {

        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2koDataSet);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void staffBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2koDataSet);

        }

        private void staff_LNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            staffBindingNavigatorSaveItem.PerformClick();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveFirstItem.PerformClick();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            bindingNavigatorMovePreviousItem.PerformClick();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveNextItem.PerformClick();
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveLastItem.PerformClick();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }
    }
}

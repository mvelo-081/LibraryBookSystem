using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryBookSystem
{
    public partial class IntroForm : Form
    {
        private System.Windows.Forms.Timer timer; 

        public IntroForm()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer(); 
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close(); 
        }
    }
}

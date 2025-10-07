namespace LibraryBookSystem
{
    partial class ManagerMenuUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn6 = new System.Windows.Forms.Button();
            this.OverDuebtn = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.Button();
            this.manageLibrartStaffBtn = new System.Windows.Forms.Button();
            this.viewDataBaseTableBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(617, 338);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(177, 153);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "Coming soon";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.viewBorrowHistBtn_Click);
            // 
            // OverDuebtn
            // 
            this.OverDuebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OverDuebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverDuebtn.Location = new System.Drawing.Point(350, 338);
            this.OverDuebtn.Name = "OverDuebtn";
            this.OverDuebtn.Size = new System.Drawing.Size(177, 153);
            this.OverDuebtn.TabIndex = 16;
            this.OverDuebtn.Text = "View overdue returns";
            this.OverDuebtn.UseVisualStyleBackColor = false;
            this.OverDuebtn.Click += new System.EventHandler(this.returnedBookBtn_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(79, 338);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(177, 153);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "Add new Book";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.viewBookingsBtn_Click);
            // 
            // Statistics
            // 
            this.Statistics.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Statistics.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics.Location = new System.Drawing.Point(617, 79);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(177, 153);
            this.Statistics.TabIndex = 14;
            this.Statistics.Text = "View Statistics";
            this.Statistics.UseVisualStyleBackColor = false;
            this.Statistics.Click += new System.EventHandler(this.bookingBtn_Click);
            // 
            // manageLibrartStaffBtn
            // 
            this.manageLibrartStaffBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.manageLibrartStaffBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageLibrartStaffBtn.Location = new System.Drawing.Point(350, 79);
            this.manageLibrartStaffBtn.Name = "manageLibrartStaffBtn";
            this.manageLibrartStaffBtn.Size = new System.Drawing.Size(177, 153);
            this.manageLibrartStaffBtn.TabIndex = 13;
            this.manageLibrartStaffBtn.Text = "Manage Library Staff";
            this.manageLibrartStaffBtn.UseVisualStyleBackColor = false;
            this.manageLibrartStaffBtn.Click += new System.EventHandler(this.availableBooksBtn_Click);
            // 
            // viewDataBaseTableBtn
            // 
            this.viewDataBaseTableBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewDataBaseTableBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDataBaseTableBtn.Location = new System.Drawing.Point(79, 79);
            this.viewDataBaseTableBtn.Name = "viewDataBaseTableBtn";
            this.viewDataBaseTableBtn.Size = new System.Drawing.Size(177, 153);
            this.viewDataBaseTableBtn.TabIndex = 12;
            this.viewDataBaseTableBtn.Text = "View Database Tables";
            this.viewDataBaseTableBtn.UseVisualStyleBackColor = false;
            this.viewDataBaseTableBtn.Click += new System.EventHandler(this.ViewDatabaseTableBtn_Click);
            // 
            // ManagerMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.OverDuebtn);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.manageLibrartStaffBtn);
            this.Controls.Add(this.viewDataBaseTableBtn);
            this.MaximumSize = new System.Drawing.Size(890, 555);
            this.MinimumSize = new System.Drawing.Size(890, 555);
            this.Name = "ManagerMenuUserControl";
            this.Size = new System.Drawing.Size(890, 555);
            this.Load += new System.EventHandler(this.ManagerMenuUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button OverDuebtn;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Button manageLibrartStaffBtn;
        private System.Windows.Forms.Button viewDataBaseTableBtn;
    }
}

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
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.manageLibrartStaffBtn = new System.Windows.Forms.Button();
            this.viewDataBaseTableBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(617, 338);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(177, 153);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "feature 6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.viewBorrowHistBtn_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(350, 338);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(177, 153);
            this.btn5.TabIndex = 16;
            this.btn5.Text = "View overdue returns";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.returnedBookBtn_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(79, 338);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(177, 153);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "Add new Book";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.viewBookingsBtn_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(617, 79);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(177, 153);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "View Statistics";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.bookingBtn_Click);
            // 
            // manageLibrartStaffBtn
            // 
            this.manageLibrartStaffBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageLibrartStaffBtn.Location = new System.Drawing.Point(350, 79);
            this.manageLibrartStaffBtn.Name = "manageLibrartStaffBtn";
            this.manageLibrartStaffBtn.Size = new System.Drawing.Size(177, 153);
            this.manageLibrartStaffBtn.TabIndex = 13;
            this.manageLibrartStaffBtn.Text = "Manage Library Staff";
            this.manageLibrartStaffBtn.UseVisualStyleBackColor = true;
            this.manageLibrartStaffBtn.Click += new System.EventHandler(this.availableBooksBtn_Click);
            // 
            // viewDataBaseTableBtn
            // 
            this.viewDataBaseTableBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDataBaseTableBtn.Location = new System.Drawing.Point(79, 79);
            this.viewDataBaseTableBtn.Name = "viewDataBaseTableBtn";
            this.viewDataBaseTableBtn.Size = new System.Drawing.Size(177, 153);
            this.viewDataBaseTableBtn.TabIndex = 12;
            this.viewDataBaseTableBtn.Text = "View Database Tables";
            this.viewDataBaseTableBtn.UseVisualStyleBackColor = true;
            this.viewDataBaseTableBtn.Click += new System.EventHandler(this.CreateNewStudentBtn_Click);
            // 
            // ManagerMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.manageLibrartStaffBtn);
            this.Controls.Add(this.viewDataBaseTableBtn);
            this.MaximumSize = new System.Drawing.Size(890, 555);
            this.MinimumSize = new System.Drawing.Size(890, 555);
            this.Name = "ManagerMenuUserControl";
            this.Size = new System.Drawing.Size(890, 555);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button manageLibrartStaffBtn;
        private System.Windows.Forms.Button viewDataBaseTableBtn;
    }
}

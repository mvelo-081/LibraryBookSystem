namespace LibraryBookSystem
{
    partial class MenuUserControl
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
            this.viewBorrowHistBtn = new System.Windows.Forms.Button();
            this.returnedBookBtn = new System.Windows.Forms.Button();
            this.viewReservationsBtn = new System.Windows.Forms.Button();
            this.bookingBtn = new System.Windows.Forms.Button();
            this.availableBooksBtn = new System.Windows.Forms.Button();
            this.CreateNewStudentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewBorrowHistBtn
            // 
            this.viewBorrowHistBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBorrowHistBtn.Location = new System.Drawing.Point(623, 332);
            this.viewBorrowHistBtn.Name = "viewBorrowHistBtn";
            this.viewBorrowHistBtn.Size = new System.Drawing.Size(177, 153);
            this.viewBorrowHistBtn.TabIndex = 11;
            this.viewBorrowHistBtn.Text = "View Borrow History";
            this.viewBorrowHistBtn.UseVisualStyleBackColor = true;
            // 
            // returnedBookBtn
            // 
            this.returnedBookBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedBookBtn.Location = new System.Drawing.Point(356, 332);
            this.returnedBookBtn.Name = "returnedBookBtn";
            this.returnedBookBtn.Size = new System.Drawing.Size(177, 153);
            this.returnedBookBtn.TabIndex = 10;
            this.returnedBookBtn.Text = "Return A Book";
            this.returnedBookBtn.UseVisualStyleBackColor = true;
            // 
            // viewReservationsBtn
            // 
            this.viewReservationsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReservationsBtn.Location = new System.Drawing.Point(74, 332);
            this.viewReservationsBtn.Name = "viewReservationsBtn";
            this.viewReservationsBtn.Size = new System.Drawing.Size(177, 153);
            this.viewReservationsBtn.TabIndex = 9;
            this.viewReservationsBtn.Text = "View Reservations";
            this.viewReservationsBtn.UseVisualStyleBackColor = true;
            // 
            // bookingBtn
            // 
            this.bookingBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingBtn.Location = new System.Drawing.Point(623, 69);
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.Size = new System.Drawing.Size(177, 153);
            this.bookingBtn.TabIndex = 8;
            this.bookingBtn.Text = "Issue A Book";
            this.bookingBtn.UseVisualStyleBackColor = true;
            // 
            // availableBooksBtn
            // 
            this.availableBooksBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableBooksBtn.Location = new System.Drawing.Point(356, 69);
            this.availableBooksBtn.Name = "availableBooksBtn";
            this.availableBooksBtn.Size = new System.Drawing.Size(177, 153);
            this.availableBooksBtn.TabIndex = 7;
            this.availableBooksBtn.Text = "View Available Books";
            this.availableBooksBtn.UseVisualStyleBackColor = true;
            // 
            // CreateNewStudentBtn
            // 
            this.CreateNewStudentBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewStudentBtn.Location = new System.Drawing.Point(74, 69);
            this.CreateNewStudentBtn.Name = "CreateNewStudentBtn";
            this.CreateNewStudentBtn.Size = new System.Drawing.Size(177, 153);
            this.CreateNewStudentBtn.TabIndex = 6;
            this.CreateNewStudentBtn.Text = "New Student";
            this.CreateNewStudentBtn.UseVisualStyleBackColor = true;
            // 
            // MenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewBorrowHistBtn);
            this.Controls.Add(this.returnedBookBtn);
            this.Controls.Add(this.viewReservationsBtn);
            this.Controls.Add(this.bookingBtn);
            this.Controls.Add(this.availableBooksBtn);
            this.Controls.Add(this.CreateNewStudentBtn);
            this.MaximumSize = new System.Drawing.Size(890, 555);
            this.MinimumSize = new System.Drawing.Size(890, 555);
            this.Name = "MenuUserControl";
            this.Size = new System.Drawing.Size(890, 555);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewBorrowHistBtn;
        private System.Windows.Forms.Button returnedBookBtn;
        private System.Windows.Forms.Button viewReservationsBtn;
        private System.Windows.Forms.Button bookingBtn;
        private System.Windows.Forms.Button availableBooksBtn;
        private System.Windows.Forms.Button CreateNewStudentBtn;
    }
}

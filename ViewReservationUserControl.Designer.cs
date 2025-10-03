namespace LibraryBookSystem
{
    partial class ViewReservationUserControl
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.studentnameSurnameTextData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookingSubmitBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.bookTitleData = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.studentEmailData = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(279, 360);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(209, 17);
            this.ErrorLabel.TabIndex = 39;
            this.ErrorLabel.Text = "Use the Mananger Profile to Sign in!";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // studentnameSurnameTextData
            // 
            this.studentnameSurnameTextData.BackColor = System.Drawing.SystemColors.Control;
            this.studentnameSurnameTextData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentnameSurnameTextData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentnameSurnameTextData.Location = new System.Drawing.Point(248, 220);
            this.studentnameSurnameTextData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentnameSurnameTextData.Name = "studentnameSurnameTextData";
            this.studentnameSurnameTextData.Size = new System.Drawing.Size(277, 30);
            this.studentnameSurnameTextData.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Enter Name and Surname:";
            // 
            // bookingSubmitBtn
            // 
            this.bookingSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingSubmitBtn.Location = new System.Drawing.Point(409, 386);
            this.bookingSubmitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookingSubmitBtn.Name = "bookingSubmitBtn";
            this.bookingSubmitBtn.Size = new System.Drawing.Size(133, 34);
            this.bookingSubmitBtn.TabIndex = 34;
            this.bookingSubmitBtn.Text = "Submit";
            this.bookingSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(248, 386);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(155, 34);
            this.CancelBtn.TabIndex = 33;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // bookTitleData
            // 
            this.bookTitleData.BackColor = System.Drawing.SystemColors.Control;
            this.bookTitleData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookTitleData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleData.Location = new System.Drawing.Point(248, 324);
            this.bookTitleData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookTitleData.Name = "bookTitleData";
            this.bookTitleData.Size = new System.Drawing.Size(277, 30);
            this.bookTitleData.TabIndex = 32;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(246, 278);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(134, 23);
            this.passwordLabel.TabIndex = 31;
            this.passwordLabel.Text = "Enter Book Title:";
            // 
            // studentEmailData
            // 
            this.studentEmailData.BackColor = System.Drawing.SystemColors.Control;
            this.studentEmailData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentEmailData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEmailData.Location = new System.Drawing.Point(248, 124);
            this.studentEmailData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentEmailData.Name = "studentEmailData";
            this.studentEmailData.Size = new System.Drawing.Size(277, 30);
            this.studentEmailData.TabIndex = 30;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(246, 78);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(164, 23);
            this.roleLabel.TabIndex = 29;
            this.roleLabel.Text = "Enter Student Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 38);
            this.label1.TabIndex = 28;
            this.label1.Text = "Make a book reservation";
            // 
            // ViewReservationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.studentnameSurnameTextData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookingSubmitBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.bookTitleData);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.studentEmailData);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.label1);
            this.Name = "ViewReservationUserControl";
            this.Size = new System.Drawing.Size(890, 555);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox studentnameSurnameTextData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bookingSubmitBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox bookTitleData;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox studentEmailData;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label label1;
    }
}

namespace LibraryBookSystem
{
    partial class ReturnBookUserControl1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.studentEmailData = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ConfirmBookReturnBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.studentnameSurnameTextData = new System.Windows.Forms.TextBox();
            this.BookCombBox = new System.Windows.Forms.ComboBox();
            this.fetchBookListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Return book";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(288, 404);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(209, 17);
            this.ErrorLabel.TabIndex = 39;
            this.ErrorLabel.Text = "Use the Mananger Profile to Sign in!";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(250, 70);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(164, 23);
            this.roleLabel.TabIndex = 29;
            this.roleLabel.Text = "Enter Student Email:";
            // 
            // studentEmailData
            // 
            this.studentEmailData.BackColor = System.Drawing.SystemColors.Control;
            this.studentEmailData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentEmailData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEmailData.Location = new System.Drawing.Point(252, 116);
            this.studentEmailData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentEmailData.Name = "studentEmailData";
            this.studentEmailData.Size = new System.Drawing.Size(277, 30);
            this.studentEmailData.TabIndex = 30;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(250, 270);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(201, 23);
            this.passwordLabel.TabIndex = 31;
            this.passwordLabel.Text = "Choose a book to return:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(204, 423);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(155, 34);
            this.CancelBtn.TabIndex = 33;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ConfirmBookReturnBtn
            // 
            this.ConfirmBookReturnBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBookReturnBtn.Location = new System.Drawing.Point(443, 423);
            this.ConfirmBookReturnBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmBookReturnBtn.Name = "ConfirmBookReturnBtn";
            this.ConfirmBookReturnBtn.Size = new System.Drawing.Size(133, 34);
            this.ConfirmBookReturnBtn.TabIndex = 34;
            this.ConfirmBookReturnBtn.Text = "Submit";
            this.ConfirmBookReturnBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Enter Name and Surname:";
            // 
            // studentnameSurnameTextData
            // 
            this.studentnameSurnameTextData.BackColor = System.Drawing.SystemColors.Control;
            this.studentnameSurnameTextData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentnameSurnameTextData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentnameSurnameTextData.Location = new System.Drawing.Point(252, 212);
            this.studentnameSurnameTextData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentnameSurnameTextData.Name = "studentnameSurnameTextData";
            this.studentnameSurnameTextData.Size = new System.Drawing.Size(277, 30);
            this.studentnameSurnameTextData.TabIndex = 38;
            // 
            // BookCombBox
            // 
            this.BookCombBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCombBox.FormattingEnabled = true;
            this.BookCombBox.Location = new System.Drawing.Point(252, 316);
            this.BookCombBox.Name = "BookCombBox";
            this.BookCombBox.Size = new System.Drawing.Size(277, 31);
            this.BookCombBox.TabIndex = 40;
            // 
            // fetchBookListBtn
            // 
            this.fetchBookListBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchBookListBtn.Location = new System.Drawing.Point(252, 368);
            this.fetchBookListBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fetchBookListBtn.Name = "fetchBookListBtn";
            this.fetchBookListBtn.Size = new System.Drawing.Size(277, 34);
            this.fetchBookListBtn.TabIndex = 41;
            this.fetchBookListBtn.Text = "Check pending returns";
            this.fetchBookListBtn.UseVisualStyleBackColor = true;
            // 
            // ReturnBookUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fetchBookListBtn);
            this.Controls.Add(this.BookCombBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.studentnameSurnameTextData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConfirmBookReturnBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.studentEmailData);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(890, 555);
            this.MinimumSize = new System.Drawing.Size(890, 555);
            this.Name = "ReturnBookUserControl1";
            this.Size = new System.Drawing.Size(890, 555);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox studentEmailData;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ConfirmBookReturnBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentnameSurnameTextData;
        private System.Windows.Forms.ComboBox BookCombBox;
        private System.Windows.Forms.Button fetchBookListBtn;
    }
}

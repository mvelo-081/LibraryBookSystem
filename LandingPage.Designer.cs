namespace LibraryBookSystem
{
    partial class LandingPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ist2koDataSet = new LibraryBookSystem.ist2koDataSet();
            this.staffTableAdapter = new LibraryBookSystem.ist2koDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new LibraryBookSystem.ist2koDataSetTableAdapters.TableAdapterManager();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.UserIdTextData = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.UserPasswordTextData = new System.Windows.Forms.TextBox();
            this.signInBtn = new System.Windows.Forms.Button();
            this.subWelcomeLabel = new System.Windows.Forms.Label();
            this.navPanel = new System.Windows.Forms.Panel();
            this.toggleAdminRoleBtn = new System.Windows.Forms.Button();
            this.IconLabel = new System.Windows.Forms.Label();
            this.IconImgPanel = new System.Windows.Forms.Panel();
            this.LandingPageMainPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2koDataSet)).BeginInit();
            this.navPanel.SuspendLayout();
            this.LandingPageMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.ist2koDataSet;
            // 
            // ist2koDataSet
            // 
            this.ist2koDataSet.DataSetName = "ist2koDataSet";
            this.ist2koDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BorrowTableAdapter = null;
            this.tableAdapterManager.ReservationTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryBookSystem.ist2koDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(437, 162);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(349, 38);
            this.welcomeLabel.TabIndex = 15;
            this.welcomeLabel.Text = "Welcome back, Librarian!";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(381, 249);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(205, 23);
            this.roleLabel.TabIndex = 16;
            this.roleLabel.Text = "Enter Librarian username:";
            // 
            // UserIdTextData
            // 
            this.UserIdTextData.BackColor = System.Drawing.SystemColors.Control;
            this.UserIdTextData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserIdTextData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdTextData.Location = new System.Drawing.Point(385, 295);
            this.UserIdTextData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserIdTextData.Name = "UserIdTextData";
            this.UserIdTextData.Size = new System.Drawing.Size(277, 30);
            this.UserIdTextData.TabIndex = 17;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(381, 345);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(130, 23);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Enter password:";
            // 
            // UserPasswordTextData
            // 
            this.UserPasswordTextData.BackColor = System.Drawing.SystemColors.Control;
            this.UserPasswordTextData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPasswordTextData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPasswordTextData.Location = new System.Drawing.Point(385, 391);
            this.UserPasswordTextData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserPasswordTextData.Name = "UserPasswordTextData";
            this.UserPasswordTextData.PasswordChar = '5';
            this.UserPasswordTextData.Size = new System.Drawing.Size(277, 30);
            this.UserPasswordTextData.TabIndex = 19;
            this.UserPasswordTextData.UseSystemPasswordChar = true;
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.signInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signInBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.Location = new System.Drawing.Point(385, 448);
            this.signInBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(187, 42);
            this.signInBtn.TabIndex = 20;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.UseVisualStyleBackColor = false;
            // 
            // subWelcomeLabel
            // 
            this.subWelcomeLabel.AutoSize = true;
            this.subWelcomeLabel.Location = new System.Drawing.Point(435, 203);
            this.subWelcomeLabel.Name = "subWelcomeLabel";
            this.subWelcomeLabel.Size = new System.Drawing.Size(356, 16);
            this.subWelcomeLabel.TabIndex = 21;
            this.subWelcomeLabel.Text = "Manage books, members, and library operations with ease";
            this.subWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navPanel
            // 
            this.navPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navPanel.Controls.Add(this.toggleAdminRoleBtn);
            this.navPanel.Controls.Add(this.IconLabel);
            this.navPanel.Controls.Add(this.IconImgPanel);
            this.navPanel.Location = new System.Drawing.Point(12, 12);
            this.navPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(1149, 62);
            this.navPanel.TabIndex = 22;
            // 
            // toggleAdminRoleBtn
            // 
            this.toggleAdminRoleBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toggleAdminRoleBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleAdminRoleBtn.Location = new System.Drawing.Point(979, 14);
            this.toggleAdminRoleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toggleAdminRoleBtn.Name = "toggleAdminRoleBtn";
            this.toggleAdminRoleBtn.Size = new System.Drawing.Size(155, 34);
            this.toggleAdminRoleBtn.TabIndex = 1;
            this.toggleAdminRoleBtn.Text = "Manager profile";
            this.toggleAdminRoleBtn.UseVisualStyleBackColor = false;
            // 
            // IconLabel
            // 
            this.IconLabel.AutoSize = true;
            this.IconLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconLabel.Location = new System.Drawing.Point(83, 14);
            this.IconLabel.Name = "IconLabel";
            this.IconLabel.Size = new System.Drawing.Size(245, 35);
            this.IconLabel.TabIndex = 1;
            this.IconLabel.Text = "Library book system";
            // 
            // IconImgPanel
            // 
            this.IconImgPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconImgPanel.BackgroundImage")));
            this.IconImgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconImgPanel.Location = new System.Drawing.Point(12, 2);
            this.IconImgPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconImgPanel.Name = "IconImgPanel";
            this.IconImgPanel.Size = new System.Drawing.Size(65, 54);
            this.IconImgPanel.TabIndex = 0;
            this.IconImgPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.IconImgPanel_Paint);
            // 
            // LandingPageMainPanel
            // 
            this.LandingPageMainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LandingPageMainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LandingPageMainPanel.BackgroundImage = global::LibraryBookSystem.Properties.Resources.pngwing_com;
            this.LandingPageMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LandingPageMainPanel.Controls.Add(this.ErrorLabel);
            this.LandingPageMainPanel.Controls.Add(this.navPanel);
            this.LandingPageMainPanel.Controls.Add(this.subWelcomeLabel);
            this.LandingPageMainPanel.Controls.Add(this.signInBtn);
            this.LandingPageMainPanel.Controls.Add(this.UserPasswordTextData);
            this.LandingPageMainPanel.Controls.Add(this.passwordLabel);
            this.LandingPageMainPanel.Controls.Add(this.UserIdTextData);
            this.LandingPageMainPanel.Controls.Add(this.roleLabel);
            this.LandingPageMainPanel.Controls.Add(this.welcomeLabel);
            this.LandingPageMainPanel.Location = new System.Drawing.Point(2, 2);
            this.LandingPageMainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LandingPageMainPanel.MinimumSize = new System.Drawing.Size(1173, 661);
            this.LandingPageMainPanel.Name = "LandingPageMainPanel";
            this.LandingPageMainPanel.Size = new System.Drawing.Size(1180, 667);
            this.LandingPageMainPanel.TabIndex = 8;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(381, 426);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(209, 17);
            this.ErrorLabel.TabIndex = 23;
            this.ErrorLabel.Text = "Use the Mananger Profile to Sign in!";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1172, 658);
            this.Controls.Add(this.LandingPageMainPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1190, 705);
            this.MinimumSize = new System.Drawing.Size(1190, 705);
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2koDataSet)).EndInit();
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.LandingPageMainPanel.ResumeLayout(false);
            this.LandingPageMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource staffBindingSource;
        private ist2koDataSet ist2koDataSet;
        private ist2koDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private ist2koDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox UserIdTextData;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox UserPasswordTextData;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label subWelcomeLabel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button toggleAdminRoleBtn;
        private System.Windows.Forms.Label IconLabel;
        private System.Windows.Forms.Panel IconImgPanel;
        private System.Windows.Forms.Panel LandingPageMainPanel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}


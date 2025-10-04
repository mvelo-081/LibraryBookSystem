namespace LibraryBookSystem
{
    partial class LibrarianHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianHomePage));
            this.navPanel = new System.Windows.Forms.Panel();
            this.viewReservationBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.signoutBtn = new System.Windows.Forms.Button();
            this.IconLabel = new System.Windows.Forms.Label();
            this.IconImgPanel = new System.Windows.Forms.Panel();
            this.homePagePanel = new System.Windows.Forms.Panel();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navPanel.Controls.Add(this.viewReservationBtn);
            this.navPanel.Controls.Add(this.menuBtn);
            this.navPanel.Controls.Add(this.signoutBtn);
            this.navPanel.Controls.Add(this.IconLabel);
            this.navPanel.Controls.Add(this.IconImgPanel);
            this.navPanel.Location = new System.Drawing.Point(12, 12);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(1148, 62);
            this.navPanel.TabIndex = 1;
            // 
            // viewReservationBtn
            // 
            this.viewReservationBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReservationBtn.Location = new System.Drawing.Point(644, 13);
            this.viewReservationBtn.Name = "viewReservationBtn";
            this.viewReservationBtn.Size = new System.Drawing.Size(177, 35);
            this.viewReservationBtn.TabIndex = 4;
            this.viewReservationBtn.Text = "Add Reservation";
            this.viewReservationBtn.UseVisualStyleBackColor = true;
            this.viewReservationBtn.Visible = false;
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(827, 13);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(155, 35);
            this.menuBtn.TabIndex = 3;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Visible = false;
            // 
            // signoutBtn
            // 
            this.signoutBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutBtn.Location = new System.Drawing.Point(988, 13);
            this.signoutBtn.Name = "signoutBtn";
            this.signoutBtn.Size = new System.Drawing.Size(155, 35);
            this.signoutBtn.TabIndex = 2;
            this.signoutBtn.Text = "Sign out";
            this.signoutBtn.UseVisualStyleBackColor = true;
            this.signoutBtn.Click += new System.EventHandler(this.signoutBtn_Click);
            // 
            // IconLabel
            // 
            this.IconLabel.AutoSize = true;
            this.IconLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconLabel.Location = new System.Drawing.Point(83, 13);
            this.IconLabel.Name = "IconLabel";
            this.IconLabel.Size = new System.Drawing.Size(245, 35);
            this.IconLabel.TabIndex = 1;
            this.IconLabel.Text = "Library book system";
            // 
            // IconImgPanel
            // 
            this.IconImgPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconImgPanel.BackgroundImage")));
            this.IconImgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconImgPanel.Location = new System.Drawing.Point(12, 3);
            this.IconImgPanel.Name = "IconImgPanel";
            this.IconImgPanel.Size = new System.Drawing.Size(65, 54);
            this.IconImgPanel.TabIndex = 0;
            // 
            // homePagePanel
            // 
            this.homePagePanel.BackColor = System.Drawing.Color.Transparent;
            this.homePagePanel.Location = new System.Drawing.Point(175, 105);
            this.homePagePanel.MaximumSize = new System.Drawing.Size(890, 555);
            this.homePagePanel.MinimumSize = new System.Drawing.Size(890, 555);
            this.homePagePanel.Name = "homePagePanel";
            this.homePagePanel.Size = new System.Drawing.Size(890, 555);
            this.homePagePanel.TabIndex = 2;
            // 
            // LibrarianHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.homePagePanel);
            this.Controls.Add(this.navPanel);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1190, 705);
            this.MinimumSize = new System.Drawing.Size(1190, 705);
            this.Name = "LibrarianHomePage";
            this.Size = new System.Drawing.Size(1190, 705);
            this.Load += new System.EventHandler(this.LibrarianHomePage_Load);
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label IconLabel;
        private System.Windows.Forms.Panel IconImgPanel;
        private System.Windows.Forms.Panel homePagePanel;
        private System.Windows.Forms.Button signoutBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button viewReservationBtn;
    }
}
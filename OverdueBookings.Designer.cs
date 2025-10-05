namespace LibraryBookSystem
{
    partial class OverdueBookings
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
            this.label5 = new System.Windows.Forms.Label();
            this.overdueBookingTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.overdueBookingTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "View overdue bookings";
            // 
            // overdueBookingTable
            // 
            this.overdueBookingTable.AllowUserToAddRows = false;
            this.overdueBookingTable.AllowUserToDeleteRows = false;
            this.overdueBookingTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.overdueBookingTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.overdueBookingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overdueBookingTable.Location = new System.Drawing.Point(4, 79);
            this.overdueBookingTable.Name = "overdueBookingTable";
            this.overdueBookingTable.ReadOnly = true;
            this.overdueBookingTable.RowHeadersWidth = 51;
            this.overdueBookingTable.RowTemplate.Height = 24;
            this.overdueBookingTable.Size = new System.Drawing.Size(883, 476);
            this.overdueBookingTable.TabIndex = 11;
            // 
            // OverdueBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.overdueBookingTable);
            this.Controls.Add(this.label5);
            this.MaximumSize = new System.Drawing.Size(890, 555);
            this.MinimumSize = new System.Drawing.Size(890, 555);
            this.Name = "OverdueBookings";
            this.Size = new System.Drawing.Size(890, 555);
            this.Load += new System.EventHandler(this.OverdueBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.overdueBookingTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView overdueBookingTable;
    }
}

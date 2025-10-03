namespace LibraryBookSystem
{
    partial class ViewBooksUserControl
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
            this.roleLabel = new System.Windows.Forms.Label();
            this.bookNameData = new System.Windows.Forms.TextBox();
            this.bookCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book Inventory";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(3, 71);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(145, 23);
            this.roleLabel.TabIndex = 30;
            this.roleLabel.Text = "Enter Book name:";
            // 
            // bookNameData
            // 
            this.bookNameData.BackColor = System.Drawing.SystemColors.Control;
            this.bookNameData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookNameData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameData.Location = new System.Drawing.Point(154, 69);
            this.bookNameData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookNameData.Name = "bookNameData";
            this.bookNameData.Size = new System.Drawing.Size(501, 30);
            this.bookNameData.TabIndex = 31;
            // 
            // bookCategoryComboBox
            // 
            this.bookCategoryComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCategoryComboBox.FormattingEnabled = true;
            this.bookCategoryComboBox.Location = new System.Drawing.Point(661, 69);
            this.bookCategoryComboBox.Name = "bookCategoryComboBox";
            this.bookCategoryComboBox.Size = new System.Drawing.Size(226, 31);
            this.bookCategoryComboBox.TabIndex = 41;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 106);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(887, 446);
            this.dataGridView.TabIndex = 47;
            // 
            // ViewBooksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bookCategoryComboBox);
            this.Controls.Add(this.bookNameData);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(890, 555);
            this.MinimumSize = new System.Drawing.Size(890, 555);
            this.Name = "ViewBooksUserControl";
            this.Size = new System.Drawing.Size(890, 555);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox bookNameData;
        private System.Windows.Forms.ComboBox bookCategoryComboBox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

namespace LibraryBookSystem
{
    partial class AddNewBook
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ist2koDataSet = new LibraryBookSystem.ist2koDataSet();
            this.bookAuthor = new System.Windows.Forms.TextBox();
            this.bookCategory = new System.Windows.Forms.TextBox();
            this.bookQuantity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bookTableAdapter = new LibraryBookSystem.ist2koDataSetTableAdapters.BookTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2koDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Author:";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Category:";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Quantity:";
            // 
            // bookTitle
            // 
            this.bookTitle.BackColor = System.Drawing.SystemColors.Control;
            this.bookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Book_Title", true));
            this.bookTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitle.Location = new System.Drawing.Point(187, 132);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(422, 30);
            this.bookTitle.TabIndex = 4;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.ist2koDataSet;
            // 
            // ist2koDataSet
            // 
            this.ist2koDataSet.DataSetName = "ist2koDataSet";
            this.ist2koDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookAuthor
            // 
            this.bookAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.bookAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Book_Author", true));
            this.bookAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAuthor.Location = new System.Drawing.Point(187, 224);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(422, 30);
            this.bookAuthor.TabIndex = 5;
            // 
            // bookCategory
            // 
            this.bookCategory.BackColor = System.Drawing.SystemColors.Control;
            this.bookCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Book_Category", true));
            this.bookCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCategory.Location = new System.Drawing.Point(187, 324);
            this.bookCategory.Name = "bookCategory";
            this.bookCategory.Size = new System.Drawing.Size(422, 30);
            this.bookCategory.TabIndex = 6;
            // 
            // bookQuantity
            // 
            this.bookQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.bookQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Book_Quantity", true));
            this.bookQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookQuantity.Location = new System.Drawing.Point(187, 420);
            this.bookQuantity.Name = "bookQuantity";
            this.bookQuantity.Size = new System.Drawing.Size(422, 30);
            this.bookQuantity.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(423, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Add a new book";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(235, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookQuantity);
            this.Controls.Add(this.bookCategory);
            this.Controls.Add(this.bookAuthor);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewBook";
            this.Size = new System.Drawing.Size(890, 555);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2koDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookTitle;
        private System.Windows.Forms.TextBox bookAuthor;
        private System.Windows.Forms.TextBox bookCategory;
        private System.Windows.Forms.TextBox bookQuantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private ist2koDataSet ist2koDataSet;
        private ist2koDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}

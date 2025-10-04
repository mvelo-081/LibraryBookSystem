using LibraryBookSystem.ist2koDataSetTableAdapters;

namespace LibraryBookSystem
{
    partial class ViewDatabase
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ist2koDataSet = new LibraryBookSystem.ist2koDataSet();
            this.ist2koDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ist2koDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ist2koDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2koDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2koDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2koDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2koDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // ist2koDataSet
            // 
            this.ist2koDataSet.DataSetName = "ist2koDataSet";
            this.ist2koDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ist2koDataSetBindingSource
            // 
            this.ist2koDataSetBindingSource.DataSource = this.ist2koDataSet;
            this.ist2koDataSetBindingSource.Position = 0;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.ist2koDataSetBindingSource;
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataMember = "Book";
            this.bookBindingSource1.DataSource = this.ist2koDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(764, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bookBindingSource2
            // 
            this.bookBindingSource2.DataMember = "Book";
            this.bookBindingSource2.DataSource = this.ist2koDataSet;
            // 
            // ist2koDataSetBindingSource1
            // 
            this.ist2koDataSetBindingSource1.DataSource = this.ist2koDataSet;
            this.ist2koDataSetBindingSource1.Position = 0;
            // 
            // ist2koDataSetBindingSource2
            // 
            this.ist2koDataSetBindingSource2.DataSource = this.ist2koDataSet;
            this.ist2koDataSetBindingSource2.Position = 0;
            // 
            // ViewDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewDatabase";
            this.Size = new System.Drawing.Size(818, 594);
            this.Load += new System.EventHandler(this.ViewDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2koDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2koDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2koDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2koDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ist2koDataSet ist2koDataSet;
        private System.Windows.Forms.BindingSource ist2koDataSetBindingSource;
        private System.Windows.Forms.BindingSource bookBindingSource;
       
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bookBindingSource2;
        private System.Windows.Forms.BindingSource ist2koDataSetBindingSource1;
        private System.Windows.Forms.BindingSource ist2koDataSetBindingSource2;
    }
}

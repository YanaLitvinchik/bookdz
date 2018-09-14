namespace HW7
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.tabPageAuthors = new System.Windows.Forms.TabPage();
            this.tabPagePublishers = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBooks);
            this.tabControl1.Controls.Add(this.tabPageAuthors);
            this.tabControl1.Controls.Add(this.tabPagePublishers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 641);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Controls.Add(this.dataGridView1);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(953, 615);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Books";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            this.tabPageBooks.Click += new System.EventHandler(this.tabPageBooks_Click);
            // 
            // tabPageAuthors
            // 
            this.tabPageAuthors.Location = new System.Drawing.Point(4, 22);
            this.tabPageAuthors.Name = "tabPageAuthors";
            this.tabPageAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthors.Size = new System.Drawing.Size(953, 615);
            this.tabPageAuthors.TabIndex = 1;
            this.tabPageAuthors.Text = "Authors";
            this.tabPageAuthors.UseVisualStyleBackColor = true;
            // 
            // tabPagePublishers
            // 
            this.tabPagePublishers.Location = new System.Drawing.Point(4, 22);
            this.tabPagePublishers.Name = "tabPagePublishers";
            this.tabPagePublishers.Size = new System.Drawing.Size(953, 615);
            this.tabPagePublishers.TabIndex = 0;
            this.tabPagePublishers.Text = "Publishers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 641);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.TabPage tabPageAuthors;
        private System.Windows.Forms.TabPage tabPagePublishers;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


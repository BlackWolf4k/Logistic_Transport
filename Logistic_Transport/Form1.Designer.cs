namespace Logistic_Transport
{
    partial class Logistic_Transport
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.columns_l = new System.Windows.Forms.Label();
            this.new_table_l = new System.Windows.Forms.Label();
            this.rows_l = new System.Windows.Forms.Label();
            this.columns_tb = new System.Windows.Forms.TextBox();
            this.rows_tb = new System.Windows.Forms.TextBox();
            this.run_b = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.last_table_b = new System.Windows.Forms.Button();
            this.make_new_table_b = new System.Windows.Forms.Button();
            this.data_table_dgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_table_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // columns_l
            // 
            this.columns_l.AutoSize = true;
            this.columns_l.Location = new System.Drawing.Point(179, 20);
            this.columns_l.Name = "columns_l";
            this.columns_l.Size = new System.Drawing.Size(58, 15);
            this.columns_l.TabIndex = 2;
            this.columns_l.Text = "Columns:";
            // 
            // new_table_l
            // 
            this.new_table_l.AutoSize = true;
            this.new_table_l.Location = new System.Drawing.Point(351, 20);
            this.new_table_l.Name = "new_table_l";
            this.new_table_l.Size = new System.Drawing.Size(94, 15);
            this.new_table_l.TabIndex = 3;
            this.new_table_l.Text = "Make new Table:";
            // 
            // rows_l
            // 
            this.rows_l.AutoSize = true;
            this.rows_l.Location = new System.Drawing.Point(12, 20);
            this.rows_l.Name = "rows_l";
            this.rows_l.Size = new System.Drawing.Size(38, 15);
            this.rows_l.TabIndex = 1;
            this.rows_l.Text = "Rows:";
            // 
            // columns_tb
            // 
            this.columns_tb.Location = new System.Drawing.Point(243, 17);
            this.columns_tb.Name = "columns_tb";
            this.columns_tb.ReadOnly = true;
            this.columns_tb.Size = new System.Drawing.Size(68, 23);
            this.columns_tb.TabIndex = 6;
            this.columns_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rows_tb
            // 
            this.rows_tb.Location = new System.Drawing.Point(56, 17);
            this.rows_tb.Name = "rows_tb";
            this.rows_tb.ReadOnly = true;
            this.rows_tb.Size = new System.Drawing.Size(68, 23);
            this.rows_tb.TabIndex = 5;
            this.rows_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // run_b
            // 
            this.run_b.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.run_b.Enabled = false;
            this.run_b.Location = new System.Drawing.Point(672, 12);
            this.run_b.Name = "run_b";
            this.run_b.Size = new System.Drawing.Size(100, 30);
            this.run_b.TabIndex = 7;
            this.run_b.Text = "Run";
            this.run_b.UseVisualStyleBackColor = true;
            this.run_b.Click += new System.EventHandler(this.run);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.last_table_b);
            this.panel1.Controls.Add(this.run_b);
            this.panel1.Controls.Add(this.rows_tb);
            this.panel1.Controls.Add(this.columns_tb);
            this.panel1.Controls.Add(this.make_new_table_b);
            this.panel1.Controls.Add(this.rows_l);
            this.panel1.Controls.Add(this.new_table_l);
            this.panel1.Controls.Add(this.columns_l);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 58);
            this.panel1.TabIndex = 9;
            // 
            // last_table_b
            // 
            this.last_table_b.Enabled = false;
            this.last_table_b.Location = new System.Drawing.Point(562, 12);
            this.last_table_b.Name = "last_table_b";
            this.last_table_b.Size = new System.Drawing.Size(78, 30);
            this.last_table_b.TabIndex = 8;
            this.last_table_b.Text = "Last";
            this.last_table_b.UseVisualStyleBackColor = true;
            this.last_table_b.Click += new System.EventHandler(this.reload_table);
            // 
            // make_new_table_b
            // 
            this.make_new_table_b.Location = new System.Drawing.Point(451, 12);
            this.make_new_table_b.Name = "make_new_table_b";
            this.make_new_table_b.Size = new System.Drawing.Size(78, 30);
            this.make_new_table_b.TabIndex = 4;
            this.make_new_table_b.Text = "New";
            this.make_new_table_b.UseVisualStyleBackColor = true;
            this.make_new_table_b.Click += new System.EventHandler(this.new_table);
            // 
            // data_table_dgv
            // 
            this.data_table_dgv.AllowUserToAddRows = false;
            this.data_table_dgv.AllowUserToDeleteRows = false;
            this.data_table_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_table_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_table_dgv.Location = new System.Drawing.Point(0, 58);
            this.data_table_dgv.Name = "data_table_dgv";
            this.data_table_dgv.RowTemplate.Height = 25;
            this.data_table_dgv.Size = new System.Drawing.Size(784, 353);
            this.data_table_dgv.TabIndex = 10;
            this.data_table_dgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.input_check);
            // 
            // Logistic_Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.data_table_dgv);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Logistic_Transport";
            this.Text = "Logistic Transport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_table_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label columns_l;
        private Label new_table_l;
        private Label rows_l;
        private TextBox columns_tb;
        private TextBox rows_tb;
        private Button run_b;
        private Panel panel1;
        private Button make_new_table_b;
        public DataGridView data_table_dgv;
        private Button last_table_b;
    }
}
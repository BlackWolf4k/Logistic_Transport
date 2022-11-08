namespace Logistic_Transport
{
    partial class Form1
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.run_b = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.make_new_table_b = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.new_table_l.Location = new System.Drawing.Point(362, 20);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(68, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(68, 23);
            this.textBox1.TabIndex = 5;
            // 
            // run_b
            // 
            this.run_b.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.run_b.Location = new System.Drawing.Point(672, 12);
            this.run_b.Name = "run_b";
            this.run_b.Size = new System.Drawing.Size(100, 30);
            this.run_b.TabIndex = 7;
            this.run_b.Text = "Run";
            this.run_b.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.run_b);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
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
            // make_new_table_b
            // 
            this.make_new_table_b.Location = new System.Drawing.Point(462, 12);
            this.make_new_table_b.Name = "make_new_table_b";
            this.make_new_table_b.Size = new System.Drawing.Size(120, 30);
            this.make_new_table_b.TabIndex = 4;
            this.make_new_table_b.Text = "New";
            this.make_new_table_b.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label columns_l;
        private Label new_table_l;
        private Label rows_l;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button run_b;
        private Panel panel1;
        private Button make_new_table_b;
    }
}
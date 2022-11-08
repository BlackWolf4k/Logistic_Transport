namespace Logistic_Transport
{
    partial class Informations
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
            this.columns_l = new System.Windows.Forms.Label();
            this.rows_l = new System.Windows.Forms.Label();
            this.columns_nud = new System.Windows.Forms.NumericUpDown();
            this.rows_nud = new System.Windows.Forms.NumericUpDown();
            this.select_b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.columns_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rows_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // columns_l
            // 
            this.columns_l.AutoSize = true;
            this.columns_l.Location = new System.Drawing.Point(90, 92);
            this.columns_l.Name = "columns_l";
            this.columns_l.Size = new System.Drawing.Size(92, 15);
            this.columns_l.TabIndex = 9;
            this.columns_l.Text = "Select Columns:";
            // 
            // rows_l
            // 
            this.rows_l.AutoSize = true;
            this.rows_l.Location = new System.Drawing.Point(90, 29);
            this.rows_l.Name = "rows_l";
            this.rows_l.Size = new System.Drawing.Size(72, 15);
            this.rows_l.TabIndex = 8;
            this.rows_l.Text = "Select Rows:";
            // 
            // columns_nud
            // 
            this.columns_nud.Location = new System.Drawing.Point(90, 110);
            this.columns_nud.Name = "columns_nud";
            this.columns_nud.Size = new System.Drawing.Size(100, 23);
            this.columns_nud.TabIndex = 7;
            // 
            // rows_nud
            // 
            this.rows_nud.Location = new System.Drawing.Point(90, 47);
            this.rows_nud.Name = "rows_nud";
            this.rows_nud.Size = new System.Drawing.Size(100, 23);
            this.rows_nud.TabIndex = 6;
            // 
            // select_b
            // 
            this.select_b.Location = new System.Drawing.Point(100, 182);
            this.select_b.Name = "select_b";
            this.select_b.Size = new System.Drawing.Size(80, 40);
            this.select_b.TabIndex = 5;
            this.select_b.Text = "Select";
            this.select_b.UseVisualStyleBackColor = true;
            // 
            // Informations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.columns_l);
            this.Controls.Add(this.rows_l);
            this.Controls.Add(this.columns_nud);
            this.Controls.Add(this.rows_nud);
            this.Controls.Add(this.select_b);
            this.Name = "Informations";
            this.Text = "Informations";
            ((System.ComponentModel.ISupportInitialize)(this.columns_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rows_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label columns_l;
        private Label rows_l;
        private NumericUpDown columns_nud;
        private NumericUpDown rows_nud;
        private Button select_b;
    }
}
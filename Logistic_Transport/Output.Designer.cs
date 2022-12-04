namespace Logistic_Transport
{
    partial class Output
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
            this.output_lv = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.run_minimum_prices_b = new System.Windows.Forms.Button();
            this.run_nord_west_b = new System.Windows.Forms.Button();
            this.step_by_step_cb = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // output_lv
            // 
            this.output_lv.FullRowSelect = true;
            this.output_lv.Location = new System.Drawing.Point(12, 58);
            this.output_lv.Name = "output_lv";
            this.output_lv.Size = new System.Drawing.Size(360, 391);
            this.output_lv.TabIndex = 0;
            this.output_lv.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.step_by_step_cb);
            this.panel1.Controls.Add(this.run_minimum_prices_b);
            this.panel1.Controls.Add(this.run_nord_west_b);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 50);
            this.panel1.TabIndex = 1;
            // 
            // run_minimum_prices_b
            // 
            this.run_minimum_prices_b.Location = new System.Drawing.Point(103, 3);
            this.run_minimum_prices_b.Name = "run_minimum_prices_b";
            this.run_minimum_prices_b.Size = new System.Drawing.Size(106, 40);
            this.run_minimum_prices_b.TabIndex = 1;
            this.run_minimum_prices_b.Text = "Minimum Prices";
            this.run_minimum_prices_b.UseVisualStyleBackColor = true;
            this.run_minimum_prices_b.Click += new System.EventHandler(this.run_minimum_prices);
            // 
            // run_nord_west_b
            // 
            this.run_nord_west_b.Location = new System.Drawing.Point(11, 3);
            this.run_nord_west_b.Name = "run_nord_west_b";
            this.run_nord_west_b.Size = new System.Drawing.Size(86, 40);
            this.run_nord_west_b.TabIndex = 0;
            this.run_nord_west_b.Text = "Nord-West";
            this.run_nord_west_b.UseVisualStyleBackColor = true;
            this.run_nord_west_b.Click += new System.EventHandler(this.run_nord_west);
            // 
            // step_by_step_cb
            // 
            this.step_by_step_cb.AutoSize = true;
            this.step_by_step_cb.Location = new System.Drawing.Point(280, 15);
            this.step_by_step_cb.Name = "step_by_step_cb";
            this.step_by_step_cb.Size = new System.Drawing.Size(91, 19);
            this.step_by_step_cb.TabIndex = 2;
            this.step_by_step_cb.Text = "Step By Step";
            this.step_by_step_cb.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.output_lv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Output";
            this.Text = "Output";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView output_lv;
        private Panel panel1;
        private Button run_minimum_prices_b;
        private Button run_nord_west_b;
        private CheckBox step_by_step_cb;
    }
}
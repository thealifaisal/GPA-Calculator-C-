namespace GPA_Calculator
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.save_btn = new System.Windows.Forms.Button();
            this.addTextBox_btn = new System.Windows.Forms.Button();
            this.cgpa_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.save_btn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(380, 178);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(228, 28);
            this.save_btn.TabIndex = 7;
            this.save_btn.Text = "save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // addTextBox_btn
            // 
            this.addTextBox_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addTextBox_btn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTextBox_btn.Location = new System.Drawing.Point(124, 178);
            this.addTextBox_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTextBox_btn.Name = "addTextBox_btn";
            this.addTextBox_btn.Size = new System.Drawing.Size(228, 28);
            this.addTextBox_btn.TabIndex = 6;
            this.addTextBox_btn.Text = "add text boxes";
            this.addTextBox_btn.UseVisualStyleBackColor = true;
            this.addTextBox_btn.Click += new System.EventHandler(this.addTextBox_btn_Click);
            // 
            // cgpa_label
            // 
            this.cgpa_label.AutoSize = true;
            this.cgpa_label.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpa_label.Location = new System.Drawing.Point(189, 70);
            this.cgpa_label.Name = "cgpa_label";
            this.cgpa_label.Size = new System.Drawing.Size(128, 44);
            this.cgpa_label.TabIndex = 0;
            this.cgpa_label.Text = "CGPA";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 603);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.addTextBox_btn);
            this.Controls.Add(this.cgpa_label);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button addTextBox_btn;
        private System.Windows.Forms.Label cgpa_label;
    }
}
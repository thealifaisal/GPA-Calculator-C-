namespace GPA_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.sgpa_btn = new System.Windows.Forms.Button();
            this.cgpa_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(218, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPA Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sgpa_btn
            // 
            this.sgpa_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sgpa_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgpa_btn.ForeColor = System.Drawing.Color.Black;
            this.sgpa_btn.Location = new System.Drawing.Point(299, 228);
            this.sgpa_btn.Name = "sgpa_btn";
            this.sgpa_btn.Size = new System.Drawing.Size(134, 38);
            this.sgpa_btn.TabIndex = 1;
            this.sgpa_btn.Text = "SGPA";
            this.sgpa_btn.UseVisualStyleBackColor = true;
            this.sgpa_btn.Click += new System.EventHandler(this.sgpa_btn_Click);
            // 
            // cgpa_btn
            // 
            this.cgpa_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cgpa_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpa_btn.ForeColor = System.Drawing.Color.Black;
            this.cgpa_btn.Location = new System.Drawing.Point(299, 281);
            this.cgpa_btn.Name = "cgpa_btn";
            this.cgpa_btn.Size = new System.Drawing.Size(134, 38);
            this.cgpa_btn.TabIndex = 2;
            this.cgpa_btn.Text = "CGPA";
            this.cgpa_btn.UseVisualStyleBackColor = true;
            this.cgpa_btn.Click += new System.EventHandler(this.cgpa_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exit_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(299, 334);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(134, 38);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 603);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.cgpa_btn);
            this.Controls.Add(this.sgpa_btn);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GPA Calculator";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sgpa_btn;
        private System.Windows.Forms.Button cgpa_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}


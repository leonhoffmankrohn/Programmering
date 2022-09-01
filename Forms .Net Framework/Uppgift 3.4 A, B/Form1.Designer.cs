namespace Uppgift_3._4_A__B
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
            this.lbl500 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lblUttag = new System.Windows.Forms.Label();
            this.btnUttag = new System.Windows.Forms.Button();
            this.tbxUttag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl500
            // 
            this.lbl500.AutoSize = true;
            this.lbl500.Location = new System.Drawing.Point(317, 260);
            this.lbl500.Name = "lbl500";
            this.lbl500.Size = new System.Drawing.Size(117, 13);
            this.lbl500.TabIndex = 0;
            this.lbl500.Text = "Uttag i 500-sedlar: --- kr";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Location = new System.Drawing.Point(317, 287);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(117, 13);
            this.lbl100.TabIndex = 1;
            this.lbl100.Text = "Uttag i 100-sedlar: --- kr";
            // 
            // lblUttag
            // 
            this.lblUttag.AutoSize = true;
            this.lblUttag.Location = new System.Drawing.Point(427, 219);
            this.lblUttag.Name = "lblUttag";
            this.lblUttag.Size = new System.Drawing.Size(39, 13);
            this.lblUttag.TabIndex = 2;
            this.lblUttag.Text = "Uttag -";
            // 
            // btnUttag
            // 
            this.btnUttag.Location = new System.Drawing.Point(519, 277);
            this.btnUttag.Name = "btnUttag";
            this.btnUttag.Size = new System.Drawing.Size(75, 23);
            this.btnUttag.TabIndex = 3;
            this.btnUttag.Text = "Tag ut";
            this.btnUttag.UseVisualStyleBackColor = true;
            this.btnUttag.Click += new System.EventHandler(this.btnUttag_Click);
            // 
            // tbxUttag
            // 
            this.tbxUttag.Location = new System.Drawing.Point(494, 216);
            this.tbxUttag.Name = "tbxUttag";
            this.tbxUttag.Size = new System.Drawing.Size(100, 20);
            this.tbxUttag.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxUttag);
            this.Controls.Add(this.btnUttag);
            this.Controls.Add(this.lblUttag);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lbl500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl500;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lblUttag;
        private System.Windows.Forms.Button btnUttag;
        private System.Windows.Forms.TextBox tbxUttag;
    }
}


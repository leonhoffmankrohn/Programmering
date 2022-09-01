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
            this.lbl500.Location = new System.Drawing.Point(159, 136);
            this.lbl500.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl500.Name = "lbl500";
            this.lbl500.Size = new System.Drawing.Size(239, 25);
            this.lbl500.TabIndex = 0;
            this.lbl500.Text = "Uttag i 500-sedlar: --- kr";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Location = new System.Drawing.Point(159, 179);
            this.lbl100.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(239, 25);
            this.lbl100.TabIndex = 1;
            this.lbl100.Text = "Uttag i 100-sedlar: --- kr";
            // 
            // lblUttag
            // 
            this.lblUttag.AutoSize = true;
            this.lblUttag.Location = new System.Drawing.Point(127, 68);
            this.lblUttag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUttag.Name = "lblUttag";
            this.lblUttag.Size = new System.Drawing.Size(76, 25);
            this.lblUttag.TabIndex = 2;
            this.lblUttag.Text = "Uttag -";
            // 
            // btnUttag
            // 
            this.btnUttag.Location = new System.Drawing.Point(201, 237);
            this.btnUttag.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUttag.Name = "btnUttag";
            this.btnUttag.Size = new System.Drawing.Size(149, 44);
            this.btnUttag.TabIndex = 3;
            this.btnUttag.Text = "Tag ut";
            this.btnUttag.UseVisualStyleBackColor = true;
            this.btnUttag.Click += new System.EventHandler(this.btnUttag_Click);
            // 
            // tbxUttag
            // 
            this.tbxUttag.Location = new System.Drawing.Point(233, 68);
            this.tbxUttag.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxUttag.Name = "tbxUttag";
            this.tbxUttag.Size = new System.Drawing.Size(196, 31);
            this.tbxUttag.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(573, 388);
            this.Controls.Add(this.tbxUttag);
            this.Controls.Add(this.btnUttag);
            this.Controls.Add(this.lblUttag);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lbl500);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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


namespace Uppgift_9._3
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
            this.tbxAntal = new System.Windows.Forms.TextBox();
            this.lblAntal = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxAntal
            // 
            this.tbxAntal.Location = new System.Drawing.Point(287, 123);
            this.tbxAntal.Name = "tbxAntal";
            this.tbxAntal.Size = new System.Drawing.Size(100, 20);
            this.tbxAntal.TabIndex = 0;
            this.tbxAntal.TextChanged += new System.EventHandler(this.tbxAntal_TextChanged);
            // 
            // lblAntal
            // 
            this.lblAntal.AutoSize = true;
            this.lblAntal.Location = new System.Drawing.Point(192, 123);
            this.lblAntal.Name = "lblAntal";
            this.lblAntal.Size = new System.Drawing.Size(73, 13);
            this.lblAntal.TabIndex = 1;
            this.lblAntal.Text = "Antal kilomter:";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(287, 215);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 2;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(223, 177);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(208, 24);
            this.lblResultat.TabIndex = 3;
            this.lblResultat.Text = "Du måste vika den: xxxxx gånger då.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 400);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblAntal);
            this.Controls.Add(this.tbxAntal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAntal;
        private System.Windows.Forms.Label lblAntal;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblResultat;
    }
}


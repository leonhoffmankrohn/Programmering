namespace Uppgift_9._6
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
            this.btnKör = new System.Windows.Forms.Button();
            this.lblAntal6 = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(146, 162);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 1;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // lblAntal6
            // 
            this.lblAntal6.AutoSize = true;
            this.lblAntal6.Location = new System.Drawing.Point(163, 103);
            this.lblAntal6.Name = "lblAntal6";
            this.lblAntal6.Size = new System.Drawing.Size(95, 13);
            this.lblAntal6.TabIndex = 2;
            this.lblAntal6.Text = "Antalet 6:or slagna";
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(202, 126);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(95, 33);
            this.lblResultat.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 306);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblAntal6);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblAntal6;
        private System.Windows.Forms.Label lblResultat;
    }
}


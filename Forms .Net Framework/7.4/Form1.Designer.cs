namespace _7._4
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
            this.lblAntal = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxAntal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAntal
            // 
            this.lblAntal.AutoSize = true;
            this.lblAntal.Location = new System.Drawing.Point(197, 122);
            this.lblAntal.Name = "lblAntal";
            this.lblAntal.Size = new System.Drawing.Size(62, 13);
            this.lblAntal.TabIndex = 0;
            this.lblAntal.Text = "Antal skivor";
            // 
            // lblSvar
            // 
            this.lblSvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSvar.Location = new System.Drawing.Point(167, 192);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(308, 23);
            this.lblSvar.TabIndex = 1;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(288, 245);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 2;
            this.btnKör.Text = "Beräkna priset";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxAntal
            // 
            this.tbxAntal.Location = new System.Drawing.Point(288, 119);
            this.tbxAntal.Name = "tbxAntal";
            this.tbxAntal.Size = new System.Drawing.Size(100, 20);
            this.tbxAntal.TabIndex = 3;
            this.tbxAntal.TextChanged += new System.EventHandler(this.tbxAntal_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxAntal);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblAntal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAntal;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxAntal;
    }
}


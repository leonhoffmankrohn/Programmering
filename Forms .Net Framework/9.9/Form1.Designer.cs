namespace _9._9
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
            this.btnFörskjut = new System.Windows.Forms.Button();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFörskjut
            // 
            this.btnFörskjut.Location = new System.Drawing.Point(363, 345);
            this.btnFörskjut.Name = "btnFörskjut";
            this.btnFörskjut.Size = new System.Drawing.Size(75, 23);
            this.btnFörskjut.TabIndex = 0;
            this.btnFörskjut.Text = "Förskjut";
            this.btnFörskjut.UseVisualStyleBackColor = true;
            this.btnFörskjut.Click += new System.EventHandler(this.btnFörskjut_Click);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(350, 171);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(100, 20);
            this.tbx1.TabIndex = 1;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(350, 215);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(100, 20);
            this.tbx2.TabIndex = 2;
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(350, 263);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(100, 20);
            this.tbx3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sträng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx3);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.btnFörskjut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFörskjut;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.Label label1;
    }
}


namespace _9._5
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
            this.lblStart = new System.Windows.Forms.Label();
            this.lblSlut = new System.Windows.Forms.Label();
            this.lblSteg = new System.Windows.Forms.Label();
            this.tbxStart = new System.Windows.Forms.TextBox();
            this.tbxSlut = new System.Windows.Forms.TextBox();
            this.tbxSteg = new System.Windows.Forms.TextBox();
            this.tbxUt = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(92, 115);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start";
            // 
            // lblSlut
            // 
            this.lblSlut.AutoSize = true;
            this.lblSlut.Location = new System.Drawing.Point(290, 115);
            this.lblSlut.Name = "lblSlut";
            this.lblSlut.Size = new System.Drawing.Size(25, 13);
            this.lblSlut.TabIndex = 1;
            this.lblSlut.Text = "Slut";
            // 
            // lblSteg
            // 
            this.lblSteg.AutoSize = true;
            this.lblSteg.Location = new System.Drawing.Point(483, 115);
            this.lblSteg.Name = "lblSteg";
            this.lblSteg.Size = new System.Drawing.Size(29, 13);
            this.lblSteg.TabIndex = 2;
            this.lblSteg.Text = "Steg";
            // 
            // tbxStart
            // 
            this.tbxStart.Location = new System.Drawing.Point(95, 145);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(100, 20);
            this.tbxStart.TabIndex = 3;
            // 
            // tbxSlut
            // 
            this.tbxSlut.Location = new System.Drawing.Point(259, 145);
            this.tbxSlut.Name = "tbxSlut";
            this.tbxSlut.Size = new System.Drawing.Size(100, 20);
            this.tbxSlut.TabIndex = 4;
            // 
            // tbxSteg
            // 
            this.tbxSteg.Location = new System.Drawing.Point(418, 145);
            this.tbxSteg.Name = "tbxSteg";
            this.tbxSteg.Size = new System.Drawing.Size(100, 20);
            this.tbxSteg.TabIndex = 5;
            // 
            // tbxUt
            // 
            this.tbxUt.Location = new System.Drawing.Point(95, 184);
            this.tbxUt.Multiline = true;
            this.tbxUt.Name = "tbxUt";
            this.tbxUt.Size = new System.Drawing.Size(423, 144);
            this.tbxUt.TabIndex = 6;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(259, 334);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 7;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxUt);
            this.Controls.Add(this.tbxSteg);
            this.Controls.Add(this.tbxSlut);
            this.Controls.Add(this.tbxStart);
            this.Controls.Add(this.lblSteg);
            this.Controls.Add(this.lblSlut);
            this.Controls.Add(this.lblStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblSlut;
        private System.Windows.Forms.Label lblSteg;
        private System.Windows.Forms.TextBox tbxStart;
        private System.Windows.Forms.TextBox tbxSlut;
        private System.Windows.Forms.TextBox tbxSteg;
        private System.Windows.Forms.TextBox tbxUt;
        private System.Windows.Forms.Button btnKör;
    }
}


namespace _5._3
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
            this.lblPengar = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPengar = new System.Windows.Forms.TextBox();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPengar
            // 
            this.lblPengar.AutoSize = true;
            this.lblPengar.Location = new System.Drawing.Point(226, 76);
            this.lblPengar.Name = "lblPengar";
            this.lblPengar.Size = new System.Drawing.Size(41, 13);
            this.lblPengar.TabIndex = 0;
            this.lblPengar.Text = "Pengar";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(276, 171);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 13);
            this.lblSvar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Varans pris:";
            // 
            // tbxPengar
            // 
            this.tbxPengar.Location = new System.Drawing.Point(304, 73);
            this.tbxPengar.Name = "tbxPengar";
            this.tbxPengar.Size = new System.Drawing.Size(100, 20);
            this.tbxPengar.TabIndex = 3;
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(304, 108);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(100, 20);
            this.tbxPris.TabIndex = 4;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(304, 217);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 5;
            this.btnKör.Text = "KÖR";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxPris);
            this.Controls.Add(this.tbxPengar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblPengar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPengar;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPengar;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.Button btnKör;
    }
}


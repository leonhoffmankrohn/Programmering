namespace _7._1
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.tbxLiter = new System.Windows.Forms.TextBox();
            this.lblLiter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(353, 264);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(314, 219);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 13);
            this.lblSvar.TabIndex = 1;
            // 
            // tbxLiter
            // 
            this.tbxLiter.Location = new System.Drawing.Point(385, 147);
            this.tbxLiter.Name = "tbxLiter";
            this.tbxLiter.Size = new System.Drawing.Size(100, 20);
            this.tbxLiter.TabIndex = 2;
            this.tbxLiter.TextChanged += new System.EventHandler(this.tbxLiter_TextChanged);
            // 
            // lblLiter
            // 
            this.lblLiter.AutoSize = true;
            this.lblLiter.Location = new System.Drawing.Point(268, 147);
            this.lblLiter.Name = "lblLiter";
            this.lblLiter.Size = new System.Drawing.Size(61, 13);
            this.lblLiter.TabIndex = 3;
            this.lblLiter.Text = "Liter bensin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLiter);
            this.Controls.Add(this.tbxLiter);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnOk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.TextBox tbxLiter;
        private System.Windows.Forms.Label lblLiter;
    }
}


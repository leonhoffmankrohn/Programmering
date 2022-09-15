namespace KokApp
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
            this.tbxSök = new System.Windows.Forms.TextBox();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnSök = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxSök
            // 
            this.tbxSök.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSök.Location = new System.Drawing.Point(49, 63);
            this.tbxSök.Name = "tbxSök";
            this.tbxSök.Size = new System.Drawing.Size(238, 31);
            this.tbxSök.TabIndex = 0;
            this.tbxSök.Text = "Skriv dina matprodukter";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(113, 143);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(16, 13);
            this.lblSvar.TabIndex = 1;
            this.lblSvar.Text = "...";
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(293, 63);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(53, 31);
            this.btnSök.TabIndex = 2;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 675);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.tbxSök);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSök;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnSök;
    }
}


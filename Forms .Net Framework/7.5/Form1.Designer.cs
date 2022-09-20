namespace _7._5
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.tbxVeckodagNr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(173, 117);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(88, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Veckodagens nr:";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(285, 214);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(124, 23);
            this.btnKör.TabIndex = 1;
            this.btnKör.Text = "Visa veckodag";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSvar.Location = new System.Drawing.Point(260, 177);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(188, 23);
            this.lblSvar.TabIndex = 2;
            // 
            // tbxVeckodagNr
            // 
            this.tbxVeckodagNr.Location = new System.Drawing.Point(300, 117);
            this.tbxVeckodagNr.Name = "tbxVeckodagNr";
            this.tbxVeckodagNr.Size = new System.Drawing.Size(100, 20);
            this.tbxVeckodagNr.TabIndex = 3;
            this.tbxVeckodagNr.TextChanged += new System.EventHandler(this.tbxVeckodagNr_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxVeckodagNr);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.TextBox tbxVeckodagNr;
    }
}


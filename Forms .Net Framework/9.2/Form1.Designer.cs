namespace _9._2
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
            this.tbxUtdata = new System.Windows.Forms.TextBox();
            this.btnVisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxUtdata
            // 
            this.tbxUtdata.Location = new System.Drawing.Point(100, 159);
            this.tbxUtdata.Multiline = true;
            this.tbxUtdata.Name = "tbxUtdata";
            this.tbxUtdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxUtdata.Size = new System.Drawing.Size(624, 252);
            this.tbxUtdata.TabIndex = 0;
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(374, 75);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(75, 23);
            this.btnVisa.TabIndex = 1;
            this.btnVisa.Text = "VISA";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.tbxUtdata);
            this.Name = "Form1";
            this.Text = "sw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUtdata;
        private System.Windows.Forms.Button btnVisa;
    }
}


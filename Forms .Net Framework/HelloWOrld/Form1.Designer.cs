namespace HelloWOrld
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
            this.btnWake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWake
            // 
            this.btnWake.Location = new System.Drawing.Point(131, 64);
            this.btnWake.Name = "btnWake";
            this.btnWake.Size = new System.Drawing.Size(75, 23);
            this.btnWake.TabIndex = 0;
            this.btnWake.Text = "Vakna!";
            this.btnWake.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 861);
            this.Controls.Add(this.btnWake);
            this.Name = "Form1";
            this.Text = "Hello World";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWake;
    }
}


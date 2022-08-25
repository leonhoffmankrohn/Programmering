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
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(296, 129);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(706, 431);
            this.Controls.Add(this.btnColor);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWake1;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnColor;
    }
}


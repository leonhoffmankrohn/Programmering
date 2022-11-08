namespace Uppgift_9._2
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
            this.tbxFibonacciserien = new System.Windows.Forms.TextBox();
            this.lblFibonacci = new System.Windows.Forms.Label();
            this.lblTips = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxFibonacciserien
            // 
            this.tbxFibonacciserien.Location = new System.Drawing.Point(122, 47);
            this.tbxFibonacciserien.Multiline = true;
            this.tbxFibonacciserien.Name = "tbxFibonacciserien";
            this.tbxFibonacciserien.Size = new System.Drawing.Size(513, 307);
            this.tbxFibonacciserien.TabIndex = 0;
            this.tbxFibonacciserien.Click += new System.EventHandler(this.tbxFibonacciserien_Click);
            // 
            // lblFibonacci
            // 
            this.lblFibonacci.AutoSize = true;
            this.lblFibonacci.Location = new System.Drawing.Point(122, 28);
            this.lblFibonacci.Name = "lblFibonacci";
            this.lblFibonacci.Size = new System.Drawing.Size(84, 13);
            this.lblFibonacci.TabIndex = 1;
            this.lblFibonacci.Text = "Fibonacciserien:";
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.Location = new System.Drawing.Point(668, 428);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(120, 13);
            this.lblTips.TabIndex = 2;
            this.lblTips.Text = "Tips: tryck på textboxen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.lblFibonacci);
            this.Controls.Add(this.tbxFibonacciserien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFibonacciserien;
        private System.Windows.Forms.Label lblFibonacci;
        private System.Windows.Forms.Label lblTips;
    }
}


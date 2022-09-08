namespace Uppgift_5._4
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
            this.lblTotSekunder = new System.Windows.Forms.Label();
            this.tbxTotSekunder = new System.Windows.Forms.TextBox();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotSekunder
            // 
            this.lblTotSekunder.AutoSize = true;
            this.lblTotSekunder.Location = new System.Drawing.Point(270, 124);
            this.lblTotSekunder.Name = "lblTotSekunder";
            this.lblTotSekunder.Size = new System.Drawing.Size(77, 13);
            this.lblTotSekunder.TabIndex = 0;
            this.lblTotSekunder.Text = "Tid i sekunder:";
            // 
            // tbxTotSekunder
            // 
            this.tbxTotSekunder.Location = new System.Drawing.Point(368, 124);
            this.tbxTotSekunder.Name = "tbxTotSekunder";
            this.tbxTotSekunder.Size = new System.Drawing.Size(100, 20);
            this.tbxTotSekunder.TabIndex = 1;
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(311, 178);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(164, 13);
            this.lblSvar.TabIndex = 2;
            this.lblSvar.Text = "Timmar: -- Minuter: -- Sekunder: --";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(368, 262);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 3;
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
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.tbxTotSekunder);
            this.Controls.Add(this.lblTotSekunder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotSekunder;
        private System.Windows.Forms.TextBox tbxTotSekunder;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnKör;
    }
}


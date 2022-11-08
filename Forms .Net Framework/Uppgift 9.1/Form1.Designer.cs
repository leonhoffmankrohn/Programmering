namespace Uppgift_9._1
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
            this.lblStartantal = new System.Windows.Forms.Label();
            this.lblTid = new System.Windows.Forms.Label();
            this.lblX10 = new System.Windows.Forms.Label();
            this.tbxStartantal = new System.Windows.Forms.TextBox();
            this.tbxTid = new System.Windows.Forms.TextBox();
            this.btnBeräkna = new System.Windows.Forms.Button();
            this.lblSlutantal = new System.Windows.Forms.Label();
            this.tbxSlutantal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStartantal
            // 
            this.lblStartantal.AutoSize = true;
            this.lblStartantal.Location = new System.Drawing.Point(11, 15);
            this.lblStartantal.Name = "lblStartantal";
            this.lblStartantal.Size = new System.Drawing.Size(52, 13);
            this.lblStartantal.TabIndex = 0;
            this.lblStartantal.Text = "Startantal";
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Location = new System.Drawing.Point(11, 41);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(22, 13);
            this.lblTid.TabIndex = 1;
            this.lblTid.Text = "Tid";
            // 
            // lblX10
            // 
            this.lblX10.AutoSize = true;
            this.lblX10.Location = new System.Drawing.Point(225, 41);
            this.lblX10.Name = "lblX10";
            this.lblX10.Size = new System.Drawing.Size(61, 13);
            this.lblX10.TabIndex = 2;
            this.lblX10.Text = "x10 minuter";
            // 
            // tbxStartantal
            // 
            this.tbxStartantal.Location = new System.Drawing.Point(69, 12);
            this.tbxStartantal.Name = "tbxStartantal";
            this.tbxStartantal.Size = new System.Drawing.Size(277, 20);
            this.tbxStartantal.TabIndex = 3;
            // 
            // tbxTid
            // 
            this.tbxTid.Location = new System.Drawing.Point(52, 38);
            this.tbxTid.Name = "tbxTid";
            this.tbxTid.Size = new System.Drawing.Size(153, 20);
            this.tbxTid.TabIndex = 4;
            // 
            // btnBeräkna
            // 
            this.btnBeräkna.Location = new System.Drawing.Point(14, 64);
            this.btnBeräkna.Name = "btnBeräkna";
            this.btnBeräkna.Size = new System.Drawing.Size(332, 20);
            this.btnBeräkna.TabIndex = 5;
            this.btnBeräkna.Text = "Beräkna tillväxt";
            this.btnBeräkna.UseVisualStyleBackColor = true;
            this.btnBeräkna.Click += new System.EventHandler(this.btnBeräkna_Click);
            // 
            // lblSlutantal
            // 
            this.lblSlutantal.AutoSize = true;
            this.lblSlutantal.Location = new System.Drawing.Point(11, 90);
            this.lblSlutantal.Name = "lblSlutantal";
            this.lblSlutantal.Size = new System.Drawing.Size(48, 13);
            this.lblSlutantal.TabIndex = 6;
            this.lblSlutantal.Text = "Slutantal";
            // 
            // tbxSlutantal
            // 
            this.tbxSlutantal.Enabled = false;
            this.tbxSlutantal.Location = new System.Drawing.Point(65, 87);
            this.tbxSlutantal.Name = "tbxSlutantal";
            this.tbxSlutantal.Size = new System.Drawing.Size(280, 20);
            this.tbxSlutantal.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 157);
            this.Controls.Add(this.tbxSlutantal);
            this.Controls.Add(this.lblSlutantal);
            this.Controls.Add(this.btnBeräkna);
            this.Controls.Add(this.tbxTid);
            this.Controls.Add(this.tbxStartantal);
            this.Controls.Add(this.lblX10);
            this.Controls.Add(this.lblTid);
            this.Controls.Add(this.lblStartantal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartantal;
        private System.Windows.Forms.Label lblTid;
        private System.Windows.Forms.Label lblX10;
        private System.Windows.Forms.TextBox tbxStartantal;
        private System.Windows.Forms.TextBox tbxTid;
        private System.Windows.Forms.Button btnBeräkna;
        private System.Windows.Forms.Label lblSlutantal;
        private System.Windows.Forms.TextBox tbxSlutantal;
    }
}


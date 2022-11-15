namespace FörstaYatzy
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
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.pc3 = new System.Windows.Forms.PictureBox();
            this.pc4 = new System.Windows.Forms.PictureBox();
            this.pc5 = new System.Windows.Forms.PictureBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnKasta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).BeginInit();
            this.SuspendLayout();
            // 
            // pc1
            // 
            this.pc1.Image = global::FörstaYatzy.tärningsGrafik.d0;
            this.pc1.Location = new System.Drawing.Point(81, 47);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(50, 50);
            this.pc1.TabIndex = 0;
            this.pc1.TabStop = false;
            // 
            // pc2
            // 
            this.pc2.Image = global::FörstaYatzy.tärningsGrafik.d0;
            this.pc2.Location = new System.Drawing.Point(201, 47);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(50, 50);
            this.pc2.TabIndex = 1;
            this.pc2.TabStop = false;
            // 
            // pc3
            // 
            this.pc3.Image = global::FörstaYatzy.tärningsGrafik.d0;
            this.pc3.Location = new System.Drawing.Point(317, 47);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(50, 50);
            this.pc3.TabIndex = 2;
            this.pc3.TabStop = false;
            // 
            // pc4
            // 
            this.pc4.Image = global::FörstaYatzy.tärningsGrafik.d0;
            this.pc4.Location = new System.Drawing.Point(435, 47);
            this.pc4.Name = "pc4";
            this.pc4.Size = new System.Drawing.Size(50, 50);
            this.pc4.TabIndex = 3;
            this.pc4.TabStop = false;
            // 
            // pc5
            // 
            this.pc5.Image = global::FörstaYatzy.tärningsGrafik.d0;
            this.pc5.Location = new System.Drawing.Point(552, 47);
            this.pc5.Name = "pc5";
            this.pc5.Size = new System.Drawing.Size(50, 50);
            this.pc5.TabIndex = 4;
            this.pc5.TabStop = false;
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultat.Location = new System.Drawing.Point(267, 223);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(66, 15);
            this.lblResultat.TabIndex = 5;
            this.lblResultat.Text = "RESULTAT";
            // 
            // btnKasta
            // 
            this.btnKasta.Location = new System.Drawing.Point(267, 182);
            this.btnKasta.Name = "btnKasta";
            this.btnKasta.Size = new System.Drawing.Size(75, 23);
            this.btnKasta.TabIndex = 6;
            this.btnKasta.Text = "SLÅ";
            this.btnKasta.UseVisualStyleBackColor = true;
            this.btnKasta.Click += new System.EventHandler(this.btnKasta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKasta);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.pc5);
            this.Controls.Add(this.pc4);
            this.Controls.Add(this.pc3);
            this.Controls.Add(this.pc2);
            this.Controls.Add(this.pc1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.PictureBox pc3;
        private System.Windows.Forms.PictureBox pc4;
        private System.Windows.Forms.PictureBox pc5;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnKasta;
    }
}


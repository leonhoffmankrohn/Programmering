namespace StenSaxPåse
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
            this.gbxStenSaxPåse = new System.Windows.Forms.GroupBox();
            this.lblFörklaring = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatornsVal = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnSpela = new System.Windows.Forms.Button();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.gbxMinaResultat = new System.Windows.Forms.GroupBox();
            this.pbxSten = new System.Windows.Forms.PictureBox();
            this.pbxSax = new System.Windows.Forms.PictureBox();
            this.pbxPåse = new System.Windows.Forms.PictureBox();
            this.gbxStenSaxPåse.SuspendLayout();
            this.gbxMinaResultat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPåse)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxStenSaxPåse
            // 
            this.gbxStenSaxPåse.Controls.Add(this.lblResultat);
            this.gbxStenSaxPåse.Controls.Add(this.lblDatornsVal);
            this.gbxStenSaxPåse.Controls.Add(this.label1);
            this.gbxStenSaxPåse.Controls.Add(this.lblFörklaring);
            this.gbxStenSaxPåse.Controls.Add(this.pbxSten);
            this.gbxStenSaxPåse.Controls.Add(this.pbxSax);
            this.gbxStenSaxPåse.Controls.Add(this.pbxPåse);
            this.gbxStenSaxPåse.Enabled = false;
            this.gbxStenSaxPåse.Location = new System.Drawing.Point(12, 24);
            this.gbxStenSaxPåse.Name = "gbxStenSaxPåse";
            this.gbxStenSaxPåse.Size = new System.Drawing.Size(283, 212);
            this.gbxStenSaxPåse.TabIndex = 3;
            this.gbxStenSaxPåse.TabStop = false;
            this.gbxStenSaxPåse.Text = "Sten, sax eller påse";
            // 
            // lblFörklaring
            // 
            this.lblFörklaring.AutoSize = true;
            this.lblFörklaring.Location = new System.Drawing.Point(12, 46);
            this.lblFörklaring.Name = "lblFörklaring";
            this.lblFörklaring.Size = new System.Drawing.Size(247, 13);
            this.lblFörklaring.TabIndex = 3;
            this.lblFörklaring.Text = "Välj sten, sax eller påse genom att klicka på en bild";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datorn valde:";
            // 
            // lblDatornsVal
            // 
            this.lblDatornsVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornsVal.Location = new System.Drawing.Point(93, 138);
            this.lblDatornsVal.Name = "lblDatornsVal";
            this.lblDatornsVal.Size = new System.Drawing.Size(100, 23);
            this.lblDatornsVal.TabIndex = 5;
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(15, 173);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(244, 23);
            this.lblResultat.TabIndex = 6;
            // 
            // btnSpela
            // 
            this.btnSpela.Location = new System.Drawing.Point(324, 40);
            this.btnSpela.Name = "btnSpela";
            this.btnSpela.Size = new System.Drawing.Size(75, 23);
            this.btnSpela.TabIndex = 4;
            this.btnSpela.Text = "Spela";
            this.btnSpela.UseVisualStyleBackColor = true;
            this.btnSpela.Click += new System.EventHandler(this.btnSpela_Click);
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Enabled = false;
            this.tbxMinaResultat.Location = new System.Drawing.Point(6, 19);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMinaResultat.Size = new System.Drawing.Size(123, 99);
            this.tbxMinaResultat.TabIndex = 5;
            // 
            // gbxMinaResultat
            // 
            this.gbxMinaResultat.Controls.Add(this.tbxMinaResultat);
            this.gbxMinaResultat.Location = new System.Drawing.Point(324, 70);
            this.gbxMinaResultat.Name = "gbxMinaResultat";
            this.gbxMinaResultat.Size = new System.Drawing.Size(134, 125);
            this.gbxMinaResultat.TabIndex = 6;
            this.gbxMinaResultat.TabStop = false;
            this.gbxMinaResultat.Text = "Mina resultat";
            // 
            // pbxSten
            // 
            this.pbxSten.Image = global::StenSaxPåse.Properties.Resources.sten;
            this.pbxSten.Location = new System.Drawing.Point(15, 62);
            this.pbxSten.Name = "pbxSten";
            this.pbxSten.Size = new System.Drawing.Size(60, 60);
            this.pbxSten.TabIndex = 0;
            this.pbxSten.TabStop = false;
            this.pbxSten.Click += new System.EventHandler(this.pbxSten_Click);
            // 
            // pbxSax
            // 
            this.pbxSax.Image = global::StenSaxPåse.Properties.Resources.sax;
            this.pbxSax.Location = new System.Drawing.Point(110, 62);
            this.pbxSax.Name = "pbxSax";
            this.pbxSax.Size = new System.Drawing.Size(60, 60);
            this.pbxSax.TabIndex = 2;
            this.pbxSax.TabStop = false;
            this.pbxSax.Click += new System.EventHandler(this.pbxSax_Click);
            // 
            // pbxPåse
            // 
            this.pbxPåse.Image = global::StenSaxPåse.Properties.Resources.påse;
            this.pbxPåse.Location = new System.Drawing.Point(199, 62);
            this.pbxPåse.Name = "pbxPåse";
            this.pbxPåse.Size = new System.Drawing.Size(60, 60);
            this.pbxPåse.TabIndex = 1;
            this.pbxPåse.TabStop = false;
            this.pbxPåse.Click += new System.EventHandler(this.pbxPåse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 253);
            this.Controls.Add(this.gbxMinaResultat);
            this.Controls.Add(this.btnSpela);
            this.Controls.Add(this.gbxStenSaxPåse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxStenSaxPåse.ResumeLayout(false);
            this.gbxStenSaxPåse.PerformLayout();
            this.gbxMinaResultat.ResumeLayout(false);
            this.gbxMinaResultat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPåse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSten;
        private System.Windows.Forms.PictureBox pbxPåse;
        private System.Windows.Forms.PictureBox pbxSax;
        private System.Windows.Forms.GroupBox gbxStenSaxPåse;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblDatornsVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFörklaring;
        private System.Windows.Forms.Button btnSpela;
        private System.Windows.Forms.TextBox tbxMinaResultat;
        private System.Windows.Forms.GroupBox gbxMinaResultat;
    }
}


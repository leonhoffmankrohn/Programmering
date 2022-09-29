namespace GissaMittTal
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
            this.pbxBild = new System.Windows.Forms.PictureBox();
            this.gbxSpelet = new System.Windows.Forms.GroupBox();
            this.gbxSpeldata = new System.Windows.Forms.GroupBox();
            this.lbxStörstaTalet = new System.Windows.Forms.ListBox();
            this.lblStörstaTalet = new System.Windows.Forms.Label();
            this.lblMinaResultat = new System.Windows.Forms.Label();
            this.lblDatornsTal = new System.Windows.Forms.Label();
            this.lblGissa = new System.Windows.Forms.Label();
            this.lblDator = new System.Windows.Forms.Label();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.btnGissa = new System.Windows.Forms.Button();
            this.btnStartaSpelet = new System.Windows.Forms.Button();
            this.btnSpelaIgen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBild)).BeginInit();
            this.gbxSpelet.SuspendLayout();
            this.gbxSpeldata.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxBild
            // 
            this.pbxBild.BackgroundImage = global::GissaMittTal.Properties.Resources.gissaMittTal;
            this.pbxBild.Location = new System.Drawing.Point(12, 12);
            this.pbxBild.Name = "pbxBild";
            this.pbxBild.Size = new System.Drawing.Size(340, 40);
            this.pbxBild.TabIndex = 0;
            this.pbxBild.TabStop = false;
            // 
            // gbxSpelet
            // 
            this.gbxSpelet.Controls.Add(this.lblMinaResultat);
            this.gbxSpelet.Controls.Add(this.lblDatornsTal);
            this.gbxSpelet.Controls.Add(this.lblGissa);
            this.gbxSpelet.Controls.Add(this.btnSpelaIgen);
            this.gbxSpelet.Controls.Add(this.lblDator);
            this.gbxSpelet.Controls.Add(this.btnGissa);
            this.gbxSpelet.Controls.Add(this.tbxMinaResultat);
            this.gbxSpelet.Controls.Add(this.tbxGissa);
            this.gbxSpelet.Enabled = false;
            this.gbxSpelet.Location = new System.Drawing.Point(12, 140);
            this.gbxSpelet.Name = "gbxSpelet";
            this.gbxSpelet.Size = new System.Drawing.Size(340, 110);
            this.gbxSpelet.TabIndex = 1;
            this.gbxSpelet.TabStop = false;
            this.gbxSpelet.Text = "Spelet";
            // 
            // gbxSpeldata
            // 
            this.gbxSpeldata.Controls.Add(this.lbxStörstaTalet);
            this.gbxSpeldata.Controls.Add(this.lblStörstaTalet);
            this.gbxSpeldata.Location = new System.Drawing.Point(12, 65);
            this.gbxSpeldata.Name = "gbxSpeldata";
            this.gbxSpeldata.Size = new System.Drawing.Size(210, 70);
            this.gbxSpeldata.TabIndex = 2;
            this.gbxSpeldata.TabStop = false;
            this.gbxSpeldata.Text = "Speldata";
            // 
            // lbxStörstaTalet
            // 
            this.lbxStörstaTalet.FormattingEnabled = true;
            this.lbxStörstaTalet.Location = new System.Drawing.Point(80, 20);
            this.lbxStörstaTalet.Name = "lbxStörstaTalet";
            this.lbxStörstaTalet.Size = new System.Drawing.Size(90, 30);
            this.lbxStörstaTalet.TabIndex = 0;
            // 
            // lblStörstaTalet
            // 
            this.lblStörstaTalet.AutoSize = true;
            this.lblStörstaTalet.Location = new System.Drawing.Point(8, 20);
            this.lblStörstaTalet.Name = "lblStörstaTalet";
            this.lblStörstaTalet.Size = new System.Drawing.Size(66, 13);
            this.lblStörstaTalet.TabIndex = 3;
            this.lblStörstaTalet.Text = "Största talet:";
            // 
            // lblMinaResultat
            // 
            this.lblMinaResultat.AutoSize = true;
            this.lblMinaResultat.Location = new System.Drawing.Point(241, 16);
            this.lblMinaResultat.Name = "lblMinaResultat";
            this.lblMinaResultat.Size = new System.Drawing.Size(67, 13);
            this.lblMinaResultat.TabIndex = 5;
            this.lblMinaResultat.Text = "Mina resultat";
            // 
            // lblDatornsTal
            // 
            this.lblDatornsTal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornsTal.Location = new System.Drawing.Point(80, 37);
            this.lblDatornsTal.Name = "lblDatornsTal";
            this.lblDatornsTal.Size = new System.Drawing.Size(72, 23);
            this.lblDatornsTal.TabIndex = 6;
            this.lblDatornsTal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGissa
            // 
            this.lblGissa.AutoSize = true;
            this.lblGissa.Location = new System.Drawing.Point(9, 74);
            this.lblGissa.Name = "lblGissa";
            this.lblGissa.Size = new System.Drawing.Size(65, 13);
            this.lblGissa.TabIndex = 7;
            this.lblGissa.Text = "Gissa ett tal:";
            // 
            // lblDator
            // 
            this.lblDator.AutoSize = true;
            this.lblDator.Location = new System.Drawing.Point(13, 42);
            this.lblDator.Name = "lblDator";
            this.lblDator.Size = new System.Drawing.Size(61, 13);
            this.lblDator.TabIndex = 8;
            this.lblDator.Text = "Datorns tal:";
            // 
            // tbxGissa
            // 
            this.tbxGissa.Location = new System.Drawing.Point(80, 71);
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(100, 20);
            this.tbxGissa.TabIndex = 0;
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Enabled = false;
            this.tbxMinaResultat.Location = new System.Drawing.Point(244, 31);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMinaResultat.Size = new System.Drawing.Size(90, 60);
            this.tbxMinaResultat.TabIndex = 1;
            // 
            // btnGissa
            // 
            this.btnGissa.Location = new System.Drawing.Point(186, 68);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(52, 23);
            this.btnGissa.TabIndex = 2;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = true;
            this.btnGissa.Click += new System.EventHandler(this.btnGissa_Click);
            // 
            // btnStartaSpelet
            // 
            this.btnStartaSpelet.Location = new System.Drawing.Point(256, 92);
            this.btnStartaSpelet.Name = "btnStartaSpelet";
            this.btnStartaSpelet.Size = new System.Drawing.Size(75, 23);
            this.btnStartaSpelet.TabIndex = 3;
            this.btnStartaSpelet.Text = "Starta spelet";
            this.btnStartaSpelet.UseVisualStyleBackColor = true;
            this.btnStartaSpelet.Click += new System.EventHandler(this.btnStartaSpelet_Click);
            // 
            // btnSpelaIgen
            // 
            this.btnSpelaIgen.Enabled = false;
            this.btnSpelaIgen.Location = new System.Drawing.Point(163, 37);
            this.btnSpelaIgen.Name = "btnSpelaIgen";
            this.btnSpelaIgen.Size = new System.Drawing.Size(75, 23);
            this.btnSpelaIgen.TabIndex = 4;
            this.btnSpelaIgen.Text = "Spela igen";
            this.btnSpelaIgen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.gbxSpeldata);
            this.Controls.Add(this.btnStartaSpelet);
            this.Controls.Add(this.gbxSpelet);
            this.Controls.Add(this.pbxBild);
            this.Name = "Form1";
            this.Text = "Exempel";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBild)).EndInit();
            this.gbxSpelet.ResumeLayout(false);
            this.gbxSpelet.PerformLayout();
            this.gbxSpeldata.ResumeLayout(false);
            this.gbxSpeldata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBild;
        private System.Windows.Forms.GroupBox gbxSpelet;
        private System.Windows.Forms.GroupBox gbxSpeldata;
        private System.Windows.Forms.ListBox lbxStörstaTalet;
        private System.Windows.Forms.Label lblMinaResultat;
        private System.Windows.Forms.Label lblDatornsTal;
        private System.Windows.Forms.Label lblGissa;
        private System.Windows.Forms.Button btnSpelaIgen;
        private System.Windows.Forms.Label lblDator;
        private System.Windows.Forms.Button btnGissa;
        private System.Windows.Forms.TextBox tbxMinaResultat;
        private System.Windows.Forms.TextBox tbxGissa;
        private System.Windows.Forms.Label lblStörstaTalet;
        private System.Windows.Forms.Button btnStartaSpelet;
    }
}


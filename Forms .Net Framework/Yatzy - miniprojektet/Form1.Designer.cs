namespace Yatzy___miniprojektet
{
    partial class Yatzy
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
            this.btnSlag = new System.Windows.Forms.Button();
            this.pc4 = new System.Windows.Forms.PictureBox();
            this.pc5 = new System.Windows.Forms.PictureBox();
            this.pc3 = new System.Windows.Forms.PictureBox();
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.lbxAlternativ = new System.Windows.Forms.ListBox();
            this.lbxSumma = new System.Windows.Forms.ListBox();
            this.gbxResultat = new System.Windows.Forms.GroupBox();
            this.btnStryk = new System.Windows.Forms.Button();
            this.btnVälj = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            this.gbxResultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSlag
            // 
            this.btnSlag.Location = new System.Drawing.Point(12, 321);
            this.btnSlag.Name = "btnSlag";
            this.btnSlag.Size = new System.Drawing.Size(50, 50);
            this.btnSlag.TabIndex = 6;
            this.btnSlag.Text = "Slå";
            this.btnSlag.UseVisualStyleBackColor = true;
            this.btnSlag.Click += new System.EventHandler(this.btnSlag_Click);
            // 
            // pc4
            // 
            this.pc4.Location = new System.Drawing.Point(12, 209);
            this.pc4.Name = "pc4";
            this.pc4.Size = new System.Drawing.Size(50, 50);
            this.pc4.TabIndex = 4;
            this.pc4.TabStop = false;
            this.pc4.Click += new System.EventHandler(this.pc4_Click);
            // 
            // pc5
            // 
            this.pc5.Location = new System.Drawing.Point(12, 265);
            this.pc5.Name = "pc5";
            this.pc5.Size = new System.Drawing.Size(50, 50);
            this.pc5.TabIndex = 3;
            this.pc5.TabStop = false;
            this.pc5.Click += new System.EventHandler(this.pc5_Click);
            // 
            // pc3
            // 
            this.pc3.Location = new System.Drawing.Point(12, 153);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(50, 50);
            this.pc3.TabIndex = 2;
            this.pc3.TabStop = false;
            this.pc3.Click += new System.EventHandler(this.pc3_Click);
            // 
            // pc2
            // 
            this.pc2.Location = new System.Drawing.Point(12, 97);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(50, 50);
            this.pc2.TabIndex = 1;
            this.pc2.TabStop = false;
            this.pc2.Click += new System.EventHandler(this.pc2_Click);
            // 
            // pc1
            // 
            this.pc1.Location = new System.Drawing.Point(12, 41);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(50, 50);
            this.pc1.TabIndex = 0;
            this.pc1.TabStop = false;
            this.pc1.Click += new System.EventHandler(this.pc1_Click);
            // 
            // lbxAlternativ
            // 
            this.lbxAlternativ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAlternativ.FormattingEnabled = true;
            this.lbxAlternativ.ItemHeight = 20;
            this.lbxAlternativ.Items.AddRange(new object[] {
            "Ettor:",
            "Tvåor:",
            "Treor:",
            "Fyror:",
            "Femor:",
            "Sexor:",
            "Bonus:",
            "Par:",
            "Två par:",
            "Triss:",
            "Fyrtal:",
            "Kåk:",
            "Liten stege:",
            "Stor stege:",
            "Chans:",
            "Yatzy:"});
            this.lbxAlternativ.Location = new System.Drawing.Point(6, 35);
            this.lbxAlternativ.Name = "lbxAlternativ";
            this.lbxAlternativ.Size = new System.Drawing.Size(100, 324);
            this.lbxAlternativ.TabIndex = 8;
            // 
            // lbxSumma
            // 
            this.lbxSumma.Enabled = false;
            this.lbxSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSumma.FormattingEnabled = true;
            this.lbxSumma.ItemHeight = 20;
            this.lbxSumma.Items.AddRange(new object[] {
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0",
            "0"});
            this.lbxSumma.Location = new System.Drawing.Point(105, 35);
            this.lbxSumma.Name = "lbxSumma";
            this.lbxSumma.Size = new System.Drawing.Size(38, 324);
            this.lbxSumma.TabIndex = 9;
            // 
            // gbxResultat
            // 
            this.gbxResultat.Controls.Add(this.btnStryk);
            this.gbxResultat.Controls.Add(this.btnVälj);
            this.gbxResultat.Controls.Add(this.lbxAlternativ);
            this.gbxResultat.Controls.Add(this.lbxSumma);
            this.gbxResultat.Enabled = false;
            this.gbxResultat.Location = new System.Drawing.Point(68, 12);
            this.gbxResultat.Name = "gbxResultat";
            this.gbxResultat.Size = new System.Drawing.Size(232, 371);
            this.gbxResultat.TabIndex = 10;
            this.gbxResultat.TabStop = false;
            this.gbxResultat.Text = "Resultat";
            // 
            // btnStryk
            // 
            this.btnStryk.Location = new System.Drawing.Point(149, 253);
            this.btnStryk.Name = "btnStryk";
            this.btnStryk.Size = new System.Drawing.Size(63, 50);
            this.btnStryk.TabIndex = 12;
            this.btnStryk.Text = "Stryk";
            this.btnStryk.UseVisualStyleBackColor = true;
            // 
            // btnVälj
            // 
            this.btnVälj.Location = new System.Drawing.Point(149, 309);
            this.btnVälj.Name = "btnVälj";
            this.btnVälj.Size = new System.Drawing.Size(63, 50);
            this.btnVälj.TabIndex = 11;
            this.btnVälj.Text = "Välj";
            this.btnVälj.UseVisualStyleBackColor = true;
            this.btnVälj.Click += new System.EventHandler(this.btnVälj_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(37, 26);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(42, 13);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "YATZY";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(149, 309);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(63, 50);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "Välj";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Ettor:",
            "Tvåor:",
            "Treor:",
            "Fyror:",
            "Femor:",
            "Sexor:",
            "Bonus:",
            "Par:",
            "Två par:",
            "Triss:",
            "Fyrtal:",
            "Kåk:",
            "Liten stege:",
            "Stor stege:",
            "Chans:",
            "Yatzy:"});
            this.listBox1.Location = new System.Drawing.Point(6, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 324);
            this.listBox1.TabIndex = 8;
            // 
            // Yatzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(319, 400);
            this.Controls.Add(this.gbxResultat);
            this.Controls.Add(this.btnSlag);
            this.Controls.Add(this.pc4);
            this.Controls.Add(this.pc5);
            this.Controls.Add(this.pc3);
            this.Controls.Add(this.pc2);
            this.Controls.Add(this.pc1);
            this.Name = "Yatzy";
            this.Text = "YATZY";
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            this.gbxResultat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.PictureBox pc3;
        private System.Windows.Forms.PictureBox pc5;
        private System.Windows.Forms.PictureBox pc4;
        private System.Windows.Forms.Button btnSlag;
        private System.Windows.Forms.ListBox lbxAlternativ;
        private System.Windows.Forms.ListBox lbxSumma;
        private System.Windows.Forms.GroupBox gbxResultat;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnVälj;
        private System.Windows.Forms.Button btnStryk;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox listBox1;
    }
}


namespace TredjeYatzy
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
            this.pc5 = new System.Windows.Forms.PictureBox();
            this.pc4 = new System.Windows.Forms.PictureBox();
            this.pc3 = new System.Windows.Forms.PictureBox();
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.btnSlå = new System.Windows.Forms.Button();
            this.lbxVälj = new System.Windows.Forms.ListBox();
            this.lbxMöjligRes = new System.Windows.Forms.ListBox();
            this.lbxValdRes = new System.Windows.Forms.ListBox();
            this.gbxResultat = new System.Windows.Forms.GroupBox();
            this.lblOmgångar = new System.Windows.Forms.Label();
            this.btnVälj = new System.Windows.Forms.Button();
            this.prbarKastkvar = new System.Windows.Forms.ProgressBar();
            this.lblTotala = new System.Windows.Forms.Label();
            this.btnStäng = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lbxAndraFörsök = new System.Windows.Forms.ListBox();
            this.tabAllt = new System.Windows.Forms.TabControl();
            this.tabPYatzy = new System.Windows.Forms.TabPage();
            this.tabPResultat = new System.Windows.Forms.TabPage();
            this.lblVälj = new System.Windows.Forms.Label();
            this.lblPoäng = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            this.gbxResultat.SuspendLayout();
            this.tabAllt.SuspendLayout();
            this.tabPYatzy.SuspendLayout();
            this.tabPResultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pc1
            // 
            this.pc1.Image = global::TredjeYatzy.Tärningsgrafik.d0;
            this.pc1.Location = new System.Drawing.Point(33, 243);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(50, 50);
            this.pc1.TabIndex = 0;
            this.pc1.TabStop = false;
            this.pc1.Click += new System.EventHandler(this.pc1_Click);
            // 
            // pc5
            // 
            this.pc5.Image = global::TredjeYatzy.Tärningsgrafik.d0;
            this.pc5.Location = new System.Drawing.Point(33, 19);
            this.pc5.Name = "pc5";
            this.pc5.Size = new System.Drawing.Size(50, 50);
            this.pc5.TabIndex = 1;
            this.pc5.TabStop = false;
            this.pc5.Click += new System.EventHandler(this.pc5_Click);
            // 
            // pc4
            // 
            this.pc4.Image = global::TredjeYatzy.Tärningsgrafik.d0;
            this.pc4.Location = new System.Drawing.Point(33, 75);
            this.pc4.Name = "pc4";
            this.pc4.Size = new System.Drawing.Size(50, 50);
            this.pc4.TabIndex = 2;
            this.pc4.TabStop = false;
            this.pc4.Click += new System.EventHandler(this.pc4_Click);
            // 
            // pc3
            // 
            this.pc3.Image = global::TredjeYatzy.Tärningsgrafik.d0;
            this.pc3.Location = new System.Drawing.Point(33, 131);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(50, 50);
            this.pc3.TabIndex = 3;
            this.pc3.TabStop = false;
            this.pc3.Click += new System.EventHandler(this.pc3_Click);
            // 
            // pc2
            // 
            this.pc2.Image = global::TredjeYatzy.Tärningsgrafik.d0;
            this.pc2.Location = new System.Drawing.Point(33, 187);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(50, 50);
            this.pc2.TabIndex = 4;
            this.pc2.TabStop = false;
            this.pc2.Click += new System.EventHandler(this.pc2_Click);
            // 
            // btnSlå
            // 
            this.btnSlå.Location = new System.Drawing.Point(8, 313);
            this.btnSlå.Name = "btnSlå";
            this.btnSlå.Size = new System.Drawing.Size(75, 44);
            this.btnSlå.TabIndex = 5;
            this.btnSlå.Text = "SLÅ";
            this.btnSlå.UseVisualStyleBackColor = true;
            this.btnSlå.Click += new System.EventHandler(this.btnSlå_Click);
            // 
            // lbxVälj
            // 
            this.lbxVälj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxVälj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxVälj.FormattingEnabled = true;
            this.lbxVälj.ItemHeight = 25;
            this.lbxVälj.Items.AddRange(new object[] {
            "Ettor:",
            "Tvåor:",
            "Treor:",
            "Fyror:",
            "Femor:",
            "Sexor:",
            "Par:",
            "Två par:",
            "Triss:",
            "Kåk:",
            "Liten stege:",
            "Stor stege:",
            "Fyrtal:",
            "Yatzy:"});
            this.lbxVälj.Location = new System.Drawing.Point(3, 16);
            this.lbxVälj.Name = "lbxVälj";
            this.lbxVälj.Size = new System.Drawing.Size(220, 372);
            this.lbxVälj.TabIndex = 6;
            // 
            // lbxMöjligRes
            // 
            this.lbxMöjligRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMöjligRes.FormattingEnabled = true;
            this.lbxMöjligRes.ItemHeight = 25;
            this.lbxMöjligRes.Items.AddRange(new object[] {
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
            this.lbxMöjligRes.Location = new System.Drawing.Point(123, 16);
            this.lbxMöjligRes.Name = "lbxMöjligRes";
            this.lbxMöjligRes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxMöjligRes.Size = new System.Drawing.Size(41, 354);
            this.lbxMöjligRes.TabIndex = 7;
            // 
            // lbxValdRes
            // 
            this.lbxValdRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxValdRes.FormattingEnabled = true;
            this.lbxValdRes.ItemHeight = 25;
            this.lbxValdRes.Items.AddRange(new object[] {
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
            this.lbxValdRes.Location = new System.Drawing.Point(170, 16);
            this.lbxValdRes.Name = "lbxValdRes";
            this.lbxValdRes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxValdRes.Size = new System.Drawing.Size(41, 354);
            this.lbxValdRes.TabIndex = 8;
            // 
            // gbxResultat
            // 
            this.gbxResultat.Controls.Add(this.lblPoäng);
            this.gbxResultat.Controls.Add(this.lblVälj);
            this.gbxResultat.Controls.Add(this.lblOmgångar);
            this.gbxResultat.Controls.Add(this.lbxValdRes);
            this.gbxResultat.Controls.Add(this.lbxMöjligRes);
            this.gbxResultat.Controls.Add(this.lbxVälj);
            this.gbxResultat.Enabled = false;
            this.gbxResultat.Location = new System.Drawing.Point(89, 19);
            this.gbxResultat.Name = "gbxResultat";
            this.gbxResultat.Size = new System.Drawing.Size(226, 391);
            this.gbxResultat.TabIndex = 9;
            this.gbxResultat.TabStop = false;
            this.gbxResultat.Text = "Resultaten";
            // 
            // lblOmgångar
            // 
            this.lblOmgångar.Location = new System.Drawing.Point(37, 373);
            this.lblOmgångar.Name = "lblOmgångar";
            this.lblOmgångar.Size = new System.Drawing.Size(103, 15);
            this.lblOmgångar.TabIndex = 16;
            this.lblOmgångar.Text = "Omgångar kvar: 14";
            // 
            // btnVälj
            // 
            this.btnVälj.Enabled = false;
            this.btnVälj.Location = new System.Drawing.Point(8, 363);
            this.btnVälj.Name = "btnVälj";
            this.btnVälj.Size = new System.Drawing.Size(75, 44);
            this.btnVälj.TabIndex = 10;
            this.btnVälj.Text = "Välj/Kasta igen";
            this.btnVälj.UseVisualStyleBackColor = true;
            this.btnVälj.Click += new System.EventHandler(this.btnVälj_Click);
            // 
            // prbarKastkvar
            // 
            this.prbarKastkvar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.prbarKastkvar.ForeColor = System.Drawing.Color.Lime;
            this.prbarKastkvar.Location = new System.Drawing.Point(8, 347);
            this.prbarKastkvar.Maximum = 3;
            this.prbarKastkvar.Name = "prbarKastkvar";
            this.prbarKastkvar.Size = new System.Drawing.Size(75, 10);
            this.prbarKastkvar.Step = -1;
            this.prbarKastkvar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbarKastkvar.TabIndex = 11;
            this.prbarKastkvar.Value = 3;
            // 
            // lblTotala
            // 
            this.lblTotala.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTotala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotala.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotala.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotala.Location = new System.Drawing.Point(3, 27);
            this.lblTotala.Name = "lblTotala";
            this.lblTotala.Size = new System.Drawing.Size(247, 354);
            this.lblTotala.TabIndex = 9;
            this.lblTotala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStäng
            // 
            this.btnStäng.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStäng.Location = new System.Drawing.Point(3, 381);
            this.btnStäng.Name = "btnStäng";
            this.btnStäng.Size = new System.Drawing.Size(320, 30);
            this.btnStäng.TabIndex = 13;
            this.btnStäng.Text = "Lämna spelet";
            this.btnStäng.UseVisualStyleBackColor = true;
            this.btnStäng.Click += new System.EventHandler(this.btnStäng_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestart.Location = new System.Drawing.Point(3, 3);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(320, 24);
            this.btnRestart.TabIndex = 14;
            this.btnRestart.Text = "Starta om spel!";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lbxAndraFörsök
            // 
            this.lbxAndraFörsök.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbxAndraFörsök.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAndraFörsök.FormattingEnabled = true;
            this.lbxAndraFörsök.ItemHeight = 20;
            this.lbxAndraFörsök.Location = new System.Drawing.Point(250, 27);
            this.lbxAndraFörsök.Name = "lbxAndraFörsök";
            this.lbxAndraFörsök.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxAndraFörsök.Size = new System.Drawing.Size(73, 354);
            this.lbxAndraFörsök.TabIndex = 15;
            // 
            // tabAllt
            // 
            this.tabAllt.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabAllt.Controls.Add(this.tabPYatzy);
            this.tabAllt.Controls.Add(this.tabPResultat);
            this.tabAllt.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabAllt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAllt.Location = new System.Drawing.Point(0, 0);
            this.tabAllt.Multiline = true;
            this.tabAllt.Name = "tabAllt";
            this.tabAllt.SelectedIndex = 0;
            this.tabAllt.Size = new System.Drawing.Size(334, 443);
            this.tabAllt.TabIndex = 16;
            this.tabAllt.TabStop = false;
            this.tabAllt.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabAllt_Selecting);
            // 
            // tabPYatzy
            // 
            this.tabPYatzy.BackColor = System.Drawing.SystemColors.Control;
            this.tabPYatzy.Controls.Add(this.gbxResultat);
            this.tabPYatzy.Controls.Add(this.btnVälj);
            this.tabPYatzy.Controls.Add(this.prbarKastkvar);
            this.tabPYatzy.Controls.Add(this.pc4);
            this.tabPYatzy.Controls.Add(this.pc2);
            this.tabPYatzy.Controls.Add(this.pc5);
            this.tabPYatzy.Controls.Add(this.pc1);
            this.tabPYatzy.Controls.Add(this.pc3);
            this.tabPYatzy.Controls.Add(this.btnSlå);
            this.tabPYatzy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPYatzy.Location = new System.Drawing.Point(4, 25);
            this.tabPYatzy.Name = "tabPYatzy";
            this.tabPYatzy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPYatzy.Size = new System.Drawing.Size(326, 414);
            this.tabPYatzy.TabIndex = 0;
            this.tabPYatzy.Text = "YATZY";
            // 
            // tabPResultat
            // 
            this.tabPResultat.BackColor = System.Drawing.SystemColors.Control;
            this.tabPResultat.Controls.Add(this.lblTotala);
            this.tabPResultat.Controls.Add(this.lbxAndraFörsök);
            this.tabPResultat.Controls.Add(this.btnRestart);
            this.tabPResultat.Controls.Add(this.btnStäng);
            this.tabPResultat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPResultat.Location = new System.Drawing.Point(4, 25);
            this.tabPResultat.Name = "tabPResultat";
            this.tabPResultat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPResultat.Size = new System.Drawing.Size(326, 414);
            this.tabPResultat.TabIndex = 1;
            this.tabPResultat.Text = "RESULTAT";
            // 
            // lblVälj
            // 
            this.lblVälj.AutoSize = true;
            this.lblVälj.Location = new System.Drawing.Point(129, 0);
            this.lblVälj.Name = "lblVälj";
            this.lblVälj.Size = new System.Drawing.Size(24, 13);
            this.lblVälj.TabIndex = 17;
            this.lblVälj.Text = "Välj";
            // 
            // lblPoäng
            // 
            this.lblPoäng.AutoSize = true;
            this.lblPoäng.Location = new System.Drawing.Point(173, 0);
            this.lblPoäng.Name = "lblPoäng";
            this.lblPoäng.Size = new System.Drawing.Size(38, 13);
            this.lblPoäng.TabIndex = 18;
            this.lblPoäng.Text = "Poäng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 443);
            this.Controls.Add(this.tabAllt);
            this.Name = "Form1";
            this.Text = "visual";
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            this.gbxResultat.ResumeLayout(false);
            this.gbxResultat.PerformLayout();
            this.tabAllt.ResumeLayout(false);
            this.tabPYatzy.ResumeLayout(false);
            this.tabPResultat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.PictureBox pc5;
        private System.Windows.Forms.PictureBox pc4;
        private System.Windows.Forms.PictureBox pc3;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.Button btnSlå;
        private System.Windows.Forms.ListBox lbxVälj;
        private System.Windows.Forms.ListBox lbxMöjligRes;
        private System.Windows.Forms.ListBox lbxValdRes;
        private System.Windows.Forms.GroupBox gbxResultat;
        private System.Windows.Forms.Button btnVälj;
        private System.Windows.Forms.ProgressBar prbarKastkvar;
        private System.Windows.Forms.Label lblTotala;
        private System.Windows.Forms.Button btnStäng;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ListBox lbxAndraFörsök;
        private System.Windows.Forms.Label lblOmgångar;
        private System.Windows.Forms.TabControl tabAllt;
        private System.Windows.Forms.TabPage tabPYatzy;
        private System.Windows.Forms.TabPage tabPResultat;
        private System.Windows.Forms.Label lblPoäng;
        private System.Windows.Forms.Label lblVälj;
    }
}


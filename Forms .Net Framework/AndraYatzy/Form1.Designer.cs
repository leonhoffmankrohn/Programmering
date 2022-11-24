namespace AndraYatzy
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
            this.btnVälj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            this.gbxResultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pc1
            // 
            this.pc1.Image = global::AndraYatzy.Tärningsgrafik.d0;
            this.pc1.Location = new System.Drawing.Point(37, 236);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(50, 50);
            this.pc1.TabIndex = 0;
            this.pc1.TabStop = false;
            this.pc1.Click += new System.EventHandler(this.pc1_Click);
            // 
            // pc5
            // 
            this.pc5.Image = global::AndraYatzy.Tärningsgrafik.d0;
            this.pc5.Location = new System.Drawing.Point(37, 12);
            this.pc5.Name = "pc5";
            this.pc5.Size = new System.Drawing.Size(50, 50);
            this.pc5.TabIndex = 1;
            this.pc5.TabStop = false;
            this.pc5.Click += new System.EventHandler(this.pc5_Click);
            // 
            // pc4
            // 
            this.pc4.Image = global::AndraYatzy.Tärningsgrafik.d0;
            this.pc4.Location = new System.Drawing.Point(37, 68);
            this.pc4.Name = "pc4";
            this.pc4.Size = new System.Drawing.Size(50, 50);
            this.pc4.TabIndex = 2;
            this.pc4.TabStop = false;
            this.pc4.Click += new System.EventHandler(this.pc4_Click);
            // 
            // pc3
            // 
            this.pc3.Image = global::AndraYatzy.Tärningsgrafik.d0;
            this.pc3.Location = new System.Drawing.Point(37, 124);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(50, 50);
            this.pc3.TabIndex = 3;
            this.pc3.TabStop = false;
            this.pc3.Click += new System.EventHandler(this.pc3_Click);
            // 
            // pc2
            // 
            this.pc2.Image = global::AndraYatzy.Tärningsgrafik.d0;
            this.pc2.Location = new System.Drawing.Point(37, 180);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(50, 50);
            this.pc2.TabIndex = 4;
            this.pc2.TabStop = false;
            this.pc2.Click += new System.EventHandler(this.pc2_Click);
            // 
            // btnSlå
            // 
            this.btnSlå.Location = new System.Drawing.Point(12, 306);
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
            this.gbxResultat.Controls.Add(this.lbxValdRes);
            this.gbxResultat.Controls.Add(this.lbxMöjligRes);
            this.gbxResultat.Controls.Add(this.lbxVälj);
            this.gbxResultat.Enabled = false;
            this.gbxResultat.Location = new System.Drawing.Point(93, 12);
            this.gbxResultat.Name = "gbxResultat";
            this.gbxResultat.Size = new System.Drawing.Size(226, 391);
            this.gbxResultat.TabIndex = 9;
            this.gbxResultat.TabStop = false;
            this.gbxResultat.Text = "Resultaten";
            // 
            // btnVälj
            // 
            this.btnVälj.Enabled = false;
            this.btnVälj.Location = new System.Drawing.Point(12, 356);
            this.btnVälj.Name = "btnVälj";
            this.btnVälj.Size = new System.Drawing.Size(75, 44);
            this.btnVälj.TabIndex = 10;
            this.btnVälj.Text = "Välj/Kasta igen";
            this.btnVälj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 415);
            this.Controls.Add(this.btnVälj);
            this.Controls.Add(this.gbxResultat);
            this.Controls.Add(this.btnSlå);
            this.Controls.Add(this.pc2);
            this.Controls.Add(this.pc3);
            this.Controls.Add(this.pc4);
            this.Controls.Add(this.pc5);
            this.Controls.Add(this.pc1);
            this.Name = "Form1";
            this.Text = "Andra yatzy";
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            this.gbxResultat.ResumeLayout(false);
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
    }
}


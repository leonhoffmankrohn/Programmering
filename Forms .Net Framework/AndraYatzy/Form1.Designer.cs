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
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            this.SuspendLayout();
            // 
            // pc1
            // 
            this.pc1.Image = global::AndraYatzy.Tärningsgrafik.d0;
            this.pc1.Location = new System.Drawing.Point(142, 117);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(50, 50);
            this.pc1.TabIndex = 0;
            this.pc1.TabStop = false;
            this.pc1.Click += new System.EventHandler(this.pc1_Click);
            // 
            // pc5
            // 
            this.pc5.Image = global::AndraYatzy.Tärningsgrafik.d0;
            this.pc5.Location = new System.Drawing.Point(366, 117);
            this.pc5.Name = "pc5";
            this.pc5.Size = new System.Drawing.Size(50, 50);
            this.pc5.TabIndex = 1;
            this.pc5.TabStop = false;
            this.pc5.Click += new System.EventHandler(this.pc5_Click);
            // 
            // pc4
            // 
            this.pc4.Image = global::AndraYatzy.Tärningsgrafik.d0;
            this.pc4.Location = new System.Drawing.Point(310, 117);
            this.pc4.Name = "pc4";
            this.pc4.Size = new System.Drawing.Size(50, 50);
            this.pc4.TabIndex = 2;
            this.pc4.TabStop = false;
            this.pc4.Click += new System.EventHandler(this.pc4_Click);
            // 
            // pc3
            // 
            this.pc3.Image = global::AndraYatzy.Tärningsgrafik.d0;
            this.pc3.Location = new System.Drawing.Point(254, 117);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(50, 50);
            this.pc3.TabIndex = 3;
            this.pc3.TabStop = false;
            this.pc3.Click += new System.EventHandler(this.pc3_Click);
            // 
            // pc2
            // 
            this.pc2.Image = global::AndraYatzy.Tärningsgrafik.d0;
            this.pc2.Location = new System.Drawing.Point(198, 117);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(50, 50);
            this.pc2.TabIndex = 4;
            this.pc2.TabStop = false;
            this.pc2.Click += new System.EventHandler(this.pc2_Click);
            // 
            // btnSlå
            // 
            this.btnSlå.Location = new System.Drawing.Point(60, 243);
            this.btnSlå.Name = "btnSlå";
            this.btnSlå.Size = new System.Drawing.Size(75, 65);
            this.btnSlå.TabIndex = 5;
            this.btnSlå.Text = "SLÅ";
            this.btnSlå.UseVisualStyleBackColor = true;
            this.btnSlå.Click += new System.EventHandler(this.btnSlå_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.PictureBox pc5;
        private System.Windows.Forms.PictureBox pc4;
        private System.Windows.Forms.PictureBox pc3;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.Button btnSlå;
    }
}


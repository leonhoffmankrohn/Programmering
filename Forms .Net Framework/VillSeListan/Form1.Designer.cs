namespace VillSeListan
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
            this.tbxSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.tbxVisa = new System.Windows.Forms.TextBox();
            this.btnVisa = new System.Windows.Forms.Button();
            this.lblVisa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxSerie
            // 
            this.tbxSerie.Location = new System.Drawing.Point(22, 57);
            this.tbxSerie.Name = "tbxSerie";
            this.tbxSerie.Size = new System.Drawing.Size(155, 29);
            this.tbxSerie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vill se:";
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(22, 108);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(99, 42);
            this.btnLäggTill.TabIndex = 3;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // tbxVisa
            // 
            this.tbxVisa.Location = new System.Drawing.Point(26, 196);
            this.tbxVisa.Name = "tbxVisa";
            this.tbxVisa.Size = new System.Drawing.Size(46, 29);
            this.tbxVisa.TabIndex = 4;
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(22, 241);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(99, 42);
            this.btnVisa.TabIndex = 5;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // lblVisa
            // 
            this.lblVisa.BackColor = System.Drawing.Color.Salmon;
            this.lblVisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVisa.Location = new System.Drawing.Point(156, 119);
            this.lblVisa.Name = "lblVisa";
            this.lblVisa.Size = new System.Drawing.Size(214, 106);
            this.lblVisa.TabIndex = 6;
            this.lblVisa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 385);
            this.Controls.Add(this.lblVisa);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.tbxVisa);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSerie);
            this.Name = "Form1";
            this.Text = "Vill-Se-Listan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.TextBox tbxVisa;
        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.Label lblVisa;
    }
}


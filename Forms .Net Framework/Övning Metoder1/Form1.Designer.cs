namespace Övning_Metoder1
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
            this.lblTal1 = new System.Windows.Forms.Label();
            this.lblTal2 = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.tbxTal1 = new System.Windows.Forms.TextBox();
            this.tbxTal2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTal1
            // 
            this.lblTal1.AutoSize = true;
            this.lblTal1.Location = new System.Drawing.Point(80, 55);
            this.lblTal1.Name = "lblTal1";
            this.lblTal1.Size = new System.Drawing.Size(34, 13);
            this.lblTal1.TabIndex = 0;
            this.lblTal1.Text = "Tal 1:";
            // 
            // lblTal2
            // 
            this.lblTal2.AutoSize = true;
            this.lblTal2.Location = new System.Drawing.Point(242, 55);
            this.lblTal2.Name = "lblTal2";
            this.lblTal2.Size = new System.Drawing.Size(31, 13);
            this.lblTal2.TabIndex = 1;
            this.lblTal2.Text = "Tal 2";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(80, 169);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(49, 13);
            this.lblResultat.TabIndex = 2;
            this.lblResultat.Text = "Resultat:";
            // 
            // tbxTal1
            // 
            this.tbxTal1.Location = new System.Drawing.Point(71, 87);
            this.tbxTal1.Name = "tbxTal1";
            this.tbxTal1.Size = new System.Drawing.Size(100, 20);
            this.tbxTal1.TabIndex = 3;
            // 
            // tbxTal2
            // 
            this.tbxTal2.Location = new System.Drawing.Point(210, 87);
            this.tbxTal2.Name = "tbxTal2";
            this.tbxTal2.Size = new System.Drawing.Size(100, 20);
            this.tbxTal2.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(108, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Addition";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(235, 225);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(89, 23);
            this.btnMulti.TabIndex = 6;
            this.btnMulti.Text = "Multiplikation";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 408);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxTal2);
            this.Controls.Add(this.tbxTal1);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblTal2);
            this.Controls.Add(this.lblTal1);
            this.Name = "Form1";
            this.Text = "Övning - Metoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTal1;
        private System.Windows.Forms.Label lblTal2;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.TextBox tbxTal1;
        private System.Windows.Forms.TextBox tbxTal2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMulti;
    }
}


namespace _6._1
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.tbxA = new System.Windows.Forms.TextBox();
            this.tbxC = new System.Windows.Forms.TextBox();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(144, 89);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(32, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Tal A";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(223, 202);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(39, 13);
            this.lblSvar.TabIndex = 1;
            this.lblSvar.Text = "SVAR:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(144, 118);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(32, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Tal B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(144, 148);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(32, 13);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "Tal C";
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(243, 89);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(100, 20);
            this.tbxA.TabIndex = 4;
            // 
            // tbxC
            // 
            this.tbxC.Location = new System.Drawing.Point(243, 141);
            this.tbxC.Name = "tbxC";
            this.tbxC.Size = new System.Drawing.Size(100, 20);
            this.tbxC.TabIndex = 5;
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(243, 115);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(100, 20);
            this.tbxB.TabIndex = 6;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(258, 253);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 7;
            this.btnKör.Text = "KÖR";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxB);
            this.Controls.Add(this.tbxC);
            this.Controls.Add(this.tbxA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.TextBox tbxC;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.Button btnKör;
    }
}


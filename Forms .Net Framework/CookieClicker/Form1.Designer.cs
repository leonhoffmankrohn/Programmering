namespace CookieClicker
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
            this.btnBake = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBake
            // 
            this.btnBake.Location = new System.Drawing.Point(219, 281);
            this.btnBake.Name = "btnBake";
            this.btnBake.Size = new System.Drawing.Size(267, 225);
            this.btnBake.TabIndex = 0;
            this.btnBake.Text = "BAKE";
            this.btnBake.UseVisualStyleBackColor = true;
            this.btnBake.Click += new System.EventHandler(this.btnBake_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(321, 103);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(51, 55);
            this.lblCounter.TabIndex = 1;
            this.lblCounter.Text = "0";
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(576, 306);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(75, 23);
            this.btnDouble.TabIndex = 2;
            this.btnDouble.Text = "Double UP!";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnBake);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBake;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnDouble;
    }
}


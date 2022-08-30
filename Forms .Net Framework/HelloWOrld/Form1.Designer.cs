namespace HelloWOrld
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
            this.btnColor = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.obj = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(235, 213);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(152, 70);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(502, 307);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(134, 79);
            this.btnGreen.TabIndex = 1;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(50, 307);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 79);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // obj
            // 
            this.obj.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.obj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obj.ForeColor = System.Drawing.SystemColors.Window;
            this.obj.Location = new System.Drawing.Point(100, 100);
            this.obj.Name = "obj";
            this.obj.Size = new System.Drawing.Size(43, 43);
            this.obj.TabIndex = 3;
            this.obj.Text = "[*;_;*]";
            this.obj.UseVisualStyleBackColor = false;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Lime;
            this.btnRun.Location = new System.Drawing.Point(284, 326);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 60);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(706, 431);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.obj);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnColor);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWake1;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button obj;
        private System.Windows.Forms.Button btnRun;
    }
}


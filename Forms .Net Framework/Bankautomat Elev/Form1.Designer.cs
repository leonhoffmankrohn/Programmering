namespace Bankautomat
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
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.lbHistorik = new System.Windows.Forms.ListBox();
            this.lblVal = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblInmatning = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnKlar = new System.Windows.Forms.Button();
            this.btnBacka = new System.Windows.Forms.Button();
            this.btnStopp = new System.Windows.Forms.Button();
            this.btnInsättning = new System.Windows.Forms.Button();
            this.btnUttag = new System.Windows.Forms.Button();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnHistorik = new System.Windows.Forms.Button();
            this.pnlDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplay.Controls.Add(this.lbHistorik);
            this.pnlDisplay.Controls.Add(this.lblVal);
            this.pnlDisplay.Controls.Add(this.lblMsg);
            this.pnlDisplay.Controls.Add(this.lblInmatning);
            this.pnlDisplay.Controls.Add(this.lblNamn);
            this.pnlDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDisplay.Location = new System.Drawing.Point(40, 40);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(488, 231);
            this.pnlDisplay.TabIndex = 0;
            // 
            // lbHistorik
            // 
            this.lbHistorik.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbHistorik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbHistorik.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbHistorik.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.lbHistorik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbHistorik.FormattingEnabled = true;
            this.lbHistorik.Location = new System.Drawing.Point(212, 55);
            this.lbHistorik.Name = "lbHistorik";
            this.lbHistorik.Size = new System.Drawing.Size(258, 104);
            this.lbHistorik.TabIndex = 4;
            this.lbHistorik.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbHistorik_DrawItem);
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Location = new System.Drawing.Point(352, 185);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(54, 27);
            this.lblVal.TabIndex = 3;
            this.lblVal.Text = "...";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(98, 185);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(54, 27);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "...";
            // 
            // lblInmatning
            // 
            this.lblInmatning.AutoSize = true;
            this.lblInmatning.Location = new System.Drawing.Point(13, 80);
            this.lblInmatning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInmatning.Name = "lblInmatning";
            this.lblInmatning.Size = new System.Drawing.Size(194, 27);
            this.lblInmatning.TabIndex = 1;
            this.lblInmatning.Text = "Ange PIN-kod:";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(13, 16);
            this.lblNamn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(180, 27);
            this.lblNamn.TabIndex = 0;
            this.lblNamn.Text = "BANKapp v0.1";
            this.lblNamn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(39, 291);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(71, 61);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(113, 291);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(71, 61);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(187, 291);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(71, 61);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(39, 356);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(71, 61);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(113, 356);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(71, 61);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(187, 356);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(71, 61);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(113, 421);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(71, 61);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(39, 421);
            this.btn7.Margin = new System.Windows.Forms.Padding(2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(71, 61);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(187, 421);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(71, 61);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(114, 486);
            this.btn0.Margin = new System.Windows.Forms.Padding(2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(71, 61);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnKlar
            // 
            this.btnKlar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnKlar.Location = new System.Drawing.Point(285, 421);
            this.btnKlar.Margin = new System.Windows.Forms.Padding(2);
            this.btnKlar.Name = "btnKlar";
            this.btnKlar.Size = new System.Drawing.Size(119, 61);
            this.btnKlar.TabIndex = 0;
            this.btnKlar.Text = "O";
            this.btnKlar.UseVisualStyleBackColor = false;
            this.btnKlar.Click += new System.EventHandler(this.btnKlar_Click);
            // 
            // btnBacka
            // 
            this.btnBacka.BackColor = System.Drawing.Color.Yellow;
            this.btnBacka.Location = new System.Drawing.Point(285, 356);
            this.btnBacka.Margin = new System.Windows.Forms.Padding(2);
            this.btnBacka.Name = "btnBacka";
            this.btnBacka.Size = new System.Drawing.Size(119, 61);
            this.btnBacka.TabIndex = 12;
            this.btnBacka.Text = "<<";
            this.btnBacka.UseVisualStyleBackColor = false;
            this.btnBacka.Click += new System.EventHandler(this.btnBacka_Click);
            // 
            // btnStopp
            // 
            this.btnStopp.BackColor = System.Drawing.Color.Tomato;
            this.btnStopp.Location = new System.Drawing.Point(285, 291);
            this.btnStopp.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopp.Name = "btnStopp";
            this.btnStopp.Size = new System.Drawing.Size(119, 61);
            this.btnStopp.TabIndex = 13;
            this.btnStopp.Text = "X";
            this.btnStopp.UseVisualStyleBackColor = false;
            this.btnStopp.Click += new System.EventHandler(this.btnStopp_Click);
            // 
            // btnInsättning
            // 
            this.btnInsättning.Enabled = false;
            this.btnInsättning.Location = new System.Drawing.Point(422, 486);
            this.btnInsättning.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsättning.Name = "btnInsättning";
            this.btnInsättning.Size = new System.Drawing.Size(106, 61);
            this.btnInsättning.TabIndex = 14;
            this.btnInsättning.Text = "Insättning";
            this.btnInsättning.UseVisualStyleBackColor = true;
            this.btnInsättning.Click += new System.EventHandler(this.btnInsättning_Click);
            // 
            // btnUttag
            // 
            this.btnUttag.Enabled = false;
            this.btnUttag.Location = new System.Drawing.Point(422, 421);
            this.btnUttag.Margin = new System.Windows.Forms.Padding(2);
            this.btnUttag.Name = "btnUttag";
            this.btnUttag.Size = new System.Drawing.Size(106, 61);
            this.btnUttag.TabIndex = 15;
            this.btnUttag.Text = "Uttag";
            this.btnUttag.UseVisualStyleBackColor = true;
            this.btnUttag.Click += new System.EventHandler(this.btnUttag_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.Enabled = false;
            this.btnSaldo.Location = new System.Drawing.Point(422, 356);
            this.btnSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(106, 61);
            this.btnSaldo.TabIndex = 16;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // btnHistorik
            // 
            this.btnHistorik.Enabled = false;
            this.btnHistorik.Location = new System.Drawing.Point(422, 291);
            this.btnHistorik.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistorik.Name = "btnHistorik";
            this.btnHistorik.Size = new System.Drawing.Size(106, 61);
            this.btnHistorik.TabIndex = 17;
            this.btnHistorik.Text = "Historik";
            this.btnHistorik.UseVisualStyleBackColor = true;
            this.btnHistorik.Click += new System.EventHandler(this.btnHistorik_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnKlar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 558);
            this.Controls.Add(this.btnHistorik);
            this.Controls.Add(this.btnSaldo);
            this.Controls.Add(this.btnUttag);
            this.Controls.Add(this.btnInsättning);
            this.Controls.Add(this.btnStopp);
            this.Controls.Add(this.btnBacka);
            this.Controls.Add(this.btnKlar);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pnlDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "BANKapp";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblInmatning;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnKlar;
        private System.Windows.Forms.Button btnBacka;
        private System.Windows.Forms.Button btnStopp;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Button btnInsättning;
        private System.Windows.Forms.Button btnUttag;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnHistorik;
        private System.Windows.Forms.ListBox lbHistorik;
    }
}


namespace DicePlay
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
            this.lblAvrg = new System.Windows.Forms.Label();
            this.avrg = new System.Windows.Forms.Label();
            this.cast = new System.Windows.Forms.Label();
            this.lblThrows = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.dicenum = new System.Windows.Forms.Label();
            this.lblDice = new System.Windows.Forms.Label();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.setDice = new System.Windows.Forms.NumericUpDown();
            this.setThrows = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setThrows)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvrg
            // 
            this.lblAvrg.AutoSize = true;
            this.lblAvrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvrg.Location = new System.Drawing.Point(220, 118);
            this.lblAvrg.Name = "lblAvrg";
            this.lblAvrg.Size = new System.Drawing.Size(27, 15);
            this.lblAvrg.TabIndex = 0;
            this.lblAvrg.Text = "000";
            this.lblAvrg.Click += new System.EventHandler(this.lblAvrg_Click);
            // 
            // avrg
            // 
            this.avrg.AutoSize = true;
            this.avrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avrg.Location = new System.Drawing.Point(149, 118);
            this.avrg.Name = "avrg";
            this.avrg.Size = new System.Drawing.Size(52, 15);
            this.avrg.TabIndex = 1;
            this.avrg.Text = "Average:";
            // 
            // cast
            // 
            this.cast.AutoSize = true;
            this.cast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cast.Location = new System.Drawing.Point(116, 66);
            this.cast.Name = "cast";
            this.cast.Size = new System.Drawing.Size(85, 15);
            this.cast.TabIndex = 3;
            this.cast.Text = "Throws throwed";
            // 
            // lblThrows
            // 
            this.lblThrows.AutoSize = true;
            this.lblThrows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThrows.Location = new System.Drawing.Point(220, 66);
            this.lblThrows.Name = "lblThrows";
            this.lblThrows.Size = new System.Drawing.Size(27, 15);
            this.lblThrows.TabIndex = 2;
            this.lblThrows.Text = "000";
            // 
            // run
            // 
            this.run.AutoSize = true;
            this.run.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.run.Location = new System.Drawing.Point(106, 37);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(95, 15);
            this.run.TabIndex = 5;
            this.run.Text = "Last Run Average";
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrevious.Location = new System.Drawing.Point(220, 37);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(27, 15);
            this.lblPrevious.TabIndex = 4;
            this.lblPrevious.Text = "000";
            // 
            // dicenum
            // 
            this.dicenum.AutoSize = true;
            this.dicenum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dicenum.Location = new System.Drawing.Point(86, 92);
            this.dicenum.Name = "dicenum";
            this.dicenum.Size = new System.Drawing.Size(115, 15);
            this.dicenum.TabIndex = 7;
            this.dicenum.Text = "Possible dice outcome";
            // 
            // lblDice
            // 
            this.lblDice.AutoSize = true;
            this.lblDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDice.Location = new System.Drawing.Point(220, 92);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(15, 15);
            this.lblDice.TabIndex = 6;
            this.lblDice.Text = "6";
            // 
            // grpData
            // 
            this.grpData.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpData.Controls.Add(this.label21);
            this.grpData.Controls.Add(this.label22);
            this.grpData.Controls.Add(this.label19);
            this.grpData.Controls.Add(this.label20);
            this.grpData.Controls.Add(this.label15);
            this.grpData.Controls.Add(this.label16);
            this.grpData.Controls.Add(this.label13);
            this.grpData.Controls.Add(this.label14);
            this.grpData.Controls.Add(this.label11);
            this.grpData.Controls.Add(this.label12);
            this.grpData.Controls.Add(this.label9);
            this.grpData.Controls.Add(this.label10);
            this.grpData.Controls.Add(this.label7);
            this.grpData.Controls.Add(this.label8);
            this.grpData.Controls.Add(this.avrg);
            this.grpData.Controls.Add(this.dicenum);
            this.grpData.Controls.Add(this.lblDice);
            this.grpData.Controls.Add(this.run);
            this.grpData.Controls.Add(this.lblPrevious);
            this.grpData.Controls.Add(this.lblAvrg);
            this.grpData.Controls.Add(this.lblThrows);
            this.grpData.Controls.Add(this.cast);
            this.grpData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpData.Location = new System.Drawing.Point(492, 36);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(282, 389);
            this.grpData.TabIndex = 8;
            this.grpData.TabStop = false;
            this.grpData.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Possible dice output:";
            // 
            // setDice
            // 
            this.setDice.Location = new System.Drawing.Point(242, 154);
            this.setDice.Name = "setDice";
            this.setDice.Size = new System.Drawing.Size(49, 20);
            this.setDice.TabIndex = 11;
            this.setDice.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.setDice.ValueChanged += new System.EventHandler(this.setDice_ValueChanged);
            // 
            // setThrows
            // 
            this.setThrows.Location = new System.Drawing.Point(242, 222);
            this.setThrows.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.setThrows.Name = "setThrows";
            this.setThrows.Size = new System.Drawing.Size(49, 20);
            this.setThrows.TabIndex = 13;
            this.setThrows.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.setThrows.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Throws:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(408, 79);
            this.Title.TabIndex = 14;
            this.Title.Text = "Dice Emmulator";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Lime;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRun.Font = new System.Drawing.Font("MS Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(331, 343);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(110, 63);
            this.btnRun.TabIndex = 15;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(131, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Added:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(220, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "000";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(133, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total threes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(220, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(139, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total fours:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(220, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(140, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Total fives:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(220, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(139, 298);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "Total sixes:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(220, 298);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(140, 186);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 15);
            this.label19.TabIndex = 21;
            this.label19.Text = "Total twos:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Location = new System.Drawing.Point(220, 186);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 15);
            this.label20.TabIndex = 20;
            this.label20.Text = "000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Location = new System.Drawing.Point(142, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 15);
            this.label21.TabIndex = 23;
            this.label21.Text = "Total ones:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(220, 160);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 15);
            this.label22.TabIndex = 22;
            this.label22.Text = "000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.setThrows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setDice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpData);
            this.Name = "Form1";
            this.Text = "Dice Emmulator";
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setThrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvrg;
        private System.Windows.Forms.Label avrg;
        private System.Windows.Forms.Label cast;
        private System.Windows.Forms.Label lblThrows;
        private System.Windows.Forms.Label run;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label dicenum;
        private System.Windows.Forms.Label lblDice;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown setDice;
        private System.Windows.Forms.NumericUpDown setThrows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}


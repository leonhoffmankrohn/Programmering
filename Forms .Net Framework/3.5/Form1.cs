﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string namn = tbxNamn.Text;
            int år = int.Parse(tbxFödd.Text) + 50;
            lblInfo.Text = år + " fyller " + namn + " 50 år!";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBake_Click(object sender, EventArgs e)
        {
            int x = int.Parse(lblCounter.Text);
            x += 1;
            lblCounter.Text = x.ToString();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {

        }
    }
}

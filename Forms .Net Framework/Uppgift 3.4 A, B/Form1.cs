using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_3._4_A__B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUttag_Click(object sender, EventArgs e)
        {
            int antal100 = int.Parse(tbxUttag.Text) / 100; // Får fram tot. uttaget avrundat ner till närmaste hundra
            int antal500 = antal100 / 5;
            antal500 = antal500 * 100;
            antal100 = antal100 - antal500;
            antal100 = antal100 * 100; 

            lbl100.Text = "Uttag i 100-sedlar: " + antal100 + " kr";
            lbl500.Text = "Uttag i 500-sedlar: " + antal500 + " kr";
        }
    }
}

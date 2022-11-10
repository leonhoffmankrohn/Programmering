using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            // tbxSlutantal.Text = (Math.Pow(2, int.Parse(tbxTid.Text))* int.Parse(tbxStartantal.Text)).ToString();
            int Tid = int.Parse(tbxTid.Text);
            int antalBakterier = int.Parse(tbxStartantal.Text);

            for (int i = 0; i < Tid; i++) 
            {
                antalBakterier *= 2;
            }
            tbxSlutantal.Text = antalBakterier.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndraYatzy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Var sej index är en tärning
        bool[] behåll = new bool[6];
        Image[] grafik = { Tärningsgrafik.d0, Tärningsgrafik.d1, Tärningsgrafik.d2, Tärningsgrafik.d3, Tärningsgrafik.d4, Tärningsgrafik.d5, Tärningsgrafik.d6 };
        int[] slag = new int[5];

        private void btnSlå_Click(object sender, EventArgs e)
        {

        }

        // Här kommer alla olika tärningar och hur vi sparar dem till nästa slag och hur 
        private void pc1_Click(object sender, EventArgs e)
        {
            if (pc1.BorderStyle == BorderStyle.None)
            {
                behåll[0] = true;
                pc1.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                behåll[0] = false;
                pc1.BorderStyle = BorderStyle.None;
            }
        }

        private void pc2_Click(object sender, EventArgs e)
        {
            if (pc2.BorderStyle == BorderStyle.None)
            {
                behåll[1] = true;
                pc2.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                behåll[1] = false;
                pc2.BorderStyle = BorderStyle.None;
            }
        }

        private void pc3_Click(object sender, EventArgs e)
        {
            if (pc3.BorderStyle == BorderStyle.None)
            {
                behåll[2] = true;
                pc3.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                behåll[2] = false;
                pc3.BorderStyle = BorderStyle.None;
            }
        }

        private void pc4_Click(object sender, EventArgs e)
        {
            if (pc4.BorderStyle == BorderStyle.None)
            {
                behåll[3] = true;
                pc4.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                behåll[3] = false;
                pc4.BorderStyle = BorderStyle.None;
            }
        }

        private void pc5_Click(object sender, EventArgs e)
        {
            if (pc5.BorderStyle == BorderStyle.None)
            {
                behåll[4] = true;
                pc5.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                behåll[4] = false;
                pc5.BorderStyle = BorderStyle.None;
            }
        }

    }
}

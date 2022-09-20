using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKast_Click(object sender, EventArgs e)
        {
            Random slump = new Random();
            int resultat = slump.Next(1, 7);
            lblSvar.Text = resultat.ToString();
            if (resultat == 6)
            {
                MessageBox.Show("Grattis!");
            }
        }
    }
}

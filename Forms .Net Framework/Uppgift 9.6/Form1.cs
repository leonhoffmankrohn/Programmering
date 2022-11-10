using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_9._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            Random tärning = new Random();
            int räknare = 0;

            for (int i = 0; i < 1000; i++) 
            {
                if (tärning.Next(1, 7) == 6) 
                { 
                    räknare++;
                }
            }
            lblResultat.Text = räknare.ToString();
        }
    }
}

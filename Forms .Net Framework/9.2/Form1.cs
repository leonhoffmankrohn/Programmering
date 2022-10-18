using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            double tal = 1;
            int räknare = 0;
            int slut = 64;

            while (räknare < slut) 
            { 
                räknare++;
                tal += tal;
                tbxUtdata.AppendText("Ruta " + räknare + ": " + tal.ToString() + "\r\n");
            }
        }
    }
}

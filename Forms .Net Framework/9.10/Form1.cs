using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._10
{
    public partial class Form1 : Form
    {
        int[] rad1 = new int[6];
        int[] rad2 = new int[6];
        int[] rad3 = new int[6];


        public Form1()
        {
            InitializeComponent();

            lbxMeny.Items.Add("Rad 1");
            lbxMeny.Items.Add("Rad 2");
            lbxMeny.Items.Add("Rad 3");

            lbxMeny.SelectedItem = lbxMeny.Items[0];
        }

        private void btnVälj_Click(object sender, EventArgs e)
        {
            tbxVal.Clear();
            string valdRad = lbxMeny.SelectedItem.ToString();
            if (valdRad == "Rad 1") 
            {
                for (int i = 0; i < rad1.Length; i++)
                {
                    tbxVal.Text += rad1[i].ToString() + "\r\n";
                }
            }
            if (valdRad == "Rad 2")
            {
                for (int i = 0; i < rad2.Length; i++)
                {
                    tbxVal.Text += rad2[i].ToString() + "\r\n";
                }
            }
            if (valdRad == "Rad 3")
            {
                for (int i = 0; i < rad3.Length; i++)
                {
                    tbxVal.Text += rad3[i].ToString() + "\r\n";
                }
            }
        }

        private void btnGenerera_Click(object sender, EventArgs e)
        {
            Random slump = new Random();

            for (int i = 0; i < 6; i++) 
            {
                rad1[i] = slump.Next(1,21);
                rad2[i] = slump.Next(1,21); 
                rad3[i] = slump.Next(1,21); 
                tbxRad1.AppendText(rad1[i] + "\r\n");
                tbxRad2.AppendText(rad2[i] + "\r\n");
                tbxRad3.AppendText(rad3[i] + "\r\n");
            }
        }
    }
}

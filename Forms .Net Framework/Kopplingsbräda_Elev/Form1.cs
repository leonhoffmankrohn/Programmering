using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Kopplingsbräda
{
    public partial class Form1 : Form
    {
        public Lampor Lampor { get; }
        public Uppgift Uppgift { get; }
        
        public Form1()
        {
            Uppgift = new Uppgift();
            Lampor = new Lampor();
            InitializeComponent();
            LaddaLampor();
            UppdateraGUI();
        }

        private void LaddaLampor()
        {
            Lampor.HämtaLampa(11).TändLampa(true);
            Lampor.HämtaLampa(5).TändLampa(true);
            Lampor.HämtaLampa(3).TändLampa(true);
            Lampor.HämtaLampa(2).TändLampa(true);
        }

        private void UppdateraGUI()
        {
            pcLamp1.Image = Lampor.HämtaLampa(0).Color;
            pcLamp2.Image = Lampor.HämtaLampa(1).Color;
            pcLamp3.Image = Lampor.HämtaLampa(2).Color;
            pcPower_4.Image = Lampor.HämtaLampa(3).Color;
            pcLamp4.Image = Lampor.HämtaLampa(4).Color;
            pcPower_5.Image = Lampor.HämtaLampa(5).Color;
            pcLamp_5.Image = Lampor.HämtaLampa(6).Color;
            pcLamp_6.Image = Lampor.HämtaLampa(7).Color;
            pcLamp1_7.Image = Lampor.HämtaLampa(8).Color;
            pcLamp2_7.Image = Lampor.HämtaLampa(9).Color;
            pcLamp3_7.Image = Lampor.HämtaLampa(10).Color;
            pcLamp_8.Image = Lampor.HämtaLampa(11).Color;


        }


        //   Uppgift 1

        private void btn1_Click(object sender, EventArgs e)
        {
            Genomför1(true, false);
            UppdateraGUI();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Genomför1(false, true);
            UppdateraGUI();

        }

        private void Genomför1(bool knapp1, bool knapp2)
        {
            Lampa lampa = Lampor.HämtaLampa(0);

            if (Uppgift.Uppgift1(knapp1, knapp2))
            {
                lampa.TändLampa(true);
            }
            else 
            {
                lampa.TändLampa(false);
            }
        }

        //  Uppgift 2

        private void btnStröm_Click(object sender, EventArgs e)
        {
            Genomför2();
            UppdateraGUI();
        }

        private void Genomför2()
        {
            Lampa lampa = Lampor.HämtaLampa(1);

            if (Uppgift.Uppgift2(lampa.StrömPå))
            {
                lampa.TändLampa(true);
            }
            else
            {
                lampa.TändLampa(false);
            }
        }

        //  Uppgift 3

        private void tbSlider_3_Scroll(object sender, EventArgs e)
        {
            lblValue_3.Text = tbSlider_3.Value.ToString();
            Genomför3();
            UppdateraGUI();
        }

        private void Genomför3()
        {
            Lampa lampa = Lampor.HämtaLampa(2);

            lampa.SättFärg(Uppgift.Uppgift3(tbSlider_3.Value));
        }

        //  Uppgift 4

        private void cbxPower_4_CheckedChanged(object sender, EventArgs e)
        {
            Lampa lampa = Lampor.HämtaLampa(3);

            if (cbxPower_4.Checked)
                lampa.SättFärg(Färg.Grön);
            else
                lampa.SättFärg(Färg.Röd);

            Genomför4();
            UppdateraGUI();
        }

        private void tbSlider_4_Scroll(object sender, EventArgs e)
        {
            lblValue_4.Text = tbSlider_4.Value.ToString();
            Genomför4();
            UppdateraGUI();
        }

        private void Genomför4()
        {
            Lampa lampa = Lampor.HämtaLampa(4);

            lampa.TändLampa(Uppgift.Uppgift4(cbxPower_4.Checked, tbSlider_4.Value));
        }

        //  Uppgift 5

        private void cbxPower_5_CheckedChanged(object sender, EventArgs e)
        {
            Lampa lampa = Lampor.HämtaLampa(5);

            if (cbxPower_5.Checked)
                lampa.SättFärg(Färg.Grön);
            else
                lampa.SättFärg(Färg.Röd);

            Genomför5();
            UppdateraGUI();
        }

        private void tbSlider_5_Scroll(object sender, EventArgs e)
        {
            lblValue_5.Text = tbSlider_5.Value.ToString();
            Genomför5();
            UppdateraGUI();
        }

        private void Genomför5()
        {
            Lampa lampa = Lampor.HämtaLampa(6);

            lampa.TändLampa(Uppgift.Uppgift5(cbxPower_5.Checked, tbSlider_5.Value));
        }


        //  Uppgift 6

        private void tbxPin_6_TextChanged(object sender, EventArgs e)
        {
            Lampor.HämtaLampa(7).TändLampa(false);
            UppdateraGUI();
        }

        private void btnPin_6_Click(object sender, EventArgs e)
        {
            Genomför6();
            UppdateraGUI();
        }

        private void Genomför6()
        {
            Lampa lampa = Lampor.HämtaLampa(7);

            if (int.TryParse(tbxPin_6.Text, out int result))
            {
                tbxPin_6.Text = "";
                lampa.SättFärg(Uppgift.Uppgift6(result));
            }
            else
            {
                tbxPin_6.Text = "";
                lampa.SättFärg(Uppgift.Uppgift6(0));
            }


        }

        //  Uppgift 7

        private void cbx1_7_CheckedChanged(object sender, EventArgs e)
        {
            Genomför7();
            UppdateraGUI();
            ToogleCheckbox(cbx1_7);
        }

        private void cbx2_7_CheckedChanged(object sender, EventArgs e)
        {
            Genomför7();
            UppdateraGUI();
            ToogleCheckbox(cbx2_7);
        }

        private void cbx3_7_CheckedChanged(object sender, EventArgs e)
        {
            Genomför7();
            UppdateraGUI();
            ToogleCheckbox(cbx3_7);
        }

        private void cbx4_7_CheckedChanged(object sender, EventArgs e)
        {
            Genomför7();
            UppdateraGUI();
            ToogleCheckbox(cbx4_7);
        }

        private void cbx5_7_CheckedChanged(object sender, EventArgs e)
        {
            Genomför7();
            UppdateraGUI();
            ToogleCheckbox(cbx5_7);
        }

        private void cbx6_7_CheckedChanged(object sender, EventArgs e)
        {
            Genomför7();
            UppdateraGUI();
            ToogleCheckbox(cbx6_7);
        }

        private void cbx7_7_CheckedChanged(object sender, EventArgs e)
        {
            Genomför7();
            UppdateraGUI(); 
            ToogleCheckbox(cbx7_7);
        }

        private void ToogleCheckbox(CheckBox cbx)
        {
            if (cbx.Checked)
                cbx.BackColor = Color.Yellow;
            else
                cbx.BackColor = DefaultBackColor;
        }

        private void Genomför7()
        {
            bool[] lampor = Uppgift.Uppgift7(cbx1_7.Checked, cbx2_7.Checked, cbx3_7.Checked, cbx4_7.Checked, cbx5_7.Checked, cbx6_7.Checked, cbx7_7.Checked);

            Lampor.HämtaLampa(8).TändLampa(lampor[0]);
            Lampor.HämtaLampa(9).TändLampa(lampor[1]);
            Lampor.HämtaLampa(10).TändLampa(lampor[2]);

        }


        //  Uppgift 8

        private void cbxPower_8_CheckedChanged(object sender, EventArgs e)
        {
            Genomför8();
            UppdateraGUI();
        }

        private void Genomför8()
        {
            Lampor.HämtaLampa(11).SättFärg(Uppgift.Uppgift8(cbxPower_8.Checked));
        }



    }
}

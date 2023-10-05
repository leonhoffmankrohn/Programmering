using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Djur> djurlista = new List<Djur>();
        public MainWindow()
        {
            InitializeComponent();

            // Här läggs värden in som ska vara från början
            string[] köntyper = Enum.GetNames(typeof(KönTyp));

            foreach (string kön in köntyper)
            {
                lbxKön.Items.Add(kön);
            }
               
            
            lbxKön.SelectedIndex = 0;

            string[] djurtyper = Enum.GetNames(typeof(DjurTyp));

            foreach (string typ in djurtyper)
            {
                lbxGrupp.Items.Add(typ);
            }
               
            lbxGrupp.SelectedIndex = 0;
            tblSpc1.Text = "Nattaktivt?";
            lviewRegister.ItemsSource = djurlista;
        }

        // Här uppdateras listview:en med korresponderande data
        void UppdateraLviewRegister()
        {
            lviewRegister.Items.Refresh();
        }

        // Här skapas ett djur och läggs till i en djurlista
        void SkapaDjur(string namn, double ålder, KönTyp kön, bool harExtraAttribut, string attribut2)
        {
            // index 0 är däggdjur
            // djurlista.Add((lbxGrupp.SelectedIndex == 0) ? new Däggdjur(namn, ålder, kön, harExtraAttribut): new Fisk(namn, ålder, kön, harExtraAttribut));
            if (lbxGrupp.SelectedIndex == 0) // Grupp däggdjur
            {
                // 0 = hund, 1 = katt
                if (lbxArt.SelectedIndex == 0) djurlista.Add(new Hund(namn, ålder, kön, harExtraAttribut, attribut2));
                else djurlista.Add(new Katt(namn, ålder, kön, harExtraAttribut, attribut2));
            }
            else // grupp fisk
            {
                // 0 = lax, 1 = sill
                 if (lbxArt.SelectedIndex == 0) djurlista.Add(new Lax(namn, ålder, kön, harExtraAttribut, attribut2));
                 else djurlista.Add(new Sill(namn, ålder, kön, harExtraAttribut, attribut2));
            }



        }

        // Denna körs vid knapptryck och samlar in data om djuret och skickar data för skapande och lagrande av djur men åker också vidare till att uppdatera listview:en
        private void btnLäggTillDjur_Click(object sender, RoutedEventArgs e)
        {
            string namn = tbxNamn.Text;
            double.TryParse(tbxÅlder.Text, out double ålder);
            KönTyp könet = (KönTyp)lbxKön.SelectedIndex;
            bool harExtraAttribut = (rbJa.IsChecked == true) ? true : false;
            string attribut2 = tbxSpc2.Text;
            SkapaDjur(namn, ålder, könet, harExtraAttribut, attribut2);
            UppdateraLviewRegister();
        }
        void lbxArt_Ändra(Enum art)
        {
            lbxArt.Items.Clear();
            string[] djurtyper = Enum.GetNames(typeof(art));
            foreach (string typ in djurtyper) { lbxArt.Items.Add(typ); }
        }

        // Här ändrar vi frågan i textblocket ifall däggdjur eller fisk är vald i listboxen
        private void lbxGrupp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DjurTyp gruppval = (DjurTyp)lbxGrupp.SelectedIndex;
            
            if (gruppval == DjurTyp.Däggdjur) // Däggdjur
            {
                tblSpc1.Text = "Nattaktivt?";

                lbxArt_Ändra(DäggdjurTyp.Hund);

            }
            else if (gruppval == DjurTyp.Fisk) // Fisk
            {
                tblSpc1.Text = "Sötvatten?";

                lbxArt_Ändra(FiskTyp.Lax);
            }
            lbxArt.SelectedIndex = 0;

        }

        private void lbxArt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DjurTyp gruppval = (DjurTyp)lbxGrupp.SelectedIndex;
            Enum artval = (gruppval == DjurTyp.Däggdjur) ? (DäggdjurTyp)artval : (FiskTyp)artval;
            
            /*if (gruppval == DjurTyp.Däggdjur)
            {
                DäggdjurTyp artval = (DäggdjurTyp)lbxArt.SelectedIndex;
                if (artval == DäggdjurTyp.Hund)
                {
                    tblSpc2.Text = "Ras";
                    lbxArt.Items.Clear();
                    string[] djurtyper = Enum.GetNames(typeof(DäggdjurTyp));
                    foreach (string typ in djurtyper) { lbxArt.Items.Add(typ); }
                }
                else if (artval == DäggdjurTyp.Katt)
                {
                    tblSpc2.Text = "Sötvatten?";
                    lbxArt.Items.Clear();
                    string[] djurtyper = Enum.GetNames(typeof(FiskTyp));
                    foreach (string typ in djurtyper) lbxArt.Items.Add(typ);
                }
            }
            else if (gruppval == DjurTyp.Fisk)
            {
                FiskTyp artval = (FiskTyp)lbxArt.SelectedIndex;
                if(artval == FiskTyp.Lax)
                {
                    tblSpc2.Text = "Nattaktivt?";
                    lbxArt.Items.Clear();
                    string[] djurtyper = Enum.GetNames(typeof(DäggdjurTyp));
                    foreach (string typ in djurtyper) { lbxArt.Items.Add(typ); }
                }
                else if (artval == FiskTyp.Sill)
                {
                    tblSpc2.Text = "Sötvatten?";
                    lbxArt.Items.Clear();
                    string[] djurtyper = Enum.GetNames(typeof(FiskTyp));
                    foreach (string typ in djurtyper) lbxArt.Items.Add(typ);
                }*/
            }
        }
    }
}

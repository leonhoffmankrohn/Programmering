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

            // Här läggs köntyperna in i listboxen
            string[] köntyper = Enum.GetNames(typeof(KönTyp));

            foreach (string kön in köntyper) lbxKön.Items.Add(kön);
            lbxKön.SelectedIndex = 0;

            string[] djurtyper = Enum.GetNames(typeof(DjurTyp));

            foreach (string typ in djurtyper) lbxGrupp.Items.Add(typ);
            lbxGrupp.SelectedIndex = 0;

            tblSpc1.Text = "Nattaktivt?";
        }

        // Här uppdateras listview:en med korresponderande data
        void UppdateraLviewRegister()
        {
            lviewRegister.ItemsSource = null;
            lviewRegister.ItemsSource = djurlista;
        }

        // Här skapas ett djur och läggs till i en djurlista
        void SkapaDjur(string namn, double ålder, KönTyp kön, bool harExtraAttribut)
        {
            // index 0 är däggdjur
            djurlista.Add((lbxGrupp.SelectedIndex == 0) ? new Däggdjur(namn, ålder, kön, harExtraAttribut): new Fisk(namn, ålder, kön, harExtraAttribut));
        }

        // Denna körs vid knapptryck och samlar in data om djuret och skickar data för skapande och lagrande av djur men åker också vidare till att uppdatera listview:en
        private void btnLäggTillDjur_Click(object sender, RoutedEventArgs e)
        {
            string namn = tbxNamn.Text;
            double.TryParse(tbxÅlder.Text, out double ålder);
            KönTyp könet = (KönTyp)lbxKön.SelectedIndex;
            bool harExtraAttribut = (rbJa.IsChecked == true) ? true : false;
            SkapaDjur(namn, ålder, könet, harExtraAttribut);
            UppdateraLviewRegister();
        }

        // Här ändrar vi frågan i textblocket ifall däggdjur eller fisk är vald i listboxen
        private void lbxGrupp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tblSpc1.Text = (lbxGrupp.SelectedIndex == 0) ? "Nattaktivt?": "Sötvatten?";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
using System.Xml.Linq;

namespace Filmregister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Initierar några variabler
        List<Film> filmbibliotek = new List<Film>();

        // Här rensar vi listboxen och uppdaterar med ny information
        private void UppdateraGrafik(List<Film> lista, ListBox grafiskLista) 
        { 
            grafiskLista.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grafiskLista.Items.Add(lista[i].Sträng());
            }
        }

        // Här tar vi bort en film från regisstret
        private bool Tabort(List<Film> lista, ListBox grafiskLista) 
        {
            int index = grafiskLista.SelectedIndex;
            if (index != -1)
            {
                lista.RemoveAt(index);
                UppdateraGrafik(lista, grafiskLista);
                return true;
            }
            else
            {
                MessageBox.Show("Nja, du behöver nog välja något att ta bort först!");
                return false;
            }
        }

        // Här gör vi en ny film med skriven data
        private void LäggTill() 
        {
                string namn = tbxNamn.Text;
                string årgång = tbxÅrgång.Text;
                string regissör = tbxRegissör.Text;
                string genre = cbxGenre.ToString();
                string vinst = tbxVinst.Text;
            if (namn == "" || årgång == "" || regissör == "" || genre == "" || vinst == "" || int.TryParse(årgång) || int.TryParse(vinst))
            {
                MessageBox.Show("Nja, nu har du glömt att skriva in något...");
            }
            else
            {
                Film film = new Film(namn, int.Parse(årgång), regissör, genre, int.Parse(vinst));
                filmbibliotek.Add(film);
                UppdateraGrafik(filmbibliotek, lbxRegister);
            }
        }

        private void btnLäggtill_Click(object sender, RoutedEventArgs e)
        {
            LäggTill();
        }

        private void btnTabort_Click(object sender, RoutedEventArgs e)
        {
            Tabort(filmbibliotek, lbxRegister);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Printing;
using System.Reflection;
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

        //Initierar några användbara variabler
        int index = -1;
        List<Media> mediebiblioteket = new();

        // Här rensar vi listboxen och uppdaterar med ny information
        private void UppdateraGrafik(List<Media> lista, ListBox grafiskLista) 
        {
            grafiskLista.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grafiskLista.Items.Add(lista[i].ToString());
            }
            index = -1;
            lbxRegister.SelectedIndex = -1;
        }

        // Här gör vi en ny film/serie med skriven data och sparar i en medielista(mediebiblioteket)
        // Kollar också om vi har valt ett item i listboxen och uppdaterar den isf
        private void LäggTill() 
        {
            bool film = (bool)rbnFilm.IsChecked;
            if (index == -1)
            {
                if (film && int.TryParse(tbxSpeltid.Text, out int speltid))
                {
                    string filmtyp = cbxFilmtyp.Text;
                    mediebiblioteket.Add(new Film(tbxNamn, cbxGenre, tbxSpeltid, cbxFilmtyp));
                }
                else if (!film && int.TryParse(tbxSäsonger.Text, out int säsonger))
                {
                    string serietyp = cbxSerietyp.Text;
                    mediebiblioteket.Add(new Serie(tbxNamn, cbxGenre, tbxSäsonger, cbxSerietyp));
                }
                else MessageBox.Show("Använd endast siffror vid angivelse av speltid och säsonger.");
            } 
            else
            {
                if (film && int.TryParse(tbxSpeltid.Text, out int speltid))
                {
                    string filmtyp = cbxFilmtyp.Text;
                    mediebiblioteket[index] = new Film(tbxNamn, cbxGenre, tbxSpeltid, cbxFilmtyp);
                }
                else if (!film && int.TryParse(tbxSäsonger.Text, out int säsonger))
                {
                    string serietyp = cbxSerietyp.Text;
                    mediebiblioteket[index] = new Serie(tbxNamn, cbxGenre, tbxSäsonger, cbxSerietyp);
                }
                else MessageBox.Show("Använd endast siffror vid angivelse av speltid och säsonger.");
            }

            UppdateraGrafik(mediebiblioteket, lbxRegister);
        }

        // Här tar vi bort en film från regisstret 
        private bool Tabort(List<Media> lista, ListBox grafiskLista) 
        {
            index = lbxRegister.SelectedIndex;
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

        // Hämtar all data som är sparad i klassen och placerar den rätt
        private void Redigera()
        {
            index = lbxRegister.SelectedIndex;
            if (index != -1)
            {
                Media medie = mediebiblioteket[index];
                medie.Hämta();
                if (medie.GetType().ToString() == "Filmregister.Film") FilmFokus();
                else SerieFokus();
            }
        }

        // Sätter fokus på filmfrågorna och sätter film som checkad radioknapp
        public void FilmFokus()
        {
            rbnFilm.IsChecked = true;
            tbxSpeltid.IsEnabled = true;
            tbxSäsonger.IsEnabled = false;
            cbxFilmtyp.IsEnabled = true;
            cbxSerietyp.IsEnabled = false;
        }

        // Sätter fokus på seriefrågorna och sätter film som checkad radioknapp
        public void SerieFokus()
        {
            rbnSerie.IsChecked = true;
            tbxSpeltid.IsEnabled = false;
            tbxSäsonger.IsEnabled = true;
            cbxFilmtyp.IsEnabled = false;
            cbxSerietyp.IsEnabled = true;
        }

        private void btnRedigera_Click(object sender, RoutedEventArgs e)
        {
            Redigera();
        }

        private void rbnSerie_Click(object sender, RoutedEventArgs e)
        {
            SerieFokus();
        }

        private void rbnFilm_Click(object sender, RoutedEventArgs e)
        {
            FilmFokus();
        }
        private void btnLäggtill_Click(object sender, RoutedEventArgs e)
        {
            LäggTill();
        }

        private void btnTabort_Click(object sender, RoutedEventArgs e)
        {
            Tabort(mediebiblioteket, lbxRegister);
        }

        private void cbxFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

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
        private void UppdateraGrafik(List<string> lista, ListBox grafiskLista) 
        { 
            grafiskLista.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grafiskLista.Items.Add(lista[i]);
            }
        }

        // Här tar vi bort en film från regisstret
        private void Tabort(List<string> lista, ListBox grafiskLista) 
        {
            lista.RemoveAt(grafiskLista.SelectedIndex);
            UppdateraGrafik(lista, grafiskLista);
        }



    }
}

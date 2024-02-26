using Microsoft.Win32;
using System.IO;
using System.Text;
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

namespace Receptprogrammet__övning_4._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Ingridiens> ingridienser = new List<Ingridiens>();
        OpenFileDialog dlgÖppnaFil = new OpenFileDialog() { DefaultExt= ".rec", Filter="Recept filer | *.rec"};
        SaveFileDialog dlgSparaFil = new SaveFileDialog() { DefaultExt = ".rec", Filter = "Recept filer | *.rec" };

        public MainWindow()
        {
            InitializeComponent();
        }

        void UppdateraDg()
        {
            dgRecept.ItemsSource = null;
            dgRecept.ItemsSource = ingridienser;
        }

        void TömInput()
        {
            tbxNamn.Clear();
            tbxMängd.Clear();
            tbxMått.Clear();
        }

        bool Tomhet(TextBox tbx)
        {
            return (tbx.Text == "") ? true : false;
        }

        void LäggTill()
        {
            if (!(Tomhet(tbxNamn) && Tomhet(tbxMängd) && Tomhet(tbxMått)))
            {
                float.TryParse(tbxMängd.Text, out float mängd);
                ingridienser.Add(new Ingridiens(tbxNamn.Text, mängd, tbxMått.Text));
                TömInput();
                UppdateraDg();
            }
        }

        private void btnLäggTill_Click(object sender, RoutedEventArgs e)
        {
            LäggTill();
        }

        private void miÖppna_Click(object sender, RoutedEventArgs e)
        {
            dlgÖppnaFil.DefaultDirectory = "saves";
            if (dlgÖppnaFil.ShowDialog() == true)
            {
                ingridienser = new List<Ingridiens>();
                FileStream inström = new FileStream(dlgÖppnaFil.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader läsare = new BinaryReader(inström);
                int antalIngridienser = läsare.ReadInt32();
                for (int i = 0; i < antalIngridienser; i++)
                {
                    Ingridiens nyIngridiens = new Ingridiens(läsare.ReadString(), läsare.ReadSingle(), läsare.ReadString());
                    ingridienser.Add(nyIngridiens);
                }
                läsare.Dispose();
                UppdateraDg();
            }
        }

        private void miSparaSom_Click(object sender, RoutedEventArgs e)
        {
            dlgSparaFil.FileName = "recept";
            if (dlgSparaFil.ShowDialog() == true)
            {
                FileStream utström = new FileStream(dlgSparaFil.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter skrivare = new BinaryWriter(utström);
                skrivare.Write((int)ingridienser.Count);
                foreach (Ingridiens ingridiens in ingridienser)
                {
                    skrivare.Write(ingridiens.Namn);
                    skrivare.Write(ingridiens.Mängd);
                    skrivare.Write(ingridiens.Mått);
                }
                skrivare.Dispose();
            }
        }
    }
}
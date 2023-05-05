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

namespace Lotteri
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        List<Spel> spelomgångar = new List<Spel>();
        public bool IsNumber(string num)
        {
            return int.TryParse(num, out int bla);
        }

        public void UpddateraGrafik()
        {
            spelomgångar[0]
        }

        public void Kör()
        {
            int dragningar = 100;
            Lottorad lottorad;

            List<TextBox> tbxs = new() { tbxNum1, tbxNum2, tbxNum3, tbxNum4, tbxNum5, tbxNum6, tbxNum7 };
            bool alltGrönt = true;
            int[] inskrivnaNummer = new int[7];

            for (int i = 0; i < tbxs.Count; i++)
            {
                if (!(IsNumber(tbxs[i].Text) && IsNumber(tbxDragningar.Text))) alltGrönt = false;
                else if (0 > int.Parse(tbxs[i].Text) || int.Parse(tbxs[i].Text) > 36) alltGrönt = false;
            }


            if (alltGrönt)
            {
                dragningar = int.Parse(tbxDragningar.Text);
                for (int i = 0; i < inskrivnaNummer.Length; i++)
                {
                    inskrivnaNummer[i] = int.Parse(tbxs[i].Text);
                }
                lottorad = new Lottorad(inskrivnaNummer);
                Spel nyttspel = new Spel(dragningar, lottorad);
                spelomgångar.Add(nyttspel);

                lblResultat.Content = nyttspel.antalLika.ToString();
            }
            else MessageBox.Show("Något är tokigt, prova igen");
        }

        private void btnKör_Click(object sender, RoutedEventArgs e)
        {
            Kör();
        }

        /*
* Ludwig projekt
pseudokod
Lotteri

Lotteriet ska ta in 7 tal, dra slumpvis lottrader ett antal dragningar och sedan kolla om den matchar med det inskrivna

// Returnerar true om num är ett nummer
public bool IsNumber(int num)
{
return int.TryParse(num, out int bla)
}

alltGrönt = true
för alla textboxar, 
kolla värde, om IsNumber är false ändra alltGrönt till false

Kör för alla textboxar, ändra alltGrönt till false om i inte är under 36 eller över 0

om alltGrönt
Spel nyttspel = new Spel(dragningar, inskriven lottorad)

textboxResultat.Text = nyttspel.antalLika.ToString()

Klass Spel(parti) 
// tar in dragningar och inskriven lottorad
{
public int antalLika = 0;
lista av lottorad-objekt
int dragningargjorda = 0
Lottorad skrivenLottorad = new Lottorad(inskriven lottorad)

while loop imedans dragningargjorda är    
mindre än dragningar
{
 lägg till i lista en ny lottorad med slumpade siffror
 dragningargjorda++;
}

void Metod som kollar antal rätt
för allt i listan av lottorader ( i )
{
  för 7 gånger ( j )
  {
         Kolla om skrivenrad[j] är samma nummer som lottorader[i][j]
         antalLika++;
  }
}
}

Klass Lottorad
{
Array av 7 tal
public Lottorad(Array av nummer = {0,0,0,0,0,0,0})
{
 Om array är nollad så skapa en ny rad med random nummer, annars överskriv klassens variabel för 7 tal
}

Metod som returnerar ett random tal mellan 0-35
}
*/
    }
}

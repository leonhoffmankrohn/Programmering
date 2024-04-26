using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SänkaSkepp_Host
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    /*
     * Låta hosten göra sin spelplan
     * När klienten ansluter börjar hosten sitt första drag
     * draget evalureras och skickas till klienten
     * klienten skickar sitt drag och det evalueras på hosten och skickas tillbaka
     */
    public partial class MainWindow : Window
    {
        Button[,] youBoard = new Button[10, 10];
        public MainWindow()
        {
            InitializeComponent();
            WrapPanel[] rows = new WrapPanel[10];
            for (int i = 0; i < 10; i++)
            {
                rows[i] = new WrapPanel();
                stcPanelYouBoard.Children.Add(rows[i]);
            }
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    youBoard[k, j] = new Button()
                    {
                        Width = 30,
                        Height = 30,
                        Background = Brushes.Aqua,
                        BorderThickness = new Thickness(0)
                    };
                    youBoard[k, j].Click += YouBoard_Click;
                    rows[j].Children.Add(youBoard[k, j]);
                }
            }
        }

        private void YouBoard_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int[] indecies = FindIndex(youBoard, (sender as Button));
                int length = (int)sliShipLength.Value;
                if (chcBoxHorisontal.IsChecked == true)
                {
                    for (int i = 0; i < length; i++)
                    {
                        youBoard[indecies[0] +i , indecies[1]].Background = Brushes.Black;
                    }
                }
                if (chcBoxHorisontal.IsChecked == false)
                {
                    for (int i = 0; i < length; i++)
                    {
                        youBoard[indecies[0], indecies[1] + i].Background = Brushes.Black;
                    }
                }

            }
            catch { Console.WriteLine("Try placing some other place"); }
        }


        int[] FindIndex(object[,] array, object obj)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == obj)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
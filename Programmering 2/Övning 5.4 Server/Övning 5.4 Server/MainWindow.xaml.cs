using System.Net;
using System.Net.Sockets;
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

namespace Övning_5._4_Server
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TcpClient klient;
        public MainWindow()
        {
            InitializeComponent();
            Initiation();
        }

        int[] avatarMargin = [0,0,0,0];
        int marginStep = 20;

        public enum Riktning
        {
            Upp,
            Vänster,
            Höger,
            Ner,
        }

        async void Initiation()
        {
            IPEndPoint lyssnarEndpoint = new IPEndPoint(IPAddress.Any, 12345);
            TcpListener tcpListener = new TcpListener(lyssnarEndpoint);
            tcpListener.Start();
            klient = await tcpListener.AcceptTcpClientAsync();
            Rörelse();
        }

        async void Rörelse()
        {
            try
            {
                byte[] indata = new byte[8];
                int antalbyte = await klient.GetStream().ReadAsync(indata, 0, indata.Length);
                string data = Encoding.Unicode.GetString(indata, 0, antalbyte);
                int.TryParse(data, out int movement);
                Riktning riktning = (Riktning)movement;

                switch (riktning)
                {
                    case Riktning.Upp:
                        Upp(); break;

                    case Riktning.Vänster :
                        Vänster(); break;

                    case Riktning.Höger :
                        Höger(); break;

                    case Riktning.Ner :
                        Ner(); break;

                    default: break;
                }
                Rörelse();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        void UpdateMargins()
        {
            imgAvatar.Margin = new Thickness(avatarMargin[0], avatarMargin[1], avatarMargin[2], avatarMargin[3]);
        }

        void Upp()
        {
            avatarMargin[3] += marginStep;
            UpdateMargins();
        }
        void Vänster()
        {
            avatarMargin[2] += marginStep;
            UpdateMargins();
        }
        void Höger()
        {
            avatarMargin[0] += marginStep;
            UpdateMargins();
        }
        void Ner()
        {
            avatarMargin[1] += marginStep;
            UpdateMargins();
        }
    }
}
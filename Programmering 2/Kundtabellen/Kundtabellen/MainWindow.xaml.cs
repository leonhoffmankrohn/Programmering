using System.Text;
using System.Windows;
using System.Data.SqlClient;

namespace Kundtabellen
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

        private void btnSök_Click(object sender, RoutedEventArgs e)
        {
            // Använd connection string till output-filen i bin\debug\
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Programmering\Programmering 2\Kundtabellen\Kundtabellen\KundregisterDB.mdf;Integrated Security=True";
            // Hårdkodad sökfråga
            string personnummer = tbxPersonnummer.Text;
            string query = "SELECT Förnamn, Efternamn FROM Kunder WHERE PersonNr=" + personnummer;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string fn = reader.GetString(0);
                        string en = reader.GetString(1);

                        tbxResultat.AppendText(fn + " " + en + "\r\n");
                    }
                    reader.Close();
                }
            }
        }
    }
}
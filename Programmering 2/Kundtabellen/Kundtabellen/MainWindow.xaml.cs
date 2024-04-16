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

            string query = tbxQuery.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (query.Substring(0,3) == "SEL")
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                tbxResultat.AppendText(reader.GetString(i) + " ");
                            }
                            tbxResultat.AppendText("\r\n");
                        }
                        reader.Close();
                    }
                    else command.ExecuteNonQuery();
                }
            }
        }
    }
}
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

namespace HoffQuiz
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
        List<User> users = new List<User>();
        List<Quiz> quizzes = new List<Quiz>();

        private void UpdateCreationInterface()
        {
            
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            quizzes.Add(new Quiz("Hoff Test 1"));
            quizzes[0].NewSimQ(stackCreate);
        }

        private void tabQuizCreate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Hej");
        }
    }
}

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
        int creationIndex = -1;

        private void UpdateCreationInterface()
        {
            
        }
        private void tabQuizCreate_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            quizzes.Add(new Quiz());
        }

        private void btnNewSimQ_Click(object sender, RoutedEventArgs e)
        {
            quizzes[creationIndex].NewSimQ(stackCreate);
        }

        private void btnNewMultQ_Click(object sender, RoutedEventArgs e)
        {
            quizzes[creationIndex].NewMultQ(stackCreate);
        }

        private void btnNewPicQ_Click(object sender, RoutedEventArgs e)
        {
            quizzes[creationIndex].NewPicQ(stackCreate);
        }

        private void btnNewMathQ_Click(object sender, RoutedEventArgs e)
        {
            quizzes[creationIndex].NewMathQ(stackCreate);

        }
    }
}

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
        // List<User> users = new List<User>();
        List<Quiz> quizzes = new List<Quiz>();
        int creationIndex = -1;

        private void UpdateCreationInterface()
        {
            quizzes[creationIndex].Render(stackCreate);
        }

        private void UpdateQuizListView()
        {
            lviewQuizzes.ItemsSource = null;
            lviewQuizzes.ItemsSource = quizzes;
        }

        private void btnNewSimQ_Click(object sender, RoutedEventArgs e)
        {

            quizzes[creationIndex].NewSimQ();
            UpdateCreationInterface();
        }

        private void btnNewMultQ_Click(object sender, RoutedEventArgs e)
        {
            quizzes[creationIndex].NewMultQ();
            UpdateCreationInterface();

        }

        private void btnNewPicQ_Click(object sender, RoutedEventArgs e)
        {
            quizzes[creationIndex].NewPicQ();
            UpdateCreationInterface();

        }

        private void btnNewMathQ_Click(object sender, RoutedEventArgs e)
        {
            quizzes[creationIndex].NewMathQ();
            UpdateCreationInterface();
        }

        private void btnNewQuiz_Click(object sender, RoutedEventArgs e)
        {
            quizzes.Add(new Quiz(tbxQuizName.Text));
            creationIndex++;
            quizzes[creationIndex].Render(stackCreate);
            btnNewSimQ.IsEnabled = true;
            btnNewMultQ.IsEnabled = true;
            btnNewPicQ.IsEnabled = true;
            btnNewMathQ.IsEnabled = true;
            if (creationIndex > 0) btnPreviousQuiz.IsEnabled = true;
            UpdateQuizListView();
        }

        private void btnPreviousQuiz_Click(object sender, RoutedEventArgs e)
        {
            creationIndex--;
            if (creationIndex == 0) btnPreviousQuiz.IsEnabled = false;
            quizzes[creationIndex].Render(stackCreate);
        }
    }
}

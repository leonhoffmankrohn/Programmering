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
            quizzes[creationIndex].RenderEdit(stackCreate);
        }

        private void ResetCreationInterface()
        {
            creationIndex = -1;
            stackCreate.Children.Clear();
            tbxQuizName.Text = "Quizname";
            btnNewSimQ.IsEnabled = false;
            btnNewMultQ.IsEnabled = false;
            btnNewPicQ.IsEnabled = false;
            btnNewMathQ.IsEnabled = false;
        }

        private void UpdateQuizListView()
        {
            lviewQuizzes.ItemsSource = null;
            lviewQuizzes.ItemsSource = quizzes;
        }


        private void btnNewQuiz_Click(object sender, RoutedEventArgs e)
        {
            quizzes.Add(new Quiz(tbxQuizName.Text));
            creationIndex++;
            btnNewSimQ.IsEnabled = true;
            btnNewMultQ.IsEnabled = true;
            btnNewPicQ.IsEnabled = true;
            btnNewMathQ.IsEnabled = true;
            if (creationIndex > 0) btnPreviousQuiz.IsEnabled = true;
            UpdateCreationInterface();
            UpdateQuizListView();
        }

        private void btnPreviousQuiz_Click(object sender, RoutedEventArgs e)
        {
            creationIndex--;
            if (creationIndex == 0) btnPreviousQuiz.IsEnabled = false;
            quizzes[creationIndex].RenderEdit(stackCreate);
        }

        private void btnStartQuiz_Click(object sender, RoutedEventArgs e)
        {
            stackCreate.Children.Clear();
            quizzes[lviewQuizzes.SelectedIndex].SaveAnswers();
            quizzes[lviewQuizzes.SelectedIndex].RenderQuiz(stackQuiz);
            tabQuiz.IsEnabled = true;
            tabQuiz.IsSelected = true;
            tabQuizCreate.IsEnabled = false;
            tabStart.IsEnabled = false;
        }

        private void btnDeleteQuiz_Click(object sender, RoutedEventArgs e)
        {
            if (lviewQuizzes.SelectedIndex != -1) 
            { 
                quizzes.RemoveAt(lviewQuizzes.SelectedIndex);
                ResetCreationInterface();
                UpdateQuizListView();
            }
        }
        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            int nrCorrects = quizzes[lviewQuizzes.SelectedIndex].QuizEnd();
            tabInfo.Header = "Hoffman:: HS: " + nrCorrects + " HoffPoints";
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

    }
}

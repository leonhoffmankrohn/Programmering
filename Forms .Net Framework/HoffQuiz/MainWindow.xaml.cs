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

        // Updates the create quiz interface with a method from the class at specified(creationindex) index in to a stackbox(stackCreate)
        private void UpdateCreationInterface()
        {
            quizzes[creationIndex].RenderEdit(stackCreate);
        }

        // Resets the creationpage to a null value both in mind and visible values.
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

        // Updates the list which shows the different quizzes that have been made
        private void UpdateQuizListView()
        {
            lviewQuizzes.ItemsSource = null;
            lviewQuizzes.ItemsSource = quizzes;
        }

        // Starts the creation of a new quiz, also setting the environment
        private void NewQuiz()
        {
            quizzes.Add(new Quiz(tbxQuizName.Text));
            creationIndex++;
            btnNewSimQ.IsEnabled = true;
            btnNewMultQ.IsEnabled = true;
            btnNewPicQ.IsEnabled = true;
            btnNewMathQ.IsEnabled = true;
            UpdateCreationInterface();
            UpdateQuizListView();
        }

        // Change the visuals to the quizpage where a player does the quiz
        private void StartQuiz()
        {
            stackCreate.Children.Clear();
            quizzes[lviewQuizzes.SelectedIndex].SaveAnswers();
            quizzes[lviewQuizzes.SelectedIndex].RenderQuiz(stackQuiz);
            tabQuiz.IsEnabled = true;
            tabQuiz.IsSelected = true;
            tabQuizCreate.IsEnabled = false;
            tabStart.IsEnabled = false;
        }

        // Deletes selected quiz in lViewQuizzes
        private void DeleteQuiz()
        {
            
            if (lviewQuizzes.SelectedIndex != -1)
            {
                quizzes.RemoveAt(lviewQuizzes.SelectedIndex);
                ResetCreationInterface();
                UpdateQuizListView();
            }
        }

        // Ends the quiz and calculate the score.
        private void EndQuiz()
        {
            int nrCorrects = quizzes[lviewQuizzes.SelectedIndex].QuizEnd();
            tabInfo.Header = "Hoffman:: HS: " + nrCorrects + " HoffPoints";
        }

        private void btnNewQuiz_Click(object sender, RoutedEventArgs e)
        {
            NewQuiz();
        }

        private void btnStartQuiz_Click(object sender, RoutedEventArgs e)
        {
            StartQuiz();
        }

        private void btnDeleteQuiz_Click(object sender, RoutedEventArgs e)
        {
            DeleteQuiz();
        }
        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            EndQuiz();
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

using System;
using System.Collections.Generic;
using System.Configuration;
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
        List<User> users = new();
        List<Quiz> quizzes = new List<Quiz>();
        int creationIndex = -1;
        public MainWindow()
        {
            InitializeComponent();
            users.Add(new User("Player 1"));
            users.Add(new User("Player 2"));
            users.Add(new User("Player 3"));
            users.Add(new User("Player 4"));
        }

        // Renderar ett quiz till en stackbox, för att skapa eller redigera.
        private void UpdateCreationInterface()
        {
            quizzes[creationIndex].RenderEdit(stackCreate);
        }

        // Resettar skapandetabben till ursprung/nollställd ny
        private void ResetCreationInterface()
        {
            creationIndex = quizzes.Count;
            stackCreate.Children.Clear();
            tbxQuizName.Text = "Quizname";
            btnNewSimQ.IsEnabled = false;
            btnNewMultQ.IsEnabled = false;
            btnNewPicQ.IsEnabled = false;
            btnNewMathQ.IsEnabled = false;
        }

        // Updaterar listan med de olika quizzen att välja
        private void UpdateQuizListView()
        {
            lviewQuizzes.ItemsSource = null;
            lviewQuizzes.ItemsSource = quizzes;
        }

        // Startar skapandet/redigeringen av ett quiz och sätter miljön för skapande.
        private void NewQuiz()
        {
            if (creationIndex == -1)
            {
                quizzes.Add(new Quiz(tbxQuizName.Text, users[cbxUser.SelectedIndex].Username));
                creationIndex = quizzes.Count-1;
            }
            btnNewSimQ.IsEnabled = true;
            btnNewMultQ.IsEnabled = true;
            btnNewPicQ.IsEnabled = true;
            btnNewMathQ.IsEnabled = true;
            tabQuizCreate.IsSelected = true;
            UpdateCreationInterface();
            UpdateQuizListView();
        }

        // Ändrar visuellt så att spelaren ser quizzet och kan utföra det på den tabben
        private void StartQuiz()
        {
            stackCreate.Children.Clear();
            Quiz currentQuiz = quizzes[lviewQuizzes.SelectedIndex];
            currentQuiz.SetMode(Mode.Answer);
            currentQuiz.RenderQuiz(stackQuiz);
            creationIndex = -1;
            tabQuiz.IsEnabled = true;
            tabQuiz.IsSelected = true;
            tabQuizCreate.IsEnabled = false;
            tabStart.IsEnabled = false;
        }

        // Skriver ut hur mycket poäng man fick och avslutar quizzet
        private void EndQuiz()
        {
            int score = quizzes[lviewQuizzes.SelectedIndex].CountCorrect();
            if (score != 0) MessageBox.Show("You've got " + score + " answers right. Congratulations!");
            else MessageBox.Show("No answers right, better luck next time!");
            users[cbxUser.SelectedIndex].AddScore(score, lviewQuizzes.SelectedIndex);
            tabInfo.Header = users[cbxUser.SelectedIndex].Username + " - HighScore: " + users[cbxUser.SelectedIndex] + " corrects";
            tabStart.IsSelected = true;
            tabQuiz.IsEnabled = false;
            tabQuizCreate.IsEnabled = true;
            tabStart.IsEnabled = true;
        }

        // Tar bort selekterad i lViewQuizzes
        private void DeleteQuiz()
        {
            if (lviewQuizzes.SelectedIndex != -1)
            {
                quizzes.RemoveAt(lviewQuizzes.SelectedIndex);
                ResetCreationInterface();
                UpdateQuizListView();
            }
        }

        // -- Här nedan anropas respektive metod för respektive knapp. --
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

        private void btnQuizEnd_Click(object sender, RoutedEventArgs e)
        {
            EndQuiz();
        }

        // Startar om quizzet
        private void btnTryAgain_Click(object sender, RoutedEventArgs e)
        {
            StartQuiz();
        }

        private void btnEditQuiz_Click(object sender, RoutedEventArgs e)
        {
            creationIndex = lviewQuizzes.SelectedIndex;
            quizzes[creationIndex].SetMode(Mode.Default);
            NewQuiz();
        }

        private void cbxUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxUser.IsEnabled)
            { 
                tabInfo.Header = users[cbxUser.SelectedIndex].Username + " - HighScore: " + 0 + " Corrects"; 
                ResetCreationInterface();
            }
            else cbxUser.IsEnabled = true;
        }
    }
}

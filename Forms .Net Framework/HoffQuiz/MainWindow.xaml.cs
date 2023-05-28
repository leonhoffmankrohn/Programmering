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

            // Skapar 4 nya spelare vid start av programmet
            users.Add(new User("Player 1"));
            users.Add(new User("Player 2"));
            users.Add(new User("Player 3"));
            users.Add(new User("Player 4"));
        }

        // Renderar ett quiz till en stackbox för att skapa
        private void UpdateCreationInterface()
        {
            UpdateQuizListView();
            stackQuiz.Children.Clear();
            quizzes[creationIndex].RenderEdit(stackCreate);
        }

        // Resettar skapandetabben till ursprung/nollställd ny
        private void ResetCreationInterface()
        {
            stackCreate.Children.Clear();
            tbxQuizName.Text = "Name New Quiz";
            btnNewSimQ.IsEnabled = false;
            btnNewMultQ.IsEnabled = false;
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
            if (creationIndex == -1 && tbxQuizName.Text != "")
            {
                foreach (User user in users) user.Highscore.Add(new());
                quizzes.Add(new Quiz(tbxQuizName.Text, users[cbxUser.SelectedIndex].Username));
                creationIndex = quizzes.Count - 1;
                btnNewSimQ.IsEnabled = true;
                btnNewMultQ.IsEnabled = true;
                tabQuizCreate.IsSelected = true;
                UpdateCreationInterface();
            }
            else if (tbxQuizName.Text == "") MessageBox.Show("Please enter a name for the new quiz!");
            else
            {
                btnNewSimQ.IsEnabled = true;
                btnNewMultQ.IsEnabled = true;
                tabQuizCreate.IsSelected = true;
                UpdateCreationInterface();
            }
        }

        // Ändrar visuellt så att spelaren ser quizzet och kan utföra det på den tabben
        private void StartQuiz()
        {
            if(lviewQuizzes.SelectedIndex != -1)
            {
                stackCreate.Children.Clear();
                Quiz currentQuiz = quizzes[lviewQuizzes.SelectedIndex];
                currentQuiz.SetMode(Mode.Answer);
                currentQuiz.RenderQuiz(stackQuiz);
                tabQuiz.IsEnabled = true;
                tabQuiz.IsSelected = true;
                tabQuizCreate.IsEnabled = false;
                tabStart.IsEnabled = false;
            }
        }

        // Skriver ut hur mycket poäng man fick och avslutar quizzet
        private void EndQuiz()
        {
            int score = quizzes[lviewQuizzes.SelectedIndex].CountCorrect();
            users[cbxUser.SelectedIndex].AddScore(score, lviewQuizzes.SelectedIndex);
            if (score != 0)
            {
                if (score >= users[cbxUser.SelectedIndex].Highscore[lviewQuizzes.SelectedIndex]) MessageBox.Show("You've got " + score + " answers right. Highscore!");
                else MessageBox.Show("You've got " + score + " answers right. Try beating your personal record of " + users[cbxUser.SelectedIndex].Highscore[lviewQuizzes.SelectedIndex] + " !");
            }
            else MessageBox.Show("No answers right, better luck next time!");
            tabInfo.Header = users[cbxUser.SelectedIndex].Username + " - HighScore: " + users[cbxUser.SelectedIndex].Highscore[lviewQuizzes.SelectedIndex] + " corrects";
            quizzes[lviewQuizzes.SelectedIndex].SetMode(Mode.Default);
            tabStart.IsSelected = true;
            tabQuiz.IsEnabled = false;
            tabQuizCreate.IsEnabled = true;
            tabStart.IsEnabled = true;
            creationIndex = -1;
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

        // Skapar ett nytt quiz
        private void btnNewQuiz_Click(object sender, RoutedEventArgs e)
        {
            creationIndex = -1;
            NewQuiz();
        }

        // Startar quiz
        private void btnStartQuiz_Click(object sender, RoutedEventArgs e)
        {
            StartQuiz();
        }

        // Tar bort ett markerat quiz i listan med quizzes
        private void btnDeleteQuiz_Click(object sender, RoutedEventArgs e)
        {
            DeleteQuiz();
        }

        // Skapar en ny simpel fråga och uppdaterar tabben bla..
        private void btnNewSimQ_Click(object sender, RoutedEventArgs e)
        {
            quizzes[creationIndex].NewSimQ();
            UpdateCreationInterface();
        }

        // Skapar ny alternativfråga och updaterar tabben bla..
        private void btnNewMultQ_Click(object sender, RoutedEventArgs e)
        {
            quizzes[creationIndex].NewMultQ();
            UpdateCreationInterface();
        }

        // Avslutar quizzet
        private void btnQuizEnd_Click(object sender, RoutedEventArgs e)
        {
            EndQuiz();
        }

        // Startar om quizzet
        private void btnTryAgain_Click(object sender, RoutedEventArgs e)
        {
            EndQuiz();
            StartQuiz();
        }

        // Redigerar ett redan skapat quiz utan att ändra skapare(author)
        private void btnEditQuiz_Click(object sender, RoutedEventArgs e)
        {
            creationIndex = lviewQuizzes.SelectedIndex;
            if(creationIndex != -1)
            {
                quizzes[creationIndex].SetMode(Mode.Default);
                NewQuiz();
            }
        }

        // När användare ändras sätts infotabben bla..
        private void cbxUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxUser.IsEnabled)
            { 
                tabInfo.Header = users[cbxUser.SelectedIndex].Username + " - HighScore: " + users[cbxUser.SelectedIndex].Highscore[lviewQuizzes.SelectedIndex] + " Corrects"; 
                ResetCreationInterface();
            }
            else cbxUser.IsEnabled = true;
        }

        // Snabbstarta quiz genom att dubbelklicka på det
        private void lviewQuizzes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            StartQuiz();
        }
    }
}

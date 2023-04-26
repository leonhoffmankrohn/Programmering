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
        User player = new User();
        List<Quiz> quizzes = new List<Quiz>();
        int creationIndex = -1;

        // Renderar ett quiz till en stackbox, för att skapa eller redigera.
        private void UpdateCreationInterface()
        {
            quizzes[creationIndex].RenderEdit(stackCreate);
        }

        // Resettar skapandetabben till ursprung/nollställd ny
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

        // Updaterar listan med de olika quizzen att välja
        private void UpdateQuizListView()
        {
            lviewQuizzes.ItemsSource = null;
            lviewQuizzes.ItemsSource = quizzes;
        }

        // Startar skapandet av quiz och sätter miljön för skapande.
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

        // Ändrar visuellt så att spelaren ser quizzet och kan utföra det på den tabben
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

        // Skriver ut hur mycket poäng man fick och avslutar quizzet
        private void btnQuizEnd_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You've got " + quizzes[lviewQuizzes.SelectedIndex].CountCorrect() + " answers right. Congratulations!");
            
        }

        // Räknar ut poäng och uppdaterar poängräknaren
        private void btnCorrect_Click(object sender, RoutedEventArgs e)
        {
            player.score += quizzes[lviewQuizzes.SelectedIndex].CountCorrect();
            tabInfo.Header = "Hoffman - Score: " + player.score + " HoffPoints";
        }
    }
}

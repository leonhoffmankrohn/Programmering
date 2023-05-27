using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HoffQuiz
{
    enum Mode {Answer, Default}
    
    class Quiz
    {
        public List<Question> Questions = new();
        string creator = "Hoffman";
        public Mode Mode = Mode.Default;
        public string Name { set; get; }
        public string QuestionsCount { get { return Questions.Count.ToString(); } }
        public string Creator { get { return creator; } }

        // Här skiftar vi Mode och ändrar också så att frågorna får tomma svarsrutor för spelaren att fylla i.
        // För MultipleChoiceQ sparas och ändras visuellt val samt i värdena.
        public void SetMode(Mode newmode)
        {
            Mode origin = Mode;
            if (origin != newmode)
            {
                Mode = newmode;
                switch (Mode)
                {
                    //Innan: Controls är svaren, spareControllers är de riktiga definitionerna
                    //Göra: Controls blir spareControllers(Definitioner), spareControlls blir nollade
                    case Mode.Default:
                        foreach (Question q in Questions)
                        {
                            q.Controls[0].IsEnabled = true;
                            if (q.Controls.Count() == 2)
                            {
                                for (int j = 1; j < q.Controls.Count(); j++)
                                {
                                    q.Controls[j] = q.spareControllers[j-1];
                                    q.spareControllers[j-1] = q.PlainControler();
                                }
                            }
                            else
                            {
                                for (int j = 1; j < q.Controls.Count(); j++)
                                {
                                    if (q.correctAnswers[j-1]) q.Controls[j].BorderThickness = new Thickness(5);
                                    else q.Controls[j].BorderThickness = new Thickness(1);
                                }
                                foreach (TextBox tbx in q.Controls) tbx.IsReadOnly = false;
                                q.mode = Mode.Default;
                            }
                        }
                        break;

                    // Innan: Controls är de riktiga svaren(Definitioner), spareControllers är nollad 
                    // Göra: Nolla Controls, spareControllers blir de riktiga svaren från Controls
                    case Mode.Answer:
                        foreach (Question q in Questions)
                        {
                            q.Controls[0].IsEnabled = false;
                            if (q.Controls.Count() == 2) 
                            {
                                for (int j = 1; j < q.Controls.Count(); j++)
                                {
                                    q.spareControllers[j - 1] = q.Controls[j];
                                    q.Controls[j] = q.PlainControler();
                                }
                            }
                            else
                            {
                                q.selectedAnswers = new() { false, false, false };
                                for (int j = 1; j < q.Controls.Count(); j++)
                                {
                                    q.Controls[j].BorderThickness = new Thickness(1);
                                }
                                foreach (TextBox tbx in q.Controls) tbx.IsReadOnly = true;
                                q.mode = Mode.Answer;
                            }
                        }
                        break;
                }
            }
        }

        public Quiz(string _name, string _creator)
        {
            Name = _name;
            creator = _creator;
        }
        public void NewSimQ()
        {
            Questions.Add(new Simple());
        }
        public void NewMultQ()
        {
            Questions.Add(new MultipleChoice());
        }

        //Resultatberäkningen, här överänsstämmer de skrivna svaren med rätta svaren.
        public int CountCorrect()
        {
            int nrCorrect = 0;
            
            foreach (Question q in Questions)
            {
                if (q.Controls.Count() == 2)
                {
                    nrCorrect += (q.Controls[1].Text == q.spareControllers[0].Text) ? 1 : 0;
                }
                else
                {
                    nrCorrect += (q.correctAnswers[0] == q.selectedAnswers[0] && q.correctAnswers[1] == q.selectedAnswers[1] && q.correctAnswers[2] == q.selectedAnswers[2]) ? 1 : 0;
                }
            }

            return nrCorrect;
        }

        // Renderar alla textboxar
        public void RenderEdit(StackPanel panel)
        {
            panel.Children.Clear();

            SetMode(Mode.Default);

            for (int i = 0; i < Questions.Count; i++)
            {
                for (int j = 0; j < Questions[i].Controls.Count(); j++)
                {
                    panel.Children.Add(Questions[i].Controls[j]);
                }
            }
        }

         // Renderar quizzet med slumpad ordning
        public void RenderQuiz(StackPanel panel)
        {
            panel.Children.Clear();

            List<Question> start = new List<Question> (Questions);
            List<Question> output = RandomateList(start);

            for (int i = 0; i < output.Count; i++)
            {
                for (int j = 0; j < output[i].Controls.Count(); j++)
                {
                    panel.Children.Add(output[i].Controls[j]);
                }
            }
        }

        // slumpar ordningen av vad man skickar in
        private List<Question> RandomateList(List<Question> input)
        {
            Random random = new Random();
            List<Question> result = new List<Question>();

            int loops = Questions.Count;
            for (int i = loops; i > 0; i--)
            {
                int randomNr = random.Next(i);
                result.Add(input[randomNr]);
                input.RemoveAt(randomNr);
            }
            return result;
        }
    }

    /* Här skapar vi en klass som stamm för frågorklassen, den kommer
     * bara innehålla generella variabler och funktioner och vi använder arv
     * för att vidare skapa olika typer av frågor.
    */
    class Question
    {
        public List<bool> correctAnswers = new List<bool>() { false, false, false };
        public List<bool> selectedAnswers = new List<bool>() { false, false, false };

        public Mode mode;
        public TextBox PlainControler()
        {
            return new TextBox
            {
                Padding = new Thickness(5),
                Margin = new Thickness(0, 5, 0, 20),
                Width = 450,
                Text = "",
                HorizontalAlignment = HorizontalAlignment.Center
            };
        }
        public TextBox DefinitionCopyController = new TextBox
            {
                Padding = new Thickness(5),
                Margin = new Thickness(0, 5, 0, 20),
                Width = 450,
                Text = "",
                HorizontalAlignment = HorizontalAlignment.Center
            };
        public List<TextBox> spareControllers;
        public TextBox[] Controls { get; set; }
        public virtual Control[] Initialize() { return new Control[] { new Control(), new Control() }; }
    }

    // En simpel fråga med ett svar härstammar från klassen Question
    class Simple : Question
    {
        public Simple()
        {
            Controls = Initialize();

            spareControllers = new List<TextBox>() { PlainControler() };
        }

        public override TextBox[] Initialize()
        {
            TextBox tbxPrompt = new TextBox
            {
                Padding = new Thickness(5),
                Margin = new Thickness(0, 20, 0, 5),
                Width = 500,
                Text = "Prompt",
                HorizontalAlignment = HorizontalAlignment.Center
            };
            TextBox tbxDefinition = new TextBox
            {
                Padding = new Thickness(5),
                Margin = new Thickness(0, 5, 0, 20),
                Width = 450,
                Text = "Definition",
                HorizontalAlignment = HorizontalAlignment.Center
            };
            
            return new TextBox[] { tbxPrompt, tbxDefinition };
        }
    }

    // En alternativfråga med en fråga och 3 olika alternativ, där du väljer själv vilka som är rätt
    class MultipleChoice : Question
    {
        public MultipleChoice()
        {
            mode = Mode.Default;
            Controls = Initialize();
        }

        // Sätter en definition för Controls
        public override TextBox[] Initialize()
        {
            TextBox tbxPrompt = new TextBox
            {
                Padding = new Thickness(5),
                Margin = new Thickness(0, 20, 0, 5),
                Width = 500,
                Text = "Prompt",
                HorizontalAlignment = HorizontalAlignment.Center
            };
            TextBox tbxDefinition1 = new TextBox
            {
                Padding = new Thickness(5),
                Margin = new Thickness(0, 5, 0, 5),
                Width = 450,
                Text = "Choice 1",
                HorizontalAlignment = HorizontalAlignment.Center
            };
            TextBox tbxDefinition2 = new TextBox
            {
                Padding = new Thickness(5),
                Margin = new Thickness(0, 5, 0, 5),
                Width = 450,
                Text = "Choice 2",
                HorizontalAlignment = HorizontalAlignment.Center
            };
            TextBox tbxDefinition3 = new TextBox
            {
                Padding = new Thickness(5),
                Margin = new Thickness(0, 5, 0, 20),
                Width = 450,
                Text = "Choice 3",
                HorizontalAlignment = HorizontalAlignment.Center
            };

            tbxDefinition1.MouseDoubleClick += def1Alternativ_down;
            tbxDefinition2.MouseDoubleClick += def2Alternativ_down;
            tbxDefinition3.MouseDoubleClick += def3Alternativ_down;

            return new TextBox[] { tbxPrompt, tbxDefinition1, tbxDefinition2, tbxDefinition3 };
        }

        // Dessa anropas när dubbeltryck sker på ett svarsalternativ som sedan "markerar" och sparar markerad i minnet
        private void def1Alternativ_down(object sender, System.Windows.Input.MouseButtonEventArgs e) { ChooseAnswered(1); }
        private void def2Alternativ_down(object sender, System.Windows.Input.MouseButtonEventArgs e) { ChooseAnswered(2); }
        private void def3Alternativ_down(object sender, System.Windows.Input.MouseButtonEventArgs e) { ChooseAnswered(3); }

        // Markerar med borderthickness och i minnet beroende på vad den var innan och om läget är svar(Mode.Answer) eller skapa(Mode.Default)
        private void ChooseAnswered(int index)
        {
            Control ctr = Controls[index];
            
            if ( mode == Mode.Answer)
            {
                if (ctr.BorderThickness == new Thickness(1))
                {
                    ctr.BorderThickness = new Thickness(5);
                    selectedAnswers[index - 1] = true;
                }
                else
                {
                    ctr.BorderThickness = new Thickness(1);
                    selectedAnswers[index - 1] = false;
                }
            }
            else
            {
                if (ctr.BorderThickness == new Thickness(1))
                {
                    ctr.BorderThickness = new Thickness(5);
                    correctAnswers[index - 1] = true;
                }
                else
                {
                    ctr.BorderThickness = new Thickness(1);
                    correctAnswers[index - 1] = false;
                }
            }
        }

    }
}

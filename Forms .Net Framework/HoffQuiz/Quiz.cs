using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
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

        // Ändrar controllers till frågorna så att när de renderas sä renderas de med rätt saker och inte visar svaret när det inte ska visas osv.
        public void SetMode(Mode newmode)
        {
            Mode origin = Mode;
            if (origin != newmode)
            {
                Mode = newmode;
                switch (Mode)
                {
                    // Ändrar tillbaka så att man kan ändra på frågor och svar.
                    case Mode.Default:
                        for (int i = 0; i < Questions.Count; i++)
                        {
                            Questions[i].Controls[1] = Questions[i].DefinitionCopyController;
                            Questions[i].Controls[0].IsEnabled = true;
                            Questions[i].DefinitionCopyController = new TextBox
                            {
                                Padding = new Thickness(5),
                                Margin = new Thickness(0, 5, 0, 20),
                                Width = 450,
                                Text = "",
                                HorizontalAlignment = HorizontalAlignment.Center
                            };
                        }
                        break;

                    // Kopierar definitionenskontrollern och 
                    case Mode.Answer:
                        for (int i = 0; i < Questions.Count; i++)
                        {
                            Control empty = Questions[i].DefinitionCopyController;
                            Questions[i].DefinitionCopyController = Questions[i].Controls[1];
                            Questions[i].Controls[0].IsEnabled = false;
                            Questions[i].Controls[1] = empty;
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

        //Resultatberäkningen, här överänsstämmer vi svaren med igentliga svaren.
        public int CountCorrect()
        {
            int nrCorrect = 0;
            for (int i = 0; i < Questions.Count; i++)
            {
                 if ((Questions[i].Controls[1].ToString()[30..].Length != 1) && (Questions[i].Controls[0].ToString()[30..].Length != 1 ))
                 if (Questions[i].DefinitionCopyController.ToString()[33..] == Questions[i].Controls[1].ToString()[33..]) nrCorrect++;
                
            }
            return nrCorrect;
        }

        // Renders in panel every question with a definition box for the user to fill in both questions and answers
        // Renderar rätt frågor och svar till skapandetabben
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

         // Renderar quizzet och ändrar kontrollerna, frågan till en label och svar till en tom textbox
        public void RenderQuiz(StackPanel panel)
        {
            panel.Children.Clear();

            List<Question> start = new List<Question> (Questions);
            List<Question> output = RandomateList(start);

            SetMode(Mode.Answer);

            for (int i = 0; i < output.Count; i++)
            {
                for (int j = 0; j < output[i].Controls.Count(); j++)
                {
                    panel.Children.Add(output[i].Controls[j]);
                }
            }
        }
        private List<Question> RandomateList(List<Question> input)
        {
            /* 
             * Slumpa ordningen av questions
             * input är den vanliga listan
             * output är en questions lista som är slumpad
             */
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
        // Här definerar vi virtuella och andra variabler
        public Control DefinitionCopyController = new TextBox
            {
                Padding = new Thickness(5),
                Margin = new Thickness(0, 5, 0, 20),
                Width = 450,
                Text = "",
                HorizontalAlignment = HorizontalAlignment.Center
            };
        public Control[] Controls { get; set; }
        public virtual Control[] Initialize() { return new Control[] { new Control(), new Control() }; }
    }

    class Simple : Question
    {
        public Simple()
        {
            Controls = Initialize();
        }

        // Här initierar vi kontrollerna för fråga och svar för att kunna spara värden i.
        public override Control[] Initialize()
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
            
            return new Control[] { tbxPrompt, tbxDefinition };
        }
    }
    class MultipleChoice : Question
    {
        public List<bool> correctAnswers = new List<bool>() { false, false, false };
        public MultipleChoice()
        {
            Controls = Initialize();
        }
        public override Control[] Initialize()
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

            return new Control[] { tbxPrompt, tbxDefinition1, tbxDefinition2, tbxDefinition3 };
        }

        private void def1Alternativ_down(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ChooseAnswered(1);
        }
        private void def2Alternativ_down(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ChooseAnswered(2);
        }
        private void def3Alternativ_down(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ChooseAnswered(3);
        }

        private void ChooseAnswered(int index)
        {
            Control ctr = Controls[index];
            if (ctr.BorderThickness == new Thickness(1))
            {
                ctr.BorderThickness = new Thickness(5);
                correctAnswers[index - 1] = true;
            }
            else
            {
                ctr.BorderThickness = new Thickness(1);
                correctAnswers[index-1] = false;
            }
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HoffQuiz
{
    class Quiz
    {
        public List<Question> Questions = new();
        string creator = "SuperUser";
        public string Name { set; get; }
        public string QuestionsCount { get { return Questions.Count.ToString(); } }
        public string Creator { get { return creator; } }

        public Quiz(string _name)
        {
            Name = _name;
        }
        public void NewSimQ()
        {
            Questions.Add(new Simple());
        }
        public void NewMultQ()
        {
            Questions.Add(new MultipleChoice());
        }
        public void NewPicQ()
        {
            Questions.Add(new PictureQ());
        }
        public void NewMathQ()
        {
            Questions.Add(new MathQ());
        }
        public int QuizEnd()
        {
            int nrCorrect = 0;
            for (int i = 0; i < Questions.Count; i++)
            {
                 //for (int j = 0; j < Questions[i].Answers.Count; j++)
                 if (Questions[i].Controls[1].ToString()[30..].Length != 1)
                 if (Questions[i].Answers[i] == Questions[i].Controls[1].ToString()[33..]) nrCorrect++;
                
            }
            return nrCorrect;
        }

        // Saves the answer for every question in the quiz
        public void SaveAnswers()
        {
            List<string> answers = new();
            for (int i = 0; i < Questions.Count; i++)
            {
                for (int j = 1; j < Questions[i].Controls.Count();j++)
                {
                    answers.Add(Questions[i].Controls[j].ToString()[33..]);
                }
                Questions[i].Answers = answers;
                Questions[i].ResetDefinitionBoxes();
            }
        }

        // Renders in panel every question with a definition box for the user to fill in both questions and answers
        public void RenderEdit(StackPanel panel)
        {
            panel.Children.Clear();
            for (int i = 0; i < Questions.Count; i++)
            {
                for (int j = 0; j < Questions[i].Controls.Count(); j++)
                {
                    panel.Children.Add(Questions[i].Controls[j]);
                }
            }
        }

         // Renders the quiz with saved controls; prompt as label and definition as empty textbox to panel
        public void RenderQuiz(StackPanel panel)
        {
            panel.Children.Clear();
            for (int i = 0; i < Questions.Count; i++)
            {
                string prompt = Questions[i].Controls[0].ToString();
                prompt = prompt[33..];
                Label lblPrompt = new Label
                {
                    Padding = new Thickness(5),
                    Margin = new Thickness(0, 20, 0, 5),
                    Width = 500,
                    Content = prompt,
                    HorizontalAlignment = HorizontalAlignment.Center
                };
                panel.Children.Add(lblPrompt);
                for (int j = 1; j < Questions[i].Controls.Count(); j++)
                {
                    panel.Children.Add(Questions[i].Controls[j]);
                }
            }
        }
    }

    // Here we create a class for question where we use legacy to create different types of questions. (Questions include answers)
    class Question
    {
        // Defining virtual and other variables
        public List<string> Answers { get; set; }
        public Control[] Controls { get; set; }
        public virtual Control[] Initialize() { return new Control[] { new Control(), new Control() }; }

        // Here we reset the definition(used after we saved answers), create a textbox in its place in the array. 
        public void ResetDefinitionBoxes()
        {
            for (int i = 1; i < Controls.Length; i++)
            {
                Controls[i] = new TextBox
                {
                    Padding = new Thickness(5),
                    Margin = new Thickness(0, 5, 0, 20),
                    Width = 450,
                    Text = "",
                    HorizontalAlignment = HorizontalAlignment.Center
                }; ;
            }
        }
    }

    class Simple : Question
    {
        public Simple()
        {
            Controls = Initialize();
        }

        // Here we initialize the textboxes for usage, we create the textboxes and store them
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
            return new Control[] { tbxPrompt, tbxDefinition1, tbxDefinition2, tbxDefinition3 };
        }
    }
    class PictureQ : Question
    {
        public PictureQ()
        {
            Initialize();
        }
        public override Control[] Initialize()
        {
            return new Control[] { new Control(), new Control() };
        }


    }
    class MathQ : Question
    {
        public MathQ()
        {
            Initialize();
        }
        public override Control[] Initialize()
        {
            return new Control[] { new Control(), new Control() };
        }
    }
}

using System;
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
        
        public void Render(StackPanel panel)
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
    }

    class Question
    {
        //Prompt
        //Definition
        public Control[] Controls { get; set; }
        public Control[] QuizControls { get; set; }
        public virtual Control[] Initialize() { return new Control[] { new Control(), new Control() }; }
        public virtual Control[] GetQuizControls(TextBox textbox) 
        { 
            return new Control[] {};
        }
    }

    class Simple : Question
    {
        public Simple()
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
        public override Control[] GetQuizControls(TextBox prompttbx)
        {
            Control[] controls = new Control[3];
            controls.Append(new Label
            {
                Content = prompttbx.Text,
                Padding = new Thickness(5),
                Margin = new Thickness(0, 20, 0, 5),
                Width = 500,
                HorizontalAlignment = HorizontalAlignment.Center
            });
            return controls;
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

using System;
using System.Collections.Generic;
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

        public Quiz()
        {
        }
        public void NewSimQ(StackPanel panel)
        {
            Questions.Add(new Simple(panel));
        }
        public void NewMultQ(StackPanel panel)
        {
            Questions.Add(new MultipleChoice(panel));
        }
        public void NewPicQ(StackPanel panel)
        {
            Questions.Add(new PictureQ(panel));
        }
        public void NewMathQ(StackPanel panel)
        {
            Questions.Add(new MathQ(panel));
        }

    }

    class Question
    {
        //Prompt
        //Definition

        public virtual void Initialize(StackPanel panel) { }
        public virtual void Save() { }
    }

    class Simple : Question
    {
        string prompt;
        string definition;

        public Simple(StackPanel _panel)
        {
            Initialize(_panel);
        }
        public override void Initialize(StackPanel panel)
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
                Width = 500,
                Text = "Definition",
                HorizontalAlignment = HorizontalAlignment.Center
            };
            panel.Children.Add(tbxPrompt);
            panel.Children.Add(tbxDefinition);
        }

    }
    class MultipleChoice : Question
    {
        public MultipleChoice(StackPanel _panel)
        {
            Initialize(_panel);
        }
    }
    class PictureQ : Question
    {
        public PictureQ(StackPanel _panel)
        {
            Initialize(_panel);
        }
    }
    class MathQ : Question
    {
        public MathQ(StackPanel _panel)
        {
            Initialize(_panel);
        }
    }
}

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

        public string Name { get; set; }

        public Quiz(string _name)
        {
            Name = _name;
        }
        public void NewSimQ(StackPanel panel)
        {
            Questions.Add(new Simple(panel));
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
                Text = "Här kan du skriva lite dittan och dattan, test",
                HorizontalAlignment = HorizontalAlignment.Center
            };
            TextBox tbxDefinition = new TextBox
            {
                Padding = new Thickness(5),
                Margin = new Thickness(0, 5, 0, 20),
                Width = 500,
                Text = "Här kan du skriva lite dittan och dattan, test",
                HorizontalAlignment = HorizontalAlignment.Center
            };
            panel.Children.Add(tbxPrompt);
            panel.Children.Add(tbxDefinition);
        }

    }
    class MultipleChoice : Question
    {

    }
    class PictureQ : Question
    {

    }
    class MathQ : Question
    {

    }
}

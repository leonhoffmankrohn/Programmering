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
        
        public void Render(StackPanel panel)
        {
            for (int i = 0; i < Questions.Count; i++)
            {
                panel.Children.Add(Questions[i])
            }
        }
    }

    class Question
    {
        //Prompt
        //Definition
        public virtual Control[] Initialize(StackPanel panel) { return new Control[] { new Control(), new Control() }; }
        public virtual void Save() { }
        public virtual void Load() { }
    }

    class Simple : Question
    {
        string prompt;
        string definition;
        Control[] controls;

        public Simple(StackPanel _panel)
        {
            controls = Initialize(_panel);
        }
        public override Control[] Initialize(StackPanel panel)
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
            panel.Children.Add(tbxPrompt);
            panel.Children.Add(tbxDefinition);
            return new Control[] { tbxPrompt, tbxPrompt };
        }

    }
    class MultipleChoice : Question
    {
        public MultipleChoice(StackPanel _panel)
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
            panel.Children.Add(tbxPrompt);
            panel.Children.Add(tbxDefinition1);
            panel.Children.Add(tbxDefinition2);
            panel.Children.Add(tbxDefinition3);
        }
    }
    class PictureQ : Question
    {
        public PictureQ(StackPanel _panel)
        {
            Initialize(_panel);
        }
        public override void Initialize(StackPanel panel)
        {
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

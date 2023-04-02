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

        List<TextBox> textBoxes = new();

        private void Reset()
        {
            for (int i = 0; i < textBoxes.Count; i++)
            {
                stackCreate.Children.Remove(textBoxes[i]);
            }
        }

        private void Update()
        {
            stackCreate.Children.Clear();
            for (int i = 0; i < textBoxes.Count; i++)
            {
                stackCreate.Children.Add(textBoxes[i]);
                if (i == 0) textBoxes[i].VerticalAlignment = VerticalAlignment.Center;

            }
        }

        private void CreateVisual()
        {
            TextBox textBox = new();
            textBox.Padding = new Thickness(5);
            textBox.Margin = new Thickness(0, 20, 0, 20);
            textBox.Width = 500;
            textBox.Text = "Här kan du skriva lite dittan och dattan, test";
            textBox.HorizontalAlignment = HorizontalAlignment.Center;

            textBoxes.Add(textBox);
        }


        private void Create()
        {
            CreateVisual();
            Update();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Create();
        }
    }
}

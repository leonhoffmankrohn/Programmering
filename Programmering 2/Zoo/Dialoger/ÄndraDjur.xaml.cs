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
using System.Windows.Shapes;

namespace Zoo.Dialoger
{
    /// <summary>
    /// Interaction logic for ÄndraDjur.xaml
    /// </summary>
    public partial class ÄndraDjur : Window
    {
        Djur djur; // djur att ändra
        internal ÄndraDjur(Djur _djurAttÄndra)
        {
            djur = _djurAttÄndra;
            InitializeComponent();
            Initition();
        }
        internal void Initition()
        {
            tbxNamn.Text = djur.Namn;
            tbxÅlder.Text = djur.Ålder.ToString();

            string[] köntyper = Enum.GetNames(typeof(KönTyp));
            foreach (string kön in köntyper)
            {
                lbxKön.Items.Add(kön);
            }
            lbxKön.SelectedItem = djur.Kön;

            

        }
    }
}

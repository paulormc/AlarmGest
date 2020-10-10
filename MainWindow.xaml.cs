using AlarmGest.Janelas;
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

namespace AlarmGest
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


        private void MenuHomeSelecionado(object sender, MouseButtonEventArgs e)
        {

        }
        private void MenuClientesSelecionado(object sender, MouseButtonEventArgs e)
        {

        }
        private void MenuObrasSelecionado(object sender, MouseButtonEventArgs e)
        {

        }
        private void MenuAdminsitracaoSelecionado(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new JanAdministracao();
        }




    }
}

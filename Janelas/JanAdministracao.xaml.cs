using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using AlarmGest.Global;

namespace AlarmGest.Janelas
{
    /// <summary>
    /// Interaction logic for JanAdministracao.xaml
    /// </summary>
    public partial class JanAdministracao : Page
    {
        BackgroundWorker bgWorkerExport;

        Excel_Clientes excel;
        string filepath; // Caminho do excel

        public JanAdministracao()
        {
            InitializeComponent();
        }

        private void ImportarDBCliente_Click(object sender, MouseButtonEventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();

            if(file.ShowDialog() == false) return;
            filepath = file.FileName;

            // Inicia processos
            bgWorkerExport = new BackgroundWorker();
            bgWorkerExport.WorkerReportsProgress = true;
            bgWorkerExport.DoWork += Export_DoWork;
            bgWorkerExport.RunWorkerCompleted += Export_RunWorkerCompleted;
            bgWorkerExport.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Export_ProgressChanged);
            bgWorkerExport.WorkerSupportsCancellation = true;

            bgWorkerExport.RunWorkerAsync();
            
        }

        private void Export_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarAtualizaClientes.Value = e.ProgressPercentage;
        }

        private void Export_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Export_DoWork(object sender, DoWorkEventArgs e)
        {
            excel = new Excel_Clientes(filepath);
            var tabela = excel.ObterLista();
            

        }

        private void cancelarAtualizaClientes_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void ImportarCartoesSIM(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

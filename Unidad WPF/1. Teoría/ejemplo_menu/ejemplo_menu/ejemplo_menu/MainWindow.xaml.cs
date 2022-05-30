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
using System.Threading;
using System.Windows.Shapes;

namespace ejemplo_menu
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mArchivoSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnFacturar_Click(object sender, RoutedEventArgs e)
        {
            int registros = 300;

            pbCargando.Maximum = 300;
            pbCargando.Value = 0;

            for(int i=0;i < registros;i++)
            {
                pbCargando.Value++;
            }
        }

        private void cmHolaElena_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola Elena");

            Close();
        }
    }
}

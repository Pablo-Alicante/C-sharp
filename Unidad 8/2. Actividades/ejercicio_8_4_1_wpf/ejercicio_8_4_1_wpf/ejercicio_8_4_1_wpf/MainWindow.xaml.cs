using System;
using System.IO;
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

namespace ejercicio_8_4_1_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StreamWriter fichero;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            fichero = new StreamWriter("log.txt", true);
        }

        private void mainWindow_Closed(object sender, EventArgs e)
        {
            fichero.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            fichero.WriteLine(txtFrase.Text);
        }

        //Si el usuario pulsa la tecla Enter, la sesión acabará.
        private void txtFrase_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Close();
            }
        }
    }
}

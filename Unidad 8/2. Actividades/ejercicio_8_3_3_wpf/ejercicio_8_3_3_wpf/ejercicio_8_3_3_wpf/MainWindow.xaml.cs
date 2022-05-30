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

namespace ejercicio_8_3_3_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StreamReader fichero;
        string linea;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            fichero = new StreamReader("fichero.txt");
        }
        private void mainWindow_Closed(object sender, EventArgs e)
        {
            fichero.Close();
        }

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            do
            {
                if(e.Key == Key.Enter)
                {
                    linea = fichero.ReadLine();

                    if (linea != null)
                        MessageBox.Show(linea);
                }
            }
            while (linea != null);

            fichero.Close();
        }
    }
}

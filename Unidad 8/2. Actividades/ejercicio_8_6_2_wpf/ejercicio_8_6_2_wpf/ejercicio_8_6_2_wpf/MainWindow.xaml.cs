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

namespace ejercicio_8_6_2_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StreamReader fichero;
        string linea;
        bool cerrarPrograma = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists("fichero.txt"))
                fichero = File.OpenText("fichero.txt");

            else
            {
                MessageBox.Show("El fichero no existe",
                                "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);

                Close();
            }
        }

        private void mainWindow_Closed(object sender, EventArgs e)
        {
            if (File.Exists("fichero.txt"))
                fichero.Close();
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            if (txtOrden.Text == "fin")
                Close();

            if (txtOrden.Text == "leer")
            {
                do
                {
                    linea = fichero.ReadLine();

                    if (linea != null)
                        MessageBox.Show(linea);
                }
                while (linea != null);
            }
        }
    }
}

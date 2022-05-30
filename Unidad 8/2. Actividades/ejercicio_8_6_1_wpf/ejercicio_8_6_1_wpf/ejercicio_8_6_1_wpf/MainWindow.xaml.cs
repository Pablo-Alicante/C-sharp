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

namespace ejercicio_8_6_1_wpf
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
            /*Primero se comprueba si existe el archivo. En caso de que exista,
             leerá todas las líneas que componen el fichero; de lo contrario,
            mostrará un mensaje de error en el que se comunica que no se ha podido
            encontrar el archivo.*/

            if(File.Exists("fichero.txt"))
            {
                fichero = File.OpenText("fichero.txt");

                do
                {
                    linea = fichero.ReadLine();

                    if (linea != null)
                        MessageBox.Show(linea);
                }
                while (linea != null);
            }
            else
            {
                MessageBox.Show("El archivo que desea abrir no existe.",
                                "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);

                Close();
            }
        }

        private void mainWindow_Closed(object sender, EventArgs e)
        {
            if(File.Exists("fichero.txt"))
                fichero.Close();
        }
    }
}

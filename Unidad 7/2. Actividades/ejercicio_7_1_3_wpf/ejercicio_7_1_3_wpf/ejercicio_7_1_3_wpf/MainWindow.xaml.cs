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

namespace ejercicio_7_1_3_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Menu menu;
        public MainWindow()
        {
            InitializeComponent();
            menu = new Menu();

            txtNombreFichero.IsEnabled = false;
            txtTamanoFichero.IsEnabled = false;
            txtBuscar.IsEnabled = false;
            btnGuardar.IsEnabled = false;
            btnMostrarNombres.IsEnabled = false;
            btnMostrarTodo.IsEnabled = false;
            btnBuscar.IsEnabled = false;
        }

        private void rbAnadirFichero_Checked(object sender, RoutedEventArgs e)
        {
            txtNombreFichero.IsEnabled = true;
            txtTamanoFichero.IsEnabled = true;
            btnGuardar.IsEnabled = true;
        }

        private void rbMostrarNombres_Checked(object sender, RoutedEventArgs e)
        {
            btnMostrarNombres.IsEnabled = true;
        }

        private void rbMostrarFicheros_Checked(object sender, RoutedEventArgs e)
        {
            btnMostrarTodo.IsEnabled = true;
        }

        private void rbBuscarFichero_Checked(object sender, RoutedEventArgs e)
        {
            txtBuscar.IsEnabled = true;
            btnBuscar.IsEnabled = true;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            menu.AnadirDatosNuevoFichero(txtNombreFichero.Text,Convert.ToInt32(txtTamanoFichero.Text));

            MessageBox.Show("Fichero guardado correctamente." +
                            "\nNombre del fichero: " + txtNombreFichero.Text +
                            "\nTamaño del fichero: " + txtTamanoFichero.Text,
                            "Información",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);

            Close();
        }

        private void btnMostrarNombres_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(menu.MostrarNombresFicheros());
        }
    }
}

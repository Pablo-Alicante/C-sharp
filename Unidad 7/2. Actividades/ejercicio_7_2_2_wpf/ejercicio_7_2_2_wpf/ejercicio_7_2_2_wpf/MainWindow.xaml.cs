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

namespace ejercicio_7_2_2_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Libro[] libro;

        public MainWindow()
        {

            InitializeComponent();
            libro = new Libro[1000];
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            int contadorLibros = 0;

            if (contadorLibros < 1000)
            {
                libro[contadorLibros] = new Libro();
                libro[contadorLibros].SetAutor(txtAutor.Text);
                libro[contadorLibros].SetTitulo(txtTitulo.Text);
                libro[contadorLibros].SetUbicacion(txtUbicacion.Text);

                contadorLibros++;

                MessageBox.Show("Libro guardado correctamente",
                                "Información",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No ha suficiente espacio para almacenar más libros.",
                                "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }

            Close();
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

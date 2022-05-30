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

namespace ejercicio_6_6_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Libro libro;
        Libro libro2;

        public MainWindow()
        {
            InitializeComponent();

            /*Inicializamos la variable y escribimos valores para los parámetros
             que definimos en el constructor. Esto lo hacemos para pemitir dar
            valores al autor, el título y la ubicación, tal y como lo indica 
            el ejercicio.*/

            libro = new Libro("Javier", "Libro de C#", "Estantería",123);
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            libro.SetAutor(txtAutor.Text);
            libro.SetTitulo(txtTitulo.Text);
            libro.SetUbicacion(txtUbicacion.Text);
            libro.SetPaginas(Convert.ToInt32(txtPaginas.Text));
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            /*El MessageBox muestra una ventana con la información referente al libro,
             que le hemos proporcionado cuando hemos inicializado la variable.*/

            MessageBox.Show("Autor: " + libro.GetAutor() +
                            "\nTítulo: " + libro.GetTitulo() +
                            "\nUbicación: " + libro.GetUbicacion() +
                            "\nNº páginas: " + libro.GetPaginas(),
                            "Libro",
                            MessageBoxButton.OK);

            Close();
        }
    }
}

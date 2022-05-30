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

namespace ejercicio_8_1_3_wpf
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

            txtAutor.IsEnabled = false;
            txtTitulo.IsEnabled = false;
            txtUbicacion.IsEnabled = false;
            txtPaginas.IsEnabled = false;
            btnGuardar.IsEnabled = false;
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            fichero = new StreamWriter("biblioteca.txt");
        }

        private void mainWindow_Closed(object sender, EventArgs e)
        {
            fichero.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            fichero.WriteLine(txtAutor.Text);
            txtAutor.Text = "";
            txtAutor.Focus();

            fichero.WriteLine(txtTitulo.Text);
            txtTitulo.Text = "";
            txtTitulo.Focus();

            fichero.WriteLine(txtUbicacion.Text);
            txtUbicacion.Text = "";
            txtUbicacion.Focus();

            fichero.WriteLine(txtPaginas.Text);
            txtPaginas.Text = "";
            txtPaginas.Focus();
        }

        private void rbDocumento_Checked(object sender, RoutedEventArgs e)
        {
            txtAutor.IsEnabled = true;
            txtTitulo.IsEnabled = true;
            txtUbicacion.IsEnabled = true;
            txtPaginas.IsEnabled = true;
            btnGuardar.IsEnabled = true;
        }

        private void rbLibro_Checked(object sender, RoutedEventArgs e)
        {
            txtAutor.IsEnabled = true;
            txtTitulo.IsEnabled = true;
            txtUbicacion.IsEnabled = true;
            btnGuardar.IsEnabled = true;
        }
    }
}

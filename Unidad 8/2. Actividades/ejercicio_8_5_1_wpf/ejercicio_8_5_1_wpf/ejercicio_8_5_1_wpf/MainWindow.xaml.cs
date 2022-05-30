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

namespace ejercicio_8_5_1_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nombreFichero = @"E:\Programación\Unidad 8\2. Actividades\ejercicio_8_5_1_wpf\ejercicio_8_5_1_wpf\ejercicio_8_5_1_wpf\bin\Debug\resultados\sumas.txt";
        StreamWriter fichero;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            fichero = new StreamWriter(nombreFichero, true);
        }

        private void mainWindow_Closed(object sender, EventArgs e)
        {
            fichero.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            int resultado = Convert.ToInt32(txtPrimerNumero.Text) + Convert.ToInt32(txtSegundoNumero.Text);

            fichero.WriteLine(txtPrimerNumero.Text + "+" + txtSegundoNumero.Text + "=" + resultado);

            MessageBox.Show(txtPrimerNumero.Text + "+" + txtSegundoNumero.Text + "=" + resultado,
                            "Resultado",
                            MessageBoxButton.OK);

            txtPrimerNumero.Text = "";
            txtPrimerNumero.Focus();

            txtSegundoNumero.Text = "";
            txtSegundoNumero.Focus();
        }
    }
}

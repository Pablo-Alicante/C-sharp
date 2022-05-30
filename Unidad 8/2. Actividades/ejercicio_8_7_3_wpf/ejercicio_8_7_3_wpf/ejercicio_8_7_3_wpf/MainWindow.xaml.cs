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

namespace ejercicio_8_7_3_wpf
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
            try
            {
                fichero = new StreamWriter("calculadora.txt", true);
            }
            catch (IOException)
            {
                MessageBox.Show("El fichero no se ha podido crear",
                                "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }

        private void mainWindow_Closed(object sender, EventArgs e)
        {
            fichero.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double resultado;

                switch (txtOperacion.Text)
                {
                    case "+":
                        resultado = Convert.ToDouble(txtPrimerNumero.Text) + Convert.ToDouble(txtSegundoNumero.Text);

                        fichero.WriteLine(txtPrimerNumero.Text + " " + txtOperacion.Text + " " +
                                          txtSegundoNumero.Text + " = " + resultado);

                        txtPrimerNumero.Text = "";
                        txtOperacion.Text = "";
                        txtSegundoNumero.Text = "";

                        txtPrimerNumero.Focus();
                        break;
                    case "-":
                        resultado = Convert.ToDouble(txtPrimerNumero.Text) - Convert.ToDouble(txtSegundoNumero.Text);

                        fichero.WriteLine(txtPrimerNumero.Text + " " + txtOperacion.Text + " " +
                                          txtSegundoNumero.Text + " = " + resultado);

                        txtPrimerNumero.Text = "";
                        txtOperacion.Text = "";
                        txtSegundoNumero.Text = "";

                        txtPrimerNumero.Focus();
                        break;
                    case "*":
                        resultado = Convert.ToDouble(txtPrimerNumero.Text) * Convert.ToDouble(txtSegundoNumero.Text);

                        fichero.WriteLine(txtPrimerNumero.Text + " " + txtOperacion.Text + " " +
                                          txtSegundoNumero.Text + " = " + resultado);

                        txtPrimerNumero.Text = "";
                        txtOperacion.Text = "";
                        txtSegundoNumero.Text = "";

                        txtPrimerNumero.Focus();
                        break;
                    case "/":
                        resultado = Convert.ToDouble(txtPrimerNumero.Text) / Convert.ToDouble(txtSegundoNumero.Text);

                        fichero.WriteLine(txtPrimerNumero.Text + " " + txtOperacion.Text + " " +
                                          txtSegundoNumero.Text + " = " + resultado);

                        txtPrimerNumero.Text = "";
                        txtOperacion.Text = "";
                        txtSegundoNumero.Text = "";

                        txtPrimerNumero.Focus();
                        break;
                    default:
                        MessageBox.Show("Por favor, introduzca un operador válido.",
                                        "Error",
                                        MessageBoxButton.OK,
                                        MessageBoxImage.Error);

                        txtOperacion.Text = "";
                        txtOperacion.Focus();
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, introduzca un dato numérico.",
                                "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }
    }
}

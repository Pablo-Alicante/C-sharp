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

namespace ejercicio_8_7_2_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double resultado;

                switch(txtOperacion.Text)
                {
                    case "+": 
                        resultado = Convert.ToDouble(txtPrimerNumero.Text) + Convert.ToDouble(txtSegundoNumero.Text);

                        MessageBox.Show(txtPrimerNumero.Text + " " + txtOperacion.Text + " " +
                                        txtSegundoNumero.Text + " =" + " " + resultado);

                        txtPrimerNumero.Text = "";
                        txtOperacion.Text = "";
                        txtSegundoNumero.Text = "";

                        txtPrimerNumero.Focus();
                        break;
                    case "-": 
                        resultado = Convert.ToDouble(txtPrimerNumero.Text) - Convert.ToDouble(txtSegundoNumero.Text);

                        MessageBox.Show(txtPrimerNumero.Text + " " + txtOperacion.Text + " " +
                                        txtSegundoNumero.Text + " =" + " " + resultado);

                        txtPrimerNumero.Text = "";
                        txtOperacion.Text = "";
                        txtSegundoNumero.Text = "";

                        txtPrimerNumero.Focus();
                        break;
                    case "*":
                        resultado = Convert.ToDouble(txtPrimerNumero.Text) * Convert.ToDouble(txtSegundoNumero.Text);

                        MessageBox.Show(txtPrimerNumero.Text + " " + txtOperacion.Text + " " +
                                        txtSegundoNumero.Text + " =" +" " + resultado);

                        txtPrimerNumero.Text = "";
                        txtOperacion.Text = "";
                        txtSegundoNumero.Text = "";

                        txtPrimerNumero.Focus();
                        break;
                    case "/": 
                        resultado = Convert.ToDouble(txtPrimerNumero.Text) / Convert.ToDouble(txtSegundoNumero.Text);

                        MessageBox.Show(txtPrimerNumero.Text + " " + txtOperacion.Text + " " +
                                        txtSegundoNumero.Text + " =" + " " + resultado);

                        txtPrimerNumero.Text = "";
                        txtOperacion.Text = "";
                        txtSegundoNumero.Text = "";

                        txtPrimerNumero.Focus();
                        break;
                    default:
                        MessageBox.Show("Operador desconocido. Introduzca un operador válido.",
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

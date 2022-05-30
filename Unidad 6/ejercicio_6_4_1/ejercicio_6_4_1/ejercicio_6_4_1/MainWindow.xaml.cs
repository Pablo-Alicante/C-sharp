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

namespace ejercicio_6_4_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Puerta puerta;
        Porton porton;

        public MainWindow()
        {
            InitializeComponent();

            puerta = new Puerta();
            porton = new Porton();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if(rbPuerta.IsChecked==true)
            {
                puerta.SetAncho(Convert.ToInt32(txtAncho.Text));
                puerta.SetAlto(Convert.ToInt32(txtAlto.Text));
                puerta.SetColor(Convert.ToInt32(txtColor.Text));
                puerta.SetAbierta(cbAbierta.IsChecked == true);
            }

            if(rbPorton.IsChecked==true)
            {
                porton.SetAncho(Convert.ToInt32(txtAncho.Text));
                porton.SetAlto(Convert.ToInt32(txtAlto.Text));
                porton.SetColor(Convert.ToInt32(txtColor.Text));
                porton.SetBloqueada(cbBloqueado.IsChecked == true);
            }
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            if(rbPuerta.IsChecked==true)
            {
                MessageBox.Show("Ancho: " + puerta.GetAncho() +
                            "\nAlto: " + puerta.GetAlto() +
                            "\nColor: " + puerta.GetColor() +
                            "\nAbierta: " + puerta.GetAbierta(),
                            "Puerta",
                            MessageBoxButton.OK);
            }

            if (rbPorton.IsChecked == true)
            {
                MessageBox.Show("Ancho: " + porton.GetAncho() +
                            "\nAlto: " + porton.GetAlto() +
                            "\nColor: " + porton.GetColor() +
                            "\nAbierta: " + porton.GetBloqueada(),
                            "Portón",
                            MessageBoxButton.OK);

                Close();
            }
        }

        private void rbPuerta_Checked(object sender, RoutedEventArgs e)
        {
            cbAbierta.IsEnabled = true;
            cbBloqueado.IsEnabled = false;
        }

        private void rbPorton_Checked(object sender, RoutedEventArgs e)
        {
            cbBloqueado.IsEnabled = true;
            cbAbierta.IsEnabled = false;
        }
    }
}

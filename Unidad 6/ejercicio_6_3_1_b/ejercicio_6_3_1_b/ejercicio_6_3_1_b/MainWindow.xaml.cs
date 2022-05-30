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

namespace ejercicio_6_3_1_b
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Puerta puerta;

        public MainWindow()
        {
            InitializeComponent();
            puerta = new Puerta();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            puerta.SetAncho(Convert.ToInt32(txtAncho.Text));
            puerta.SetAlto(Convert.ToInt32(txtAlto.Text));
            puerta.SetColor(Convert.ToInt32(txtColor.Text));
            puerta.SetAbierta(cbAbierta.IsChecked==true);
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ancho: " + puerta.GetAncho() +
                            "\nAlto: " + puerta.GetAlto() +
                            "\nColor: " + puerta.GetColor() +
                            "\nAbierta: " + puerta.GetAbierta(),
                            "Puerta",
                            MessageBoxButton.OK);

            Close();
        }
    }
}

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

namespace ejercicio_6_5_5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Coche coche;
        Moto moto;

        public MainWindow()
        {
            InitializeComponent();

            coche = new Coche();
            moto = new Moto();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if(rbCoche.IsChecked==true)
            {
                coche.SetMarca(txtMarca.Text);
                coche.SetModelo(txtModelo.Text);
                coche.SetCilindrada(Convert.ToInt32(txtCilindrada.Text));
                coche.SetPotencia(Convert.ToDouble(txtPotencia.Text));
            }
            if (rbMoto.IsChecked == true)
            {
                moto.SetMarca(txtMarca.Text);
                moto.SetModelo(txtModelo.Text);
                moto.SetCilindrada(Convert.ToInt32(txtCilindrada.Text));
                moto.SetPotencia(Convert.ToDouble(txtPotencia.Text));
            }
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            if (rbCoche.IsChecked == true)
            {
                MessageBox.Show("Marca: " + coche.GetMarca() +
                                "\nModelo: " + coche.GetModelo() +
                                "\nCilindrada: " + coche.GetCilindrada() +
                                "\nPotencia: " + coche.GetPotencia(),
                                "Coche",
                                MessageBoxButton.OK);
            }
            if (rbMoto.IsChecked == true)
            {
                MessageBox.Show("Marca: " + moto.GetMarca() +
                                "\nModelo: " + moto.GetModelo() +
                                "\nCilindrada: " + moto.GetCilindrada() +
                                "\nPotencia: " + moto.GetPotencia(),
                                "Moto",
                                MessageBoxButton.OK);
            }
            Close();
        }
    }
}

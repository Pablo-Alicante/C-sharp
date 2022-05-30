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

namespace ejercicio_6_2_4
{
    public class Coche
    {
        public string marca;
        public string modelo;
        public int cilindrada;
        public double potencia;

        //Métodos Set y Get de "marca".
        // --------------------------------------------
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public string GetMarca()
        {
            return this.marca;
        }

        //Métodos Set y Get de "modelo".
        // --------------------------------------------
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string GetModelo()
        {
            return this.modelo;
        }

        //Métodos Set y Get de "cilindrada".
        // --------------------------------------------
        public void SetCilindrada(int cilindrada)
        {
            this.cilindrada = cilindrada;
        }
        public int GetCilindrada()
        {
            return this.cilindrada;
        }

        //Métodos Set y Get de "potencia".
        // --------------------------------------------
        public void SetPotencia(double potencia)
        {
            this.potencia = potencia;
        }
        public double GetPotencia()
        {
            return this.potencia;
        }
    }


    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Coche coche;

        public MainWindow()
        {
            InitializeComponent();

            coche = new Coche();
        }

        private void btnAsignar_Click(object sender, RoutedEventArgs e)
        {
            coche.SetMarca(txtMarca.Text);
            coche.SetModelo(txtModelo.Text);
            coche.SetCilindrada(Convert.ToInt32(txtCilindrada.Text));
            coche.SetPotencia(Convert.ToDouble(txtPotencia.Text));
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Marca: " + coche.GetMarca() +
                            "\nModelo: " + coche.GetModelo() +
                            "\nCilindrada: " + coche.GetCilindrada() +
                            "\nPotencia: " + coche.GetPotencia(),
                            "Coche",
                            MessageBoxButton.OK);

            Close();
        }
    }
}

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

namespace ejercicio_6_3_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona persona1;
        Persona persona2;

        public MainWindow()
        {
            InitializeComponent();
            persona1 = new Persona();
            persona2 = new Persona();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            persona1.SetNombre(txtPersona1.Text);
            persona2.SetNombre(txtPersona2.Text);
        }

        private void btnSaludar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Persona 1: " + persona1.Saludar() +
                            "\nPersona 2: " + persona2.Saludar(),
                            "Saludar",
                            MessageBoxButton.OK);

            Close();
        }
    }
}

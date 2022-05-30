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

namespace ejercicio_6_2_2
{
    public class Juego
    {
        public string Lanzar()
        {
            return "Bienvenido a Console Invaders. \nPulse intro para salir.";
        }
    }
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Juego juego;

        public MainWindow()
        {
            InitializeComponent();

            juego = new Juego();
        }

        private void btnLanzar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(juego.Lanzar(),
                            "Space Invaders",
                            MessageBoxButton.OK);

            Close();
        }
    }
}

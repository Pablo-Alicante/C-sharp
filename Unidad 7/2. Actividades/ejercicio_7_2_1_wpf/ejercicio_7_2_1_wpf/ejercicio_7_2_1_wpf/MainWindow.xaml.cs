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

namespace ejercicio_7_2_1_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Se generan los objeto de las diferentes clases.
        Trabajador[] trabajador;
        Programador[] programador;
        Analista[] analista;
        Ingeniero[] ingeniero;
        IngenieroInformatico[] ingenieroInformatico;

        public MainWindow()
        {
            InitializeComponent();

            /*Se reserva la memoria del array y se crean los objetos,
            en función del número que queramos.*/

            trabajador = new Trabajador[3];

            for (int i = 0; i < 3; i++)
                trabajador[i] = new Trabajador();

            programador = new Programador[3];

            for (int i = 0; i < 3; i++)
                programador[i] = new Programador();

            analista = new Analista[3];

            for (int i = 0; i < 3; i++)
                analista[i] = new Analista();

            ingeniero = new Ingeniero[3];

            for (int i = 0; i < 3; i++)
                ingeniero[i] = new Ingeniero();

            ingenieroInformatico = new IngenieroInformatico[3];

            for (int i = 0; i < 3; i++)
                ingenieroInformatico[i] = new IngenieroInformatico();
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show(trabajador[i].GetIdentidad(),
                            "Trabajador",
                            MessageBoxButton.OK);
            }

            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show(analista[i].GetIdentidad(),
                            "Analista",
                            MessageBoxButton.OK);
            }

            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show(programador[i].GetIdentidad(),
                            "Programador",
                            MessageBoxButton.OK);
            }

            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show(ingeniero[i].GetIdentidad(),
                            "Ingeniero",
                            MessageBoxButton.OK);
            }

            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show(ingenieroInformatico[i].GetIdentidad(),
                            "Ingeniero informático",
                            MessageBoxButton.OK);
            }

            Close();
        }
    }
}

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

namespace ejercicio_6_8_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Trabajador trabajador;
        Programador programador;
        Analista analista;
        Ingeniero ingeniero;
        IngenieroInformatico ingenieroInformatico;

        public MainWindow()
        {
            InitializeComponent();

            trabajador = new Trabajador();
            programador = new Programador();
            analista = new Analista();
            ingeniero = new Ingeniero();
            ingenieroInformatico = new IngenieroInformatico();
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(trabajador.GetIdentidad(),
                            "Trabajador",
                            MessageBoxButton.OK);

            MessageBox.Show(analista.GetIdentidad(),
                            "Analista",
                            MessageBoxButton.OK);

            MessageBox.Show(programador.GetIdentidad(),
                            "Programador",
                            MessageBoxButton.OK);

            MessageBox.Show(ingeniero.GetIdentidad(),
                            "Ingeniero",
                            MessageBoxButton.OK);

            MessageBox.Show(ingenieroInformatico.GetIdentidad(),
                            "Ingeniero informático",
                            MessageBoxButton.OK);

            Close();
        }
    }
}

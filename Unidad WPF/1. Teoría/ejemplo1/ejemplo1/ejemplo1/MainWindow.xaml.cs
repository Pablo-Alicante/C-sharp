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

namespace ejemplo1
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

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Background = Brushes.IndianRed;
                txtNombre.Focus();

                return;
            }
            if(cbEstudiar.IsChecked==true)
            {
                MessageBox.Show("Adiós" + txtNombre.Text);
            }

            Close();
        }

        private void btnSalir_MouseEnter(object sender, MouseEventArgs e)
        {
            btnSalir.Background = Brushes.Green;
        }

        private void btnSalir_MouseLeave(object sender, MouseEventArgs e)
        {
            btnSalir.Background = Brushes.Red;
        }

        private void VentanaPrincipal_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(MessageBox.Show("¿Realmente quiere salir de la App?",
                               "Salir",
                               MessageBoxButton.YesNo,
                               MessageBoxImage.Question) 
                == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
        private void lbMotos_Click(object sender, RoutedEventArgs e)
        {
            lbMotos.IsEnabled = true;
            cbCoches.IsEnabled = false;
        }
        private void cbCoches_Click(object sender, RoutedEventArgs e)
        {
            lbMotos.IsEnabled = false;
            cbCoches.IsEnabled = true;
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Back)
            {
                btnSalir.IsEnabled = true;

                if(txtNombre.Text=="")
                {
                    btnSalir.IsEnabled = false;
                }
            }
            if()

        }
    }
}

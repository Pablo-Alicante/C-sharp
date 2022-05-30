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

namespace ejercicio_6_5_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona persona;

        PersonaInglesa personaInglesa1;
        PersonaInglesa personaInglesa2;

        PersonaItaliana personaItaliana;

        public MainWindow()
        {
            InitializeComponent();

            persona = new Persona();

            personaInglesa1 = new PersonaInglesa();
            personaInglesa2 = new PersonaInglesa();

            personaItaliana = new PersonaItaliana();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            persona.SetNombre(txtPersona.Text);

            personaInglesa1.SetNombre(txtPersonaInglesa1.Text);
            personaInglesa2.SetNombre(txtPersonaInglesa2.Text);

            personaItaliana.SetNombre(txtPersonaItaliana.Text);
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Persona 1: " + persona.Saludar() +
                            "\nPersona inglesa 1: " + personaInglesa1.Saludar() +
                            "\n" + personaInglesa1.TomarTe() +
                            "\nPersona inglesa 2: " + personaInglesa2.Saludar() +
                            "\n" + personaInglesa1.TomarTe() +
                            "\nPersona italiana: " + personaItaliana.Saludar(),
                            "Saludar",
                            MessageBoxButton.OK);

            Close();
        }
    }
}

﻿using System;
using System.IO;
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

namespace ejercicio_8_1_1_b_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StreamWriter fichero;
        StreamReader contadorLectura;
        StreamWriter contadorEscritura;
        int contador;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            using (contadorLectura = new StreamReader("contador.txt"))
            {
                contador = Convert.ToInt32(contadorLectura.ReadLine());
            }

            fichero = new StreamWriter("registroDeUsuario" + contador + ".txt");

            using (contadorEscritura = new StreamWriter("contador.txt"))
            {
                contador++;
                contadorEscritura.WriteLine(contador);
            }
        }

        private void mainWindow_Closed(object sender, EventArgs e)
        {
            fichero.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if(txtTexto.Text.ToLower()=="fin")
            {
                Close();
                return;
            }

            fichero.WriteLine(txtTexto.Text);
            txtTexto.Text = "";
            txtTexto.Focus();
        }
    }
}

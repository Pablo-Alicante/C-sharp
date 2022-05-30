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

namespace ejercicio_8_7_1_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StreamReader fichero1;
        StreamWriter fichero2;
        string linea;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            using (fichero1 = new StreamReader("fichero.txt", true))
            {
                linea = fichero1.ReadToEnd();
            }

            using (fichero2 = new StreamWriter("nuevoFichero.txt"))
            {
                fichero2.WriteLine(linea.ToUpper());
            }
        }

        private void mainWindow_Closed(object sender, EventArgs e)
        {
        }
    }
}

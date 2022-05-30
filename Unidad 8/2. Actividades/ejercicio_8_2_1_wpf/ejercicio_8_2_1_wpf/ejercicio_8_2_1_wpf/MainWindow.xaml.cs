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

namespace ejercicio_8_2_1_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StreamReader fichero;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            fichero = File.OpenText("registroDeUsuario.txt");
        }

        private void mainWindow_Closed(object sender, EventArgs e)
        {
            fichero.Close();
        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 3; i++)
                MessageBox.Show(fichero.ReadLine());
        }
    }
}

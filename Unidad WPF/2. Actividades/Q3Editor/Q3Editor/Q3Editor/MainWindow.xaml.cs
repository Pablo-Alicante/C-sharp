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
using System.IO;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace Q3Editor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool guardado;

        public MainWindow()
        {
            InitializeComponent();

            guardado = true;

            RoutedCommand Ctrl_N = new RoutedCommand();
            Ctrl_N.InputGestures.Add(new KeyGesture(Key.N, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_N, mArchivoNuevo_Click));

            RoutedCommand Ctrl_O = new RoutedCommand();
            Ctrl_O.InputGestures.Add(new KeyGesture(Key.O, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_O, mArchivoAbrir_Click));

            RoutedCommand Ctrl_S = new RoutedCommand();
            Ctrl_S.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_S, mArchivoGuardar_Click));

            RoutedCommand Alt_F4 = new RoutedCommand();
            Alt_F4.InputGestures.Add(new KeyGesture(Key.F4, ModifierKeys.Alt));
            CommandBindings.Add(new CommandBinding(Alt_F4, mArchivoGuardar_Click));

            RoutedCommand Ctrl_U = new RoutedCommand();
            Ctrl_U.InputGestures.Add(new KeyGesture(Key.U, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_U, mFuenteCursiva_Click));

            RoutedCommand Ctrl_B = new RoutedCommand();
            Ctrl_B.InputGestures.Add(new KeyGesture(Key.B, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_B, mFuenteNegrita_Click));

            RoutedCommand Ctrl_K = new RoutedCommand();
            Ctrl_K.InputGestures.Add(new KeyGesture(Key.K, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_K, mFuenteSubrayado_Click));

            RoutedCommand Ctrl_Mas = new RoutedCommand();
            Ctrl_Mas.InputGestures.Add(new KeyGesture(Key.Add, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_Mas, mFuenteAumentar_Click));

            RoutedCommand Ctrl_Menos = new RoutedCommand();
            Ctrl_Menos.InputGestures.Add(new KeyGesture(Key.Subtract, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_Menos, mFuenteDisminuir_Click));

            txtTexto.Focus();
        }

        /// <summary>
        /// Esta función nos sirve para no tener que escribir tanto texto.
        /// </summary>
        /// </return>
        /// Devuelve MessageBoxResult.Yes o MessageBoxResult.No
        /// </return>

        private MessageBoxResult ConfirmacionBox(string texto)
        {
            return System.Windows.MessageBox.Show(texto, "Confimación", MessageBoxButton.YesNo,
                MessageBoxImage.Question);
        }
        private void SeGuarda()
        {
            if(txtTexto.Text!="" && !guardado)
            {
                if (ConfirmacionBox("¿Desea guardar el texto?") == MessageBoxResult.Yes)
                {
                    Guardar();
                }
            }
        }

        private void mArchivoNuevo_Click(object sender, RoutedEventArgs e)
        {
            //Miramos si se guarda el texto.
            SeGuarda();

            //Limpiamos.
            txtTexto.Clear();

            //Indicamos que no tiene nombre.
            panelNombre.Content = ("<Sin nombre>");
        }

        private void txtTexto_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Si está guardado previamente, indicaremos que hay que guardarlo.
            if(guardado == true)
            {
                //Cada vez que el texto cambie indicaremos que hay que guardarlo.
                guardado = false;

                panelEstado.Content = "No guardado";
            }
        }
        private void mArchivoAbrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //Ruta de la carpeta "Mis documentos".
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

            openFileDialog.InitialDirectory = path;
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            //Si se pulsa el botón "Abrir".
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Declaro una variable de tipo fichero.
                var fileStream = openFileDialog.OpenFile();

                //Creo un canal de lectura.
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    //Rellenamos el TextBox con el contenido del fichero.
                    txtTexto.Text = reader.ReadToEnd();
                }

                //Alternativa simple.
                //txtTexto.Text = File.ReadAllText(openFileDialog.FileName);

                //En la barra de estado pongo el nombre del fichero.
                panelNombre.Content = openFileDialog.FileName;

                //Indico que está guardado.
                guardado = true;

                panelEstado.Content = "Guardado";
            }
        }
        private void Guardar()
        {
            //Si no está guardado, lo que guardo; si no, no hago nada.
            if (!guardado)
            {
                //Si no tiene nombre...
                if (panelNombre.Content.ToString() == "<Sin nombre>")
                {
                    GuardarComo();
                }
                else
                {
                    //Lo guardamos en el fichero.
                    File.WriteAllText(panelNombre.Content.ToString(), txtTexto.Text);

                    //Se guarda.
                    guardado = true;

                    //Indicamos que se ha guardado.
                    panelEstado.Content = "Guardado";
                }
            }
        }
        private void GuardarComo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //Ruta de la carpeta "Mis documentos".
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

            saveFileDialog.InitialDirectory = path;
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;

            //Si pinchamos sobre el botón "Guardar".
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Indicamos el nombre.
                panelNombre.Content = saveFileDialog.FileName;

                //Lo guardamos en el fichero.
                File.WriteAllText(panelNombre.Content.ToString(), txtTexto.Text);

                //Se guarda el texto.
                guardado = true;

                //Indicamos que se ha guardado.
                panelEstado.Content = "Guardado";
            }
        }
        private void mArchivoGuardarComo_Click(object sender, RoutedEventArgs e)
        {
            GuardarComo();
        }

        private void mArchivoGuardar_Click(object sender, RoutedEventArgs e)
        {
            Guardar();
        }

        private void VentanaPrincipal_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SeGuarda();
        }

        private void mArchivoSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void mEditarCortar_Click(object sender, RoutedEventArgs e)
        {
            //Si no tengo nada seleccionado, no hagas nada, no hagas trabajar al SO.
            //Si tengo texto seleccionado, lo cortamos.
            if (txtTexto.SelectedText != "")
            {
                txtTexto.Cut();
            }

            /*Versión más rápida: porque es mucho más fácil comparar con números
             que comparar con una cadena vacía, ya que tendría que transformarla a
            su correspondiente código ASCII..*/

            //if(txtTexto.SelectionLength>0)
            //{
            //    txtTexto.Cut();
            //}
        }

        private void mEditarCopiar_Click(object sender, RoutedEventArgs e)
        {
            //Si tengo texto seleccionado, lo copiamos.
            if (txtTexto.SelectedText != "")
            {
                txtTexto.Copy();
            }

            /*Versión más rápida: porque es mucho más fácil comparar con números
             que comparar con una cadena vacía, ya que tendría que transformarla a
            su correspondiente código ASCII..*/

            //if(txtTexto.SelectionLength>0)
            //{
            //    txtTexto.Copy();
            //}
        }

        private void mEditarPegar_Click(object sender, RoutedEventArgs e)
        {
            //Lo pegamos.
            txtTexto.Paste();
        }

        private void mFuenteNegrita_Click(object sender, RoutedEventArgs e)
        {
            //Si el menú "mFuenteNegrita" está checkeado...
            if (mFuenteNegrita.IsChecked)
            {
                //Quitamos la fuente en Negrita.
                txtTexto.FontWeight = FontWeights.Normal;

                mFuenteNegrita.IsChecked = false;
            }
            else
            {
                txtTexto.FontWeight = FontWeights.Bold;

                mFuenteNegrita.IsChecked = true;
            }
        }

        private void mFuenteCursiva_Click(object sender, RoutedEventArgs e)
        {
            //Si el menú "mFuenteCursiva" está checkeado...
            if(mFuenteCursiva.IsChecked)
            {
                //Quitamos la fuente en Cursiva/Itálica.
                txtTexto.FontStyle = FontStyles.Normal;

                mFuenteCursiva.IsChecked = false;
            }
            else
            {
                txtTexto.FontStyle = FontStyles.Italic;

                mFuenteCursiva.IsChecked = true;
            }
        }

        private void mFuenteSubrayado_Click(object sender, RoutedEventArgs e)
        {
            //Si el menú "mFuenteSubrayado" está checkeado...
            if (mFuenteCursiva.IsChecked)
            {
                //Quitamos la fuente subrayada.
                txtTexto.TextDecorations= null;

                mFuenteSubrayado.IsChecked = false;
            }
            else
            {
                txtTexto.TextDecorations = TextDecorations.Underline;

                mFuenteSubrayado.IsChecked = true;
            }
        }

        private void mFuenteAumentar_Click(object sender, RoutedEventArgs e)
        {
            txtTexto.FontSize++;
        }

        private void mFuenteDisminuir_Click(object sender, RoutedEventArgs e)
        {
            if(txtTexto.FontSize>1)
            {
                txtTexto.FontSize--;
            }
        }
        private void mFuenteFuentes_Click(object sender, RoutedEventArgs e)
        {
            var fontDialog = new FontDialog();

            fontDialog.ShowDialog();
        }
    }
}

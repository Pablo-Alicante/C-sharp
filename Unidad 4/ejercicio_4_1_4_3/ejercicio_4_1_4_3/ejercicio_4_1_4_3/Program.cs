using System;

namespace ejercicio_4_1_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            int longitud = 5;
            int cantidad = 3;
            int numeroUsuario;
            int posicionUsuario;

            Console.WriteLine("El programa le pedirá que inserte un dato (un número) en la posición que uste elija.");

            Console.WriteLine();

            Console.Write("Introduzca el dato que desea añadir: ");
            numeroUsuario = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca la posición en la que desea añadir el dato: ");
            posicionUsuario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            try
            {
                for (int i = cantidad; i > posicionUsuario; i--)
                {
                    datos[i] = datos[i - 1];
                }

                datos[posicionUsuario] = numeroUsuario;
                cantidad++;

                //Mostrar los datos que hay en el array.

                Console.WriteLine("Los números que hay ahora en el array son los siguientes:");
                for (int j = 0; j < longitud; j++)
                {
                    Console.WriteLine(datos[j]);
                }
            }
            catch(IndexOutOfRangeException errorEncontrado)
            {
                Console.WriteLine("Ha habido un error: {0}", errorEncontrado.Message);
            }
        }
    }
}

using System;

namespace ejercicio_4_1_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            int longitud = 5;
            int cantidad = 3;
            int posicionUsuario;

            Console.WriteLine("El programa borrará el dato (número) que se encuentre en la posición que usted elija.");

            Console.WriteLine();

            Console.Write("Introduzca la posición que desea borrar: ");
            posicionUsuario = Convert.ToInt32(Console.ReadLine());

            for(int i=posicionUsuario;i<cantidad;i++)
            {
                datos[i] = datos[i + 1];
            }

            cantidad++;

            //Ahora muestro el array.

            Console.WriteLine("Ahora el array tiene los siguientes datos:");
            for(int j=0;j<longitud;j++)
            {
                Console.WriteLine("{0}", datos[j]);
            }
        }
    }
}

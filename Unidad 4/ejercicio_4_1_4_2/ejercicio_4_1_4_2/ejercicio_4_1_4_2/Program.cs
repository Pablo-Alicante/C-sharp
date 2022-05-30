using System;

namespace ejercicio_4_1_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 10, 15, 12, 0, 0 };
            int longitud = 5;
            int cantidadNumeros = 3;
            int datoUsuario;

            Console.WriteLine("El programa añadirá un dato (un número), introducido por usted, al final de los datos existentes.");

            Console.WriteLine();

            Console.Write("Introduzca el dato que desea añadir: ");
            datoUsuario = Convert.ToInt32(Console.ReadLine());

            if(cantidadNumeros<longitud)
            {
                numeros[cantidadNumeros] = datoUsuario;
                cantidadNumeros++;
            }

            Console.WriteLine();

            //Mostrar los números que hay ahora en el array.

            Console.WriteLine("Los número que hay ahora en el array son los siguientes:");
            for (int i=0;i<longitud; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}

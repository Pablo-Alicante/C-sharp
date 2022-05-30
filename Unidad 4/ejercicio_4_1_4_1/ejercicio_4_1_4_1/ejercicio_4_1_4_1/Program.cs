using System;

namespace ejercicio_4_1_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            int longitud = 5;
            int cantidad = 3;
            int contador = 0;
            int datoBuscar;

            Console.WriteLine("El programa le pedirá que busque un dato (un número).\nSi el dato aparece, le mostrará la cantidad de veces que lo hace. En caso contrario, le avisará de que no aparece.");

            Console.WriteLine();

            Console.Write("Introduzca el dato que desea buscar: ");
            datoBuscar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (datos[i] == datoBuscar)
                {
                    contador++;

                    Console.WriteLine("El dato se ha encontrado un total de {0} vez.", contador);
                }

                else
                    if(datos[i]!=datoBuscar)
                    {
                        Console.WriteLine("El dato no se ha encontrado.");
                    }
            }
        }
    }
}

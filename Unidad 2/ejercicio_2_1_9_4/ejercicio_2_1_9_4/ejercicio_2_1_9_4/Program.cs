using System;

namespace ejercicio_2_1_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduzca un número del 1 al 5:");
            numero = Convert.ToInt32(
                Console.ReadLine());

            if (numero == 1)
                Console.WriteLine("El número introducido es uno.");

            if (numero == 2)
                Console.WriteLine("El número introducido es dos.");

            if (numero == 3)
                Console.WriteLine("El número introducido es tres.");

            if (numero == 4)
                Console.WriteLine("El número introducido es cuatro.");

            if (numero == 5)
                Console.WriteLine("El número introducido es cinco.");
        }
    }
}

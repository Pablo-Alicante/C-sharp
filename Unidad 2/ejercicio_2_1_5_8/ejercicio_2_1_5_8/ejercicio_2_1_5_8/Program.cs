using System;

namespace ejercicio_2_1_5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.WriteLine("Introduzca un número:");
            numero1 = Convert.ToInt32(
                Console.ReadLine());

            Console.WriteLine("Introduzca otro número:");
            numero2 = Convert.ToInt32(
                Console.ReadLine());

            if ((numero1 > 0) && (numero2 > 0))
                Console.WriteLine("Los dos números son positivos.");

            else
                if (((numero1 > 0) && (numero2 < 0)) || ((numero1 < 0) && (numero2 > 0)))
                Console.WriteLine("Uno de los números es positivo.");

                else
                     if ((numero1 < 0) && (numero2 < 0))
                     Console.WriteLine("Ninguno de los números es positivo.");
        }
    }
}

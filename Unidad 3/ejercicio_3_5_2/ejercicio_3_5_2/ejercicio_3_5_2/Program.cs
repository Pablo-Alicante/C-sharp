using System;

namespace ejercicio_3_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            bool iguales;

            Console.WriteLine("El programa le pedirá dos números.");
            Console.WriteLine("Si ambos números son iguales se lo indicará con un \"true\", si no son iguales se lo indicará con un \"false\".");

            Console.WriteLine();

            Console.Write("Introduzca un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca otro número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if(numero1==numero2)
            {
                iguales = true;
            }
            else 
            {
                iguales = false;
            }

            Console.WriteLine();

            Console.WriteLine(iguales);
        }
    }
}

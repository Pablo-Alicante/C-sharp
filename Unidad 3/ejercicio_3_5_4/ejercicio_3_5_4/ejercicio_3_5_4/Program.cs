using System;

namespace ejercicio_3_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            bool ambosPares;

            Console.WriteLine("El programa le pedirá dos números.");
            Console.WriteLine("Si ambos números son pares se lo indicará con un \"true\", si no son pares se lo indicará con un \"false\".");

            Console.WriteLine();

            Console.Write("Introduzca un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca otro número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if((numero1%2==0)&&(numero2%2==0))
            {
                ambosPares = true;
            }
            else 
            {
                ambosPares = false;
            }

            Console.WriteLine();

            Console.WriteLine(ambosPares);
        }
    }
}

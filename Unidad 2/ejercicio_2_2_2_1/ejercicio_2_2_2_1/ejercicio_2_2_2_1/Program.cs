using System;

namespace ejercicio_2_2_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            do
            {
                Console.Write("Introduzca un número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduzca otro número: ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(numero1+numero2);
            }
            while ((numero1> 0) || (numero2> 0));

            Console.WriteLine("Operación terminada.");
        }
    }
}

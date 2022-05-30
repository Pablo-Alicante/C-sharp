using System;

namespace ejercicio_2_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.WriteLine("Introduzca un número: ");
            numero1 = Convert.ToInt32(
                Console.ReadLine());

            Console.WriteLine("Introduzca otro número: ");
            numero2 = Convert.ToInt32(
                Console.ReadLine());

            if (numero1 > numero2)
                Console.WriteLine("{0} es mayor que {1}",
                    numero1, numero2);

            if (numero1 < numero2)
                Console.WriteLine("{0} es mayor que {1}",
                    numero2, numero1);
        }
    }
}

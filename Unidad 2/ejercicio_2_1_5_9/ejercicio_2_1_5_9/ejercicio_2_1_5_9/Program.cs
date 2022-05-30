using System;

namespace ejercicio_2_1_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int numero3;

            Console.WriteLine("Introduzca un número:");
            numero1 = Convert.ToInt32(
                Console.ReadLine());

            Console.WriteLine("Introduzca otro número:");
            numero2 = Convert.ToInt32(
                Console.ReadLine());

            Console.WriteLine("Introduzca otro número:");
            numero3 = Convert.ToInt32(
                Console.ReadLine());

            if ((numero1 > numero2) && (numero1 > numero3))
                Console.WriteLine("El número {0} es el mayor de los tres.",
                    numero1);

            else
                if ((numero1 < numero2) && (numero2 > numero3))
                Console.WriteLine("El número {0} es el mayor de los tres.",
                    numero2);

                 else
                      if ((numero1 < numero3) && (numero2 < numero3))
                      Console.WriteLine("El número {0} es el mayor de los tres.",
                      numero3);

        }
    }
}

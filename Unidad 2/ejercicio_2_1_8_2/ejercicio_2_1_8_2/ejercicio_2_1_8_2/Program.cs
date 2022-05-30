using System;

namespace ejercicio_2_1_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int menor;

            Console.Write("Introduzca un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca otro número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            menor = numero1 < numero2 ? numero1 : numero2;

            Console.WriteLine("El número {0} es el menor de los dos números.", menor);
        }
    }
}

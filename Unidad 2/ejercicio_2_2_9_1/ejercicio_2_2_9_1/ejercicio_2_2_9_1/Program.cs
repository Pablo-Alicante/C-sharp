using System;

namespace ejercicio_2_2_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Introduzca un número: ");
            numero=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<=numero;i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}

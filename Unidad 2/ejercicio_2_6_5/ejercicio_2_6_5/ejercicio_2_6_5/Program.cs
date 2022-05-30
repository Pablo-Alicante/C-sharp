using System;

namespace ejercicio_2_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int alto;

            Console.Write("Introduzca el alto del triángulo: ");
            alto = Convert.ToInt32(Console.ReadLine());

            for(int i1=alto;i1>=1;i1--)
            {
                for(int i2=alto;i2>=1;i2--)
                {
                    Console.WriteLine('*');
                }
                Console.WriteLine();
            }
        }
    }
}

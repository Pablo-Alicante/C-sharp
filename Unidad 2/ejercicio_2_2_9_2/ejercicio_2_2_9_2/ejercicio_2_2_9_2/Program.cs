using System;

namespace ejercicio_2_2_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.Write("Introduzca un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca otro número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            for(int i1=0;i1<=numero1;i1++)
            {
                for(int i2=0;i2<=numero2;i2++)
                {
                    if(numero1%i1==numero2%i2)
                    {
                        Console.WriteLine("{0}", numero1);
                    }
                }
            }
        }
    }
}

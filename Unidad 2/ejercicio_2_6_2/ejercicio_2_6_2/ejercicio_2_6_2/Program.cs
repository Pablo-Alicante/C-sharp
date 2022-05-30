using System;
using System.Diagnostics;

namespace ejercicio_2_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una de las formas de hacer el programa:

            int numero1;
            int numero2;
            int minimo;

            Console.Write("Introduzca un número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca otro número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            minimo = (numero1 > numero2 ? numero2 : numero1);

            for(int i=minimo;i<=1;i--)
            {
                if((numero1%i==0)&&(numero2%i==0))
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            //Otra de las formas de hacer el programa:

            int divisor = 2;
            int numero = numeroleido;

            while(numero=1)
            {
                if (numero % divisor == 0)
                {
                    Console.WriteLine(divisor);
                    numero = numero / divisor;
                }
                else
                    divisor++;
            }   
        }
    }
}

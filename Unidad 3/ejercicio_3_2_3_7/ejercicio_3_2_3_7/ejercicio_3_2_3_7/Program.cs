using System;

namespace ejercicio_3_2_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int termino;
            double pi = Math.PI;
            double aproximacion = pi / 4;

            Console.WriteLine("El programa mostrará una aproximación de PI mediante la expresión: pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13...");
            Console.WriteLine("El usuario deberá indicar la cantidad de términos a utilizar.");

            Console.WriteLine();

            Console.Write("Introduzca la cantidad de términos a utilizar: ");
            termino = Convert.ToInt32(Console.ReadLine());

            for(int contador=1;contador<=termino; contador+=2)
            {
                aproximacion= 1 / 1 - 1 / 3 + 1 / 5 - 1 / 7 + 1 / 9 - 1 / 11 + 1 / 13
            }
        }
    }
}

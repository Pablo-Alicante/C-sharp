using System;

namespace ejercicio_3_3_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.Write("Introduzca una letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            for (char contador=letra;contador<='z';contador++)
            {
                Console.Write(contador++);
            }
        }
    }
}

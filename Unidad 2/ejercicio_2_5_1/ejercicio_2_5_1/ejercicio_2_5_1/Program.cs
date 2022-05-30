using System;
using System.Threading.Channels;

namespace ejercicio_2_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            Console.Write("Introduzca una frase: ");
            string frase = Console.ReadLine();

            foreach (char letra in frase)
            {
                if (letra == 'a')
                    contador++;
            }
            Console.WriteLine("La frase contiene {0} letras a.",contador);
        }
    }
}

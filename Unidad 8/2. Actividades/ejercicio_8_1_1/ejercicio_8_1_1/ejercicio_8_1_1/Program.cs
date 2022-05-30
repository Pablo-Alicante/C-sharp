using System;
using System.IO;

namespace ejercicio_8_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero;
            string texto;

            using (fichero = new StreamWriter("resgistroDeUsuario.txt"))
            {
                Console.Write("Texto: ");
                texto = Console.ReadLine();

                while(texto.ToLower() != "fin")
                {
                    fichero.WriteLine(texto);

                    Console.Write("Texto: ");
                    texto = Console.ReadLine();
                }
            }
        }
    }
}

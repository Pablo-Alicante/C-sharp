using System;

namespace ejercicio_3_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Juan";

            Console.Write("Introduzca su nombre: ");
            nombre = Console.ReadLine();

            if(nombre=="Juan")
            {
                Console.WriteLine("\"Hola Juan\"");
            }
            else
            {
                Console.WriteLine("Lo siento, no te conozco.");
            }
        }
    }
}

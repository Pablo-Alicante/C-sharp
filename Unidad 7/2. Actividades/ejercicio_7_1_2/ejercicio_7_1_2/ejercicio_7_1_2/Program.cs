using System;

namespace ejercicio_7_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hardware miPantalla = new Hardware();

            Console.Write("Introduzca un texto: ");
            miPantalla.EscribirCentrado(Console.ReadLine());
        }
    }
}

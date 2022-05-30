using System;

namespace ejercicio_2_2_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string identificador = "Pedro";
            string clave = "Peter";

            do
            {
                Console.Write("Introduzca el identificador: ");
                identificador = Console.ReadLine();

                Console.Write("Introduzca la clave: ");
                clave = Console.ReadLine();

                if ((identificador != "Pedro") && (clave != "Peter"))
                    Console.WriteLine("Error. Acceso denegado.");
            }
            while ((identificador != "Pedro") && (clave != "Peter"));

            Console.WriteLine("Acceso permitido.");
        }
    }
}

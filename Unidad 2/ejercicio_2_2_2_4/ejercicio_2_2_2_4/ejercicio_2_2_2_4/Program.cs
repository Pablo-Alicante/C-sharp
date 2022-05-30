using System;

namespace ejercicio_2_2_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int identificador = 1234;
            int clave = 1111;

            do
            {
                Console.Write("Introduzca su identificador: ");
                identificador = Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduzca su clave: ");
                clave = Convert.ToInt32(Console.ReadLine());

                if ((identificador != 1234) && (clave != 1111))
                    Console.WriteLine("Error. No se permite el acceso.");
            }
            while ((identificador != 1234) && (clave != 1111));

            Console.WriteLine("Acceso permitido.");
        }
    }
}

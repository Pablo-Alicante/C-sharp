using System;

namespace ejercicio_2_2_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int clave = 0;

            Console.Write("Introduzca su contraseña: ");
            clave = Convert.ToInt32(Console.ReadLine());

            while (clave != 1111)
            {
                Console.WriteLine("La clave introducida es incorrecta.");

                Console.Write("Introduzca su contraseña: ");
                clave = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Contraseña correcta.");
        }

            
    }
}

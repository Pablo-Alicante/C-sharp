using System;

namespace ejercicio_3_3_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho;
            int alto;
            char letra;

            Console.Write("Introduzca el ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca el alto: ");
            alto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca una letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            for(int fila=1;fila<=alto;fila++)
            {
                for(int columna=1;columna<ancho;columna++)
                {
                    Console.Write(letra);
                }
                Console.WriteLine(letra);
            }
        }
    }
}

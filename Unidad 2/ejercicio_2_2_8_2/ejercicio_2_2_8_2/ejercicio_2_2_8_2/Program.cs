using System;

namespace ejercicio_2_2_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int alto, ancho;

            Console.Write("Introduzca el alto: ");
            alto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca el ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            for(int filaActual=1;filaActual<=alto;filaActual++)
            {
                for(int columnaActual=1;columnaActual<ancho; columnaActual++)
                {
                    Console.Write('*');
                }
                Console.WriteLine('*');
            }
        }
    }
}

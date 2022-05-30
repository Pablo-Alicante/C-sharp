using System;

namespace ejercicio_1_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Este ejercicio es erróneo, ya que los identificadores no son válidos*/

            int 1numero;
            int 2numero;
            int producto;

            1numero = 87;
            2numero = 94;
            producto=1numero*2numero;

            Console.WriteLine("El producto de {0} * {1} es {2}",
                1numero, 2numero, producto);
        }
    }
}

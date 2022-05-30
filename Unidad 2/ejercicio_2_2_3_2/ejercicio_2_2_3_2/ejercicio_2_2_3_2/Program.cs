using System;

namespace ejercicio_2_2_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador;

            for (contador = 1; contador <= 50; contador = contador + 1)

                if (contador % 3 == 0)
                    Console.WriteLine("{0}", contador);
        }
    }
}

using System;

namespace ejercicio_4_1_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAXIMO = 12;
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            string orden;

            Console.WriteLine("El programa le mostrará los nombres de los meses del año. \nEn orden natural o inverso, según elija usted.");

            Console.WriteLine();

            Console.WriteLine("Para verlos en orden natural deberá introducir \"natural\".");
            Console.WriteLine("Para verlos en orden inverso deberá introducir \"inverso\".");

            Console.WriteLine();

            Console.Write("Introduzca el orden en el que desea ver los meses: ");
            orden = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

            if (orden=="natural")
            {
                for(int i=0;i<MAXIMO;i++)
                {
                    Console.WriteLine(meses[i]);
                }
            }

            else
                if(orden=="inverso")
                {
                    for (int j = 0; j < MAXIMO; j++)
                    {
                        Console.WriteLine(meses[MAXIMO-j-1]);
                    }
                }

        }
    }
}

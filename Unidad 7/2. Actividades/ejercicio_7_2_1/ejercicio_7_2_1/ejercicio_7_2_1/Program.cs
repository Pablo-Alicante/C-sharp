/*Crea una versión ampliada del ejercicio 6.8.1 (clase Trabajador y 
relacionadas), en la que no se cree un único objeto de cada clase, sino un array de 
tres objetos. */

using System;

namespace ejercicio_7_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea el array y los 3 objetos de la clase trabajador.
            Trabajador[] trabajador = new Trabajador[3];

            for (int i = 0; i < 3; i++)
                trabajador[i] = new Trabajador();

            Console.WriteLine();

            //Se crea el array y los 3 objetos de la clase programador.
            Programador[] programador = new Programador[3];

            for (int i = 0; i < 3; i++)
                programador[i] = new Programador();

            Console.WriteLine();

            //Se crea el array y los 3 objetos de la clase analista.
            Analista[] analista = new Analista[3];

            for (int i = 0; i < 3; i++)
                analista[i] = new Analista();

            Console.WriteLine();

            //Se crea el array y los 3 objetos de la clase ingeniero.
            Ingeniero[] ingeniero = new Ingeniero[3];

            for (int i = 0; i < 3; i++)
                ingeniero[i] = new Ingeniero();

            Console.WriteLine();

            //Se crea el array y los 3 objetos de la clase ingeniero informático.
            IngenieroInformatico[] ingenieroInformatico = new IngenieroInformatico[3];

            for (int i = 0; i < 3; i++)
                ingenieroInformatico[i] = new IngenieroInformatico();

            Console.WriteLine();
        }
    }
}

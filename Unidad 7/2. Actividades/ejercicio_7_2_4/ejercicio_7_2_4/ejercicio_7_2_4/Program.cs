using System;

namespace ejercicio_7_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reservamos la memoria para el array.
            Trabajador[] trabajadores = new Trabajador[5];

            //Creamos los diferentes elementos.
            trabajadores[0] = new Analista();
            trabajadores[1] = new Ingeniero();
            trabajadores[2] = new Programador();
            trabajadores[3] = new IngenieroInformatico();
            trabajadores[4] = new Trabajador();
        }
    }
}

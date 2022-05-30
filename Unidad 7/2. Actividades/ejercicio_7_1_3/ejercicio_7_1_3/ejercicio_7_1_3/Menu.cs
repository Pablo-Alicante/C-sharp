using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_7_1_3
{
    class Menu
    {
        struct tipoFicha
        {
            public string nombreFichero;
            public int tamanoFichero;
        };

        static tipoFicha[] fichas = new tipoFicha[1000];
        static int numeroFichas = 0;

        public void Info()
        {
            Console.Clear();
            Console.WriteLine("Escoja una opción:");
            Console.WriteLine("\t1.- Añadir datos de un nuevo fichero.");
            Console.WriteLine("\t2.- Mostrar los nombres de todos los ficheros.");
            Console.WriteLine("\t3.- Mostrar ficheros por encima de un cierto tamaño.");
            Console.WriteLine("\t4.- Ver datos de un fichero.");
            Console.WriteLine("\t5.- Salir.");
        }
        public void AnadirDatosNuevoFichero()
        {
            if (numeroFichas < 1000)
            {
                Console.Write("Nombre del fichero: ");
                fichas[numeroFichas].nombreFichero = Console.ReadLine();

                Console.Write("Introduce el tamaño en KB: ");
                fichas[numeroFichas].tamanoFichero = Convert.ToInt32(Console.ReadLine());

                numeroFichas++;
            }
            else
            {
                Console.WriteLine("Haz alcanzado el máximo de fichas (1000).");
            }
        }
        public void MostrarNombresFicheros()
        {
            for (int i = 0; i < numeroFichas; i++)
            {
                Console.WriteLine("Nombre: {0}", fichas[i].nombreFichero);
            }
        }
        public void MostrarTodosFicheros()
        {
            int tamano;

            Console.Write("¿A partir de que tamaño quieres ver?: ");
            tamano = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numeroFichas; i++)
            {
                if (fichas[i].tamanoFichero >= tamano)
                {
                    Console.WriteLine("Nombre: {0}\nTamaño: {1} KB", fichas[i].nombreFichero, fichas[i].tamanoFichero);
                }
            }
        }
        public void VerDatosFicheros()
        {
            string buscarFichero;

            Console.Write("¿De qué fichero quieres ver todos los datos?: ");
            buscarFichero = Console.ReadLine();

            for (int i = 0; i < numeroFichas; i++)
            {
                if (fichas[i].nombreFichero == buscarFichero)
                {
                    Console.WriteLine("Nombre: {0}\nTamaño: {1} KB", fichas[i].nombreFichero, fichas[i].tamanoFichero);
                }
            }
        }
    }
}

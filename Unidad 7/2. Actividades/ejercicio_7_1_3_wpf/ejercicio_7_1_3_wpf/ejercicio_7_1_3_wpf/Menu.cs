using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7_1_3_wpf
{
    class Menu
    {
        struct tipoFicha
        {
            public string nombreFichero;
            public int tamanoFichero;
        };

        tipoFicha[] ficha = new tipoFicha[1000];
        int numeroFichas = 0;

        public void AnadirDatosNuevoFichero(string nombreFichero, int tamanoFichero)
        {
            if (numeroFichas < 1000)
            {
                ficha[numeroFichas].nombreFichero = nombreFichero;
                ficha[numeroFichas].tamanoFichero = Convert.ToInt32(tamanoFichero);

                numeroFichas++;
            }
            else
            {
                Console.WriteLine("Haz alcanzado el máximo de fichas (1000).");
            }
        }
        public string MostrarNombresFicheros()
        {
            for (int i = 0; i < numeroFichas; i++)
            {
                return ficha[i].nombreFichero;
            }
        }
        public void MostrarTodosFicheros()
        {
            for (int i = 0; i < numeroFichas; i++)
            {
                Console.WriteLine("Nombre: {0}\nTamaño: {1} KB", ficha[i].nombreFichero, ficha[i].tamanoFichero);
            }
        }
        public void VerDatosFicheros(string buscarFichero)
        {
            for (int i = 0; i < numeroFichas; i++)
            {
                if (ficha[i].nombreFichero == buscarFichero)
                {
                    Console.WriteLine("Nombre: {0}\nTamaño: {1} KB", ficha[i].nombreFichero, ficha[i].tamanoFichero);
                }
            }
        }
    }
}

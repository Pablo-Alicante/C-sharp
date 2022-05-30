using System;

namespace ejercicio_4_3_3_1
{
    class Program
    {
        struct tiempoCancion
        {
            public ushort minutosCancion;
            public ushort segundosCancion;
        }

        struct tipoCancion
        {
            public string tituloCancion;
            public string artistaCancion;
            public tiempoCancion duracionCancion;
            public ushort tamanoFichero;
        }

        static void Main(string[] args)
        {
            //Información del array.

            tipoCancion[] canciones = new tipoCancion[100];
            int longitud = 100;

            int contador = 0;

            //Menú de interacción.

            string accionUsuario;

            Console.WriteLine("El programa puede almacenar información sobre diferentes canciones. \nSe le mostrará un menú para que pueda interactuar con el programa.");

            Console.WriteLine();

            Console.WriteLine("Menú de interacción.");
            Console.WriteLine("-------------------");
            Console.WriteLine("Añadir una nueva canción: \"añadir\" \nMostrar títulos de todas las canciones: \"mostrar\" \nBuscar canción: \"buscar\" \nSalir del programa: \"salir\"");

            Console.WriteLine();

            Console.Write("¿Qué desea hacer?: ");
            accionUsuario = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

            while (accionUsuario != "salir")
            {
                switch (accionUsuario)
                {
                    case "añadir":

                        if (contador < longitud)
                        {
                            Console.Write("Introduzca el título de la canción: ");
                            canciones[contador].tituloCancion = Convert.ToString(Console.ReadLine());

                            Console.Write("Introduzca el autor de la canción: ");
                            canciones[contador].artistaCancion = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Introduzca la duración de la canción:");
                            Console.Write("Minutos: ");
                            canciones[contador].duracionCancion.minutosCancion = Convert.ToUInt16(Console.ReadLine());
                            Console.Write("Segundos: ");
                            canciones[contador].duracionCancion.segundosCancion = Convert.ToUInt16(Console.ReadLine());

                            Console.Write("Introduzca el tamaño del archivo (en KB): ");
                            canciones[contador].tamanoFichero = Convert.ToUInt16(Console.ReadLine());

                            contador++;
                        }

                        Console.WriteLine();

                        Console.Write("¿Qué desea hacer?: ");
                        accionUsuario = Convert.ToString(Console.ReadLine());

                        Console.WriteLine();

                        break;

                    case "mostrar":

                        Console.WriteLine("Has introducido las siguientes canciones:");
                        Console.WriteLine("-----------------------------------------");

                        for (int i = 0; i < contador; i++)
                        {
                            Console.WriteLine(canciones[i].tituloCancion);
                        }

                        Console.WriteLine();

                        Console.Write("¿Qué desea hacer?: ");
                        accionUsuario = Convert.ToString(Console.ReadLine());

                        Console.WriteLine();

                        break;

                    case "buscar":

                        Console.Write("Introduzca una palabra o texto para buscar la canción: ");
                        string encontrarCancion = Convert.ToString(Console.ReadLine());

                        Console.WriteLine();

                        for (int i = 0; i < contador; i++)
                        {
                            if (canciones[i].tituloCancion.Contains(encontrarCancion) || canciones[i].artistaCancion.Contains(encontrarCancion))
                            {
                                Console.WriteLine("La canción que ha buscado puede ser:");
                                Console.WriteLine("-----------------------------");
                                Console.WriteLine("Título de la canción: {0}", canciones[i].tituloCancion);
                                Console.WriteLine("Autor de la canción: {0}", canciones[i].artistaCancion);
                                Console.WriteLine("Duración de la canción: {0} minutos {1} segundos", canciones[i].duracionCancion.minutosCancion, canciones[i].duracionCancion.segundosCancion);
                                Console.WriteLine("Tamaño del fichero: {0} KB", canciones[i].tamanoFichero);

                                Console.WriteLine();
                            }
                        }

                        Console.WriteLine();

                        Console.Write("¿Qué desea hacer?: ");
                        accionUsuario = Convert.ToString(Console.ReadLine());

                        Console.WriteLine();

                        break;
                }
            }
        }
    }
}

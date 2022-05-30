using System;

namespace ejercicio_4_3_2_2
{
    class Program
    {
        struct datosImagenes
        {
            public string nombreImagen;
            public ushort anchoImagen;
            public ushort altoImagen;
            public ushort tamanoImagen;
        }

        static void Main(string[] args)
        {
            //Información del array.

            datosImagenes[] imagenes = new datosImagenes[700];
            int longitudArray = 700;

            int contador = 0;

            //Menú de interacción.

            string accionUsuario;

            //Breve descripción que se le da al usuario de cómo funciona el programa.

            Console.WriteLine("El programa permite almacenar información de 700 imágenes. \nSe le mostrará un menú para que pueda interactuar con el programa.");

            Console.WriteLine();

            Console.WriteLine("Menú de interacción");
            Console.WriteLine("-------------------");
            Console.WriteLine("Añadir ficha: \"añadir\" \nVer todas las fichas: \"ver\" \nBuscar ficha: \"buscar\" \nSalir del programa: \"salir\"");

            Console.WriteLine();

            Console.Write("¿Qué desea hacer?: ");
            accionUsuario = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

            while (accionUsuario!="salir")
            {
                switch(accionUsuario)
                {
                    case "añadir":

                        if(contador<longitudArray)
                        {
                            Console.Write("Introduzca el nombre de la imagen: ");
                            imagenes[contador].nombreImagen = Convert.ToString(Console.ReadLine());

                            Console.Write("Introduzca el ancho de la imagen (en píxeles): ");
                            imagenes[contador].anchoImagen = Convert.ToUInt16(Console.ReadLine());

                            Console.Write("Introduzca el alto de la imagen (en píxeles): ");
                            imagenes[contador].altoImagen = Convert.ToUInt16(Console.ReadLine());

                            Console.Write("Introduzca el tamaño del archivo (en KB): ");
                            imagenes[contador].tamanoImagen = Convert.ToUInt16(Console.ReadLine());

                            contador++;
                        }

                        Console.WriteLine();

                        Console.Write("¿Qué desea hacer?: ");
                        accionUsuario = Convert.ToString(Console.ReadLine());

                        Console.WriteLine();

                        break;

                    case "ver":

                        Console.WriteLine("Has introducido las siguientes imágenes:");
                        Console.WriteLine("----------------------------------------");

                        for (int i=0;i<contador;i++)
                        {
                            Console.WriteLine("{0} {1}",i+1,imagenes[i].nombreImagen);
                        }

                        Console.WriteLine();

                        Console.Write("¿Qué desea hacer?: ");
                        accionUsuario = Convert.ToString(Console.ReadLine());

                        Console.WriteLine();

                        break;

                    case "buscar":

                        Console.Write("Introduzca una palabra o texto para buscar la imagen: ");
                        string encontrarImagen = Convert.ToString(Console.ReadLine());

                        Console.WriteLine();

                        for (int i = 0; i < contador; i++)
                        {
                            if (imagenes[i].nombreImagen.Contains(encontrarImagen))
                            {
                                Console.WriteLine("La imagen que ha buscado puede ser:");
                                Console.WriteLine("-----------------------------");
                                Console.WriteLine("Nombre de la imagen: {0}", imagenes[i].nombreImagen);
                                Console.WriteLine("Ancho de la imagen: {0} px", imagenes[i].anchoImagen);
                                Console.WriteLine("Alto de la imagen: {0} px", imagenes[i].altoImagen);
                                Console.WriteLine("Tamaño del fichero: {0} KB", imagenes[i].tamanoImagen);

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

using System;

namespace ejercicio_4_1_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[10];
            int longitud = 10;

            //Menú de operaciones.

            string anadirDatos = "añadir";
            string insertarDatos = "insertar";
            string borrarDatos = "borrar";
            string mostrarDatos = "mostrar";
            string salirPrograma = "salir";

            //Cantidad de nombres que el usuario quiere introducir.

            int cantidadNombres;

            //Orden que introduce el usuario para interactuar con el programa.

            string ordenUsuario;

            Console.WriteLine("El programa puede almacenar un máximo de 10 nombres. \nDespúes se le mostrará un menú que le permitirá interactuar con el programa.");

            Console.WriteLine();

            Console.Write("¿Cuántos nombres desea introducir?: ");
            cantidadNombres = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for(int i=0;i<cantidadNombres;i++)
            {
                Console.Write("Introduzca nombre: ");
                nombres[i] = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("Menú de operaciones:");

            Console.WriteLine();

            Console.WriteLine("Añadir un dato: \"añadir\" \nInsertar un dato: \"insertar\" \nBorrar un dato: \"borrar\" \nMostrar los datos: \"mostrar\" \nSalir del programa: \"salir\" ");

            Console.WriteLine();

            Console.Write("¿Qué desea hacer?: ");
            ordenUsuario = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

            while (ordenUsuario!="salir")
            {
                if (ordenUsuario=="añadir")
                {
                    Console.Write("Introduzca el nombre que desea añadir: ");
                    string nuevoNombre1 = Convert.ToString(Console.ReadLine()); //El nuevo nombre que el usuario desea añadir al array.

                    if(cantidadNombres<longitud)
                    {
                        nombres[cantidadNombres] = nuevoNombre1;
                        cantidadNombres++;
                    }
                }

                if(ordenUsuario=="insertar")
                {
                    Console.Write("Introduzca el nombre que desea añadir: ");
                    string nuevoNombre2 = Convert.ToString(Console.ReadLine()); //El nuevo nombre que el usuario desea añadir al array.

                    Console.Write("Introduzca la posición en la que desea insertar el nuevo dato: ");
                    int posicionInsertar = Convert.ToInt32(Console.ReadLine()); //Posición en la que el usuario desea insertar el nuevo dato.

                    for(int i=cantidadNombres;i>posicionInsertar;i--)
                    {
                        nombres[i] = nombres[i - 1];
                    }

                    nombres[posicionInsertar] = nuevoNombre2;
                    cantidadNombres++;
                }

                if(ordenUsuario=="borrar")
                {
                    Console.Write("Introduzca la posición que desea borrar: ");
                    int posicionBorrar = Convert.ToInt32(Console.ReadLine()); //Posición que el usuario desea borrar.

                    for(int j=posicionBorrar;j<cantidadNombres;j++)
                    {
                        nombres[j] = nombres[j + 1];
                    }

                    cantidadNombres++;
                }

                if(ordenUsuario=="mostrar")
                {
                    for(int k=0;k<cantidadNombres;k++)
                    {
                        Console.WriteLine("{0}", nombres[k]);
                    }
                }

                if(ordenUsuario=="salir")
                {
                    break;
                }

                Console.WriteLine();

                Console.Write("¿Qué desea hacer?: ");
                ordenUsuario = Convert.ToString(Console.ReadLine());

                Console.WriteLine();
            }
        }
    }
}

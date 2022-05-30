using System;

namespace ejercicio_4_3_1_1
{
    class Program
    {
        struct tipoCancion
        {
            public string artistaCancion;
            public string tituloCancion;
            public ushort duracionCancion;
            public ushort tamanoFichero;

        }

        public static void Main()
        {
            tipoCancion cancion;
            string tituloCancion;
            string artistaCancion;
            ushort duracionCancion;
            ushort tamanoFichero;


            Console.WriteLine("El programa le pedirá los datos de una canción. \nDespués los mostrará en pantalla.");

            Console.WriteLine();

            //El usuario introduce todos los datos que se le piden con respecto a la canción.

            Console.Write("Introduzca el título de la canción: ");
            tituloCancion = Convert.ToString(Console.ReadLine());

            Console.Write("Introduzca el autor de la canción: ");
            artistaCancion = Convert.ToString(Console.ReadLine());

            Console.Write("Introduzca la duración de la canción (en segundos): ");
            duracionCancion = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Introduzca el tamaño del fichero (en KB): ");
            tamanoFichero = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine();

            //Accedemos al registro. 

            cancion.tituloCancion = tituloCancion;
            cancion.artistaCancion = artistaCancion;
            cancion.duracionCancion = duracionCancion;
            cancion.tamanoFichero = tamanoFichero;

            //Mostramos los datos de la canción.

            Console.WriteLine("La información de la canción introducida es la siguiente:");
            Console.WriteLine("Título de la canción: {0} \nAutor de la canción: {1} \nDuración de la canción: {2} segundos \nTamaño del fichero de la canción: {3} KB", cancion.tituloCancion, cancion.artistaCancion, cancion.duracionCancion, cancion.tamanoFichero);


            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_7_2
{
    class Libro : Documento
    {
        protected int paginas;

        //Métodos Set y Get de 'paginas'.
        public void SetPaginas(int paginas)
        {
            this.paginas = paginas;
        }
        public int GetPaginas()
        {
            return this.paginas;
        }

        /*Constructor que permite dar valores
         al autor, al título y a la ubicación*/

        public Libro(string autor, string titulo, string ubicacion, int paginas)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.ubicacion = ubicacion;
            this.paginas = paginas;
        }

        public Libro(string autor, string titulo, int paginas)
        {
            this.autor = autor;
            this.titulo = titulo;
            ubicacion = "No detallada";
            this.paginas = paginas;
        }
    }
}

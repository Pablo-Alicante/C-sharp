using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8_3_5_wpf
{
    class Libro
    {
        protected string autor;
        protected string titulo;
        protected string ubicacion;

        //Métodos Set y Get de autor.
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }
        public string GetAutor()
        {
            return this.autor;
        }

        //Métodos Set y Get de titulo.
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string GetTitulo()
        {
            return this.titulo;
        }

        //Métodos Set y Get de ubicación.
        public void SetUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
        public string GetUbicacion()
        {
            return this.ubicacion;
        }
    }
}

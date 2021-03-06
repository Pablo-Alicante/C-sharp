using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_8_2
{
    class Documento
    {
        protected string autor;
        protected string titulo;
        protected string ubicacion;
        protected string mensaje = "Creando documento...";

        //Métodos Set y Get de 'autor'.
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }
        public string GetAutor()
        {
            return this.autor;
        }
        //Métodos Set y Get de 'titulo'.
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string GetTitulo()
        {
            return this.titulo;
        }
        //Métodos Set y Get de 'ubicacion'.
        public void SetUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
        public string GetUbicacion()
        {
            return this.ubicacion;
        }

        public string GetMensaje()
        {
            return this.mensaje;
        }
    }
}

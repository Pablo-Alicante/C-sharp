using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_5_2
{
    class Persona
    {
        protected string nombre;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string Saludar()
        {
            return "Hola soy " + this.nombre;
        }
    }
}

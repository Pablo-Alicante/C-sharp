using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_7_1
{
    class Persona
    {
        public string nombre;

        public Persona()
        {
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string Saludar()
        {
            return "Hola soy " + this.nombre;
        }
        public string Saludar(string texto)
        {
            return texto;
        }
    }
}

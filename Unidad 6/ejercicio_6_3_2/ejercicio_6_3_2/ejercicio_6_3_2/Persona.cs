using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ejercicio_6_3_2
{
    class Persona
    {
        public string nombre;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string Saludar()
        {
            return "Hola, soy " + this.nombre;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_6_1
{
    class PersonaInglesa : Persona
    {
        //Constructor con nombre prefijado.
        public PersonaInglesa()
        {
            nombre = "John";
        }

        //Constructor que permite escoger cualquier otro nombre.
        public PersonaInglesa(string nombre)
        {
            this.nombre = nombre;
        }

        public string TomarTe()
        {
            return "Estoy tomando té";
        }

        new public string Saludar()
        {
            return "Hi, I am " + this.nombre;
        }
    }
}

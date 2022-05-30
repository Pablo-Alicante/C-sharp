using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_6_1
{
    class PersonaItaliana : Persona
    {
        public PersonaItaliana()
        {
        }

        new public string Saludar()
        {
            return "Ciao";
        }
    }
}

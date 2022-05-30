using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_5_2
{
    class PersonaItaliana : Persona
    {
        new public string Saludar()
        {
            return "Ciao";
        }
    }
}

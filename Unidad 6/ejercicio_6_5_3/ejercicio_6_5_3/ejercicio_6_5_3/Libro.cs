using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_5_3
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
    }
}

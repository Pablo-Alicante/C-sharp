using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8_3_5_wpf
{
    class Documento : Libro
    {
        private int nPaginas;

        //Métodos Set y Get de páginas.
        public void SetPaginas(int nPaginas)
        {
            this.nPaginas = nPaginas;
        }
        public int GetPaginas()
        {
            return this.nPaginas;
        }
    }
}

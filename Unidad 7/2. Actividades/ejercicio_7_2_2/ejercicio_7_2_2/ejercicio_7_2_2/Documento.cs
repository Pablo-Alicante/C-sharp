using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_7_2_2
{
    class Documento : Libro
    {
        protected int nPaginas;

        //Métodos Set y Get del número de páginas.
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

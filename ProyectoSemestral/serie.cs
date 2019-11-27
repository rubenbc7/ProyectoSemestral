using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestral
{
    class serie
    {
        public string Titulo { get; set; }

        public serie(string titulo)
        {
            this.Titulo = titulo;
        }
        public override string ToString()
        {
            return this.Titulo;
        }
    }
}

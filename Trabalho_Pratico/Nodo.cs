using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Pratico
{
    public class Nodo
    {
        public Nodo seguinte;
        public Labirinto labirinto;

        public Nodo(Labirinto labirinto, Nodo seguinte)
        {
            this.labirinto = labirinto;
            this.seguinte = seguinte;
        }
    }
}

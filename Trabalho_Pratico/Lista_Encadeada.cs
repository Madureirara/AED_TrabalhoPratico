using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Pratico
{
    public class Lista_Encadeada
    {
        int[,] posicao;
        private Nodo head;
        private Nodo tail;       

        public Lista_Encadeada()
        {
            Labirinto labirinto = new Labirinto(posicao);
            this.head = new Nodo(labirinto, null);
            this.tail = head;
        }
    }
}

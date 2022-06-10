using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Pratico
{
    public class Labirinto
    {
        int x = 0;
        int y = 0;
        int[,] posicao= new int[0,0];
        public Labirinto(int[,] posicao)
        {
            this.posicao = posicao;
            this.x = posicao[x,0];
            this.y = posicao[0,y];
        }  
    }
}

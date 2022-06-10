using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Pratico
{
    class Pilha
    {
        int quantidade;
        NodoPilha topo;
        int[,] posicao;

        public Pilha()
        {
            topo = null;
        }
        public void Empilhar(int[,] posicao)
        {
            NodoPilha nodopilha = new NodoPilha(posicao, topo);
            topo = nodopilha;
            quantidade++;


        }
        public char Desempilhar()
        {
            char elementoremovido;

            if (topo == null)
            {
                Console.WriteLine("Erro pilha esta vazia");
            }

            elementoremovido = topo.elemento;
            topo = topo.seguinte;

            quantidade--;

            return elementoremovido;

        }
        public void Mostrar()
        {
            Console.Write("\n[ ");
            for (NodoPilha nodopilha = topo; nodopilha != null; nodopilha = nodopilha.seguinte)
            {
                Console.Write($"{nodopilha.elemento}, ");
            }
            Console.Write(" ]");

        }
    }
    class NodoPilha
    {
        public NodoPilha seguinte;
        public int[,] posicao;

        public NodoPilha(int[,] posicao, NodoPilha seguinte)
        {
            this.posicao = posicao;
            this.seguinte = seguinte;
        }

    }
}

using System;
using tabuleiro;
using Xadrez;

namespace Xadres
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);


            tab.ColocarPeca(new Rei(Cor.Preta,tab),new Posicao(1,3));

            tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 3));

            Tela.Tela.ImprimirTabuleiro(tab);

            

            Console.WriteLine();


        }
    }
}

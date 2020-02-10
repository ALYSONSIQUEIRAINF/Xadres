using System;
using tabuleiro;

namespace Xadres
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);

            Tela.Tela.ImprimirTabuleiro(tab);

            Console.WriteLine();


        }
    }
}

using System;
using tabuleiro;

namespace Xadres
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro t = new Tabuleiro(8,8);
            Posicao p = new Posicao(3,4);
            Console.WriteLine(p);
            Console.WriteLine("");

        }
    }
}

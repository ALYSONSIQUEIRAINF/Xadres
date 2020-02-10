using tabuleiro;

namespace Tela
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {               
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.peca(i, j) == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        System.Console.Write(tabuleiro.peca(i, j) + " ");
                    }

                }
                System.Console.WriteLine();
            }
        }
    }
}

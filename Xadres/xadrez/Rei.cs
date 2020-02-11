using tabuleiro;


namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tabuleiro) : base(tabuleiro, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}

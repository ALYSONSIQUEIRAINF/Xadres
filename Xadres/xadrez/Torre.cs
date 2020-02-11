using tabuleiro;


namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tabuleiro) : base(tabuleiro, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}

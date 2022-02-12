using Tabuleiro;

namespace Xadrez
{
    public class Torre : Peca
    {
        public Torre(Cor cor, TabuleiroX tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}

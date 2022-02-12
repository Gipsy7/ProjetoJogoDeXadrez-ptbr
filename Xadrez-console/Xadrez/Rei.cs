using Tabuleiro;

namespace Xadrez
{
    public class Rei : Peca
    {
        public Rei(Cor cor, TabuleiroX tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}

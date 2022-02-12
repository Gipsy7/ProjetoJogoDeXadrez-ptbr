namespace Tabuleiro
{
    public class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public TabuleiroX Tabuleiro { get; protected set; }

        public Peca(Cor cor, TabuleiroX tabuleiro)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QteMovimentos = 0;
        }
    }
}

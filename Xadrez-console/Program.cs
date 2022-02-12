using System;
using Tabuleiro;
using Xadrez;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*TabuleiroX tabuleiro = new TabuleiroX(8, 8);

                tabuleiro.ColocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(1, 8));
                tabuleiro.ColocarPeca(new Rei(Cor.Preta, tabuleiro), new Posicao(0, 2));


                Tela.ImprimirTabuleiro(tabuleiro);*/

                PosicaoXadrez posicaoXadrez = new PosicaoXadrez('c', 7);

                Console.WriteLine(posicaoXadrez);

                Console.WriteLine(posicaoXadrez.ToPosicao());
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

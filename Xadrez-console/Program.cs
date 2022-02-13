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
                PartidaDeXadrez partida = new PartidaDeXadrez();
                

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tabuleiro);
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }

                /*PosicaoXadrez posicaoXadrez = new PosicaoXadrez('c', 7);

                Console.WriteLine(posicaoXadrez);

                Console.WriteLine(posicaoXadrez.ToPosicao());*/
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

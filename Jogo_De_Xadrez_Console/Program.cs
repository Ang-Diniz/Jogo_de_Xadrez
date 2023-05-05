using System.Runtime.InteropServices;
using tabuleiro;
using xadrez;

namespace Jogo_De_Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("\nDigite a posição da peça que você quer mover: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("\nDigite a posição de destino da peça que você está movendo: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);
                }

                Tela.imprimirTabuleiro(partida.tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
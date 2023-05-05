using tabuleiro;
using xadrez;

namespace Jogo_De_Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez posicao = new PosicaoXadrez('a', 1);

            Console.WriteLine(posicao);

            Console.WriteLine(posicao.toPosicao());
            //try
            //{
            //    Tabuleiro tab = new Tabuleiro(8, 8);

            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
            //    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));

            //    Tela.imprimirTabuleiro(tab);

            //}
            //catch (TabuleiroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            Console.ReadLine();
        }
    }
}
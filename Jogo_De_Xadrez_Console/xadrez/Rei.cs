using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao posicao)
        {
            Peca p = tab.peca(posicao);
            return p == null || p.cor != this.cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao posicao = new Posicao(0, 0);

            posicao.definirValores(posicao.linha - 1, posicao.coluna);

            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha - 1, posicao.coluna + 1);

            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha, posicao.coluna + 1);

            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha + 1, posicao.coluna + 1);

            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha + 1, posicao.coluna);

            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha + 1, posicao.coluna - 1);

            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha, posicao.coluna - 1);

            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha - 1, posicao.coluna - 1);

            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }
            return mat;
        }
    }
}

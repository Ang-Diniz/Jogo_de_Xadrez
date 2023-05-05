using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "T";
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
            while (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;

                if (tab.peca(posicao) != null && tab.peca(posicao).cor != cor)
                {
                    break;
                }

                posicao.linha = posicao.linha - 1;
            }
            posicao.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;

                if (tab.peca(posicao) != null && tab.peca(posicao).cor != cor)
                {
                    break;
                }

                posicao.linha = posicao.linha + 1;
            }

            posicao.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;

                if (tab.peca(posicao) != null && tab.peca(posicao).cor != cor)
                {
                    break;
                }

                posicao.coluna = posicao.coluna + 1;
            }

            posicao.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;

                if (tab.peca(posicao) != null && tab.peca(posicao).cor != cor)
                {
                    break;
                }

                posicao.coluna = posicao.coluna - 1;
            }

            return mat;
        }
    }
}

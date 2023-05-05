﻿namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdeMovimentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null!;
            this.cor = cor;
            this.qtdeMovimentos = 0;
            this.tab = tab;
        }

        public void incrementarQtdeMovimentos()
        {
            qtdeMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}

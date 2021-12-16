﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linnha, int coluna)
        {
            Linha = linnha;
            Coluna = coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        public override string ToString()
        {
            return Linha
                + ", "
                + Coluna;
        }
    }
}

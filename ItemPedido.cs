using System;
using System.Collections.Generic;

namespace projetopedidos
{
    internal class ItemPedido
    {
        private string descricao;
        private double valor_unitario;
        private int quantidade;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public double Valor_Unitario
        {
            get { return valor_unitario; }
            set { valor_unitario = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
    }
  }
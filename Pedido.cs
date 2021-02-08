using System;
using System.Collections.Generic;
 
namespace projetopedidos
{
    internal class Pedido
    {
        private List<ItemPedido> itemPedido = new List<ItemPedido>(); 
        
        public List<ItemPedido> Itens {
            get { return itemPedido; }
            set { itemPedido = value; }
        } 
        
        public double totalpedido () 
        {
            double totalpedido = 0;

            foreach (ItemPedido item in itemPedido) 
            {
                Console.WriteLine(item.Descricao);
                totalpedido = totalpedido + item.Valor_Unitario*item.Quantidade;               
            }
            return totalpedido;
        }

    }
}
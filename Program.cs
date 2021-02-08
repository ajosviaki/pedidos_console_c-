using System;

namespace projetopedidos
{
    class Program
    {

        static void Main(string[] args)
        {
            string resposta = "s";
            //double totalpedido;
            Pedido pedido = new Pedido(); //instanciei um pedido, peguei uma classe e transformei em obejto//

            do
            {
                ItemPedido item = new ItemPedido();

                Console.WriteLine("Por favor informe a descrição do produto: ");
                item.Descricao = Console.ReadLine();
                Console.WriteLine("Por favor informe o valor do produto: ");
                item.Valor_Unitario = double.Parse(Console.ReadLine());
                Console.WriteLine("Por favor informe a quantidade do produto: ");
                item.Quantidade = int.Parse(Console.ReadLine());

                pedido.Itens.Add(item); //tudo o que foi add na lista

                Console.Write("Deseja inserir novo pedido (s/n)?");
                resposta = Console.ReadLine();

            } while (resposta == "s");

            double totalpedido = pedido.totalpedido();


            Console.WriteLine("O total do seu pedido é: R$ " + totalpedido);
            Console.WriteLine("Fim do programa.");
            Console.WriteLine("Obrigado.");

        }

    }
}

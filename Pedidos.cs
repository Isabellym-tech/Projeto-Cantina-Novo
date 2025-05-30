using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.cantinanovo
{
    internal class Pedidos
    {
        public string nome { get; set; }
        public string formaPagamento { get; set; } // forma de pagamento do pedido, pode ser dinheiro, cartão, etc.
        public bool viagem { get; set; } // se o pedido é para viagem ou não.

       

        public List<Produtos> produtos { get; set; }// lista que vai conter todos  os produtos do pedido.

        public Pedidos (string nome, List<Produtos> produtos) // meu construtor da classe pedidos, ele serve para criar objetos e inicializá-los 
        {
            // exige 2 parametros: nome do pedido e uma lista de produtos.
            this.nome = nome;
            this.produtos = produtos;
        }
    }
}

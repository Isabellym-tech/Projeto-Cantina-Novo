

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.cantinanovo
{

    internal class Produtos // torna essa classe visível apenas dentro do mesmo projeto/assembly.
    {
        private string Nome { get; set; } // encapsular atributos.
        private decimal Preco { get; set; } //  não podem ser acessadas de fora da classe diretamente, apenas através de métodos públicos.
        private int Quantidade { get; set; }

        public Produtos(string nome, decimal preco, int quantidade) // É o método especial que é chamado quando um novo objeto da classe é criado. -- ex, quando eu for criar os obejtos da cantina
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string GetNome() // permite acessar o nome do produto fora da classe.
        {
            return Nome;
        }

        public decimal GetPreco()
        {
            return Preco;
        }
        public int GetQuantidade()
        {
            return Quantidade;
        }
        public override string ToString() // método que retorna uma representação em string do objeto.
        {
            return $"{Nome} - R$ {Preco:F2}"; // formata o preço com duas casas decimais.
        }
    }
}





 
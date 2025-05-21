using System.Windows.Forms;

namespace Projeto.cantinanovo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AdicionarProduto();
            FormadePagamemto();
        }


        private decimal TotalPedido = 0;
        public void AdicionarProduto()
        {

            Produtos.Items.Add(new Produtos($"Pão de Queijo", 5.00m, 1));
            Produtos.Items.Add(new Produtos("X-Salada", 10.00m, 5));
            Produtos.Items.Add(new Produtos("X-Bacon", 12.00m, 3));
            Produtos.Items.Add(new Produtos("Refrigerante", 4.00m, 20));
            Produtos.Items.Add(new Produtos("Suco Natural", 6.00m, 15));
            Produtos.Items.Add(new Produtos("Água Mineral", 2.00m, 30));

        }

        public void FormadePagamemto()
        {
            pagamento.Items.Add("Dinheiro");
            pagamento.Items.Add("Cartão de Crédito");
            pagamento.Items.Add("Cartão de Débito");
            pagamento.Items.Add("Pix");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Adicionar_Click(object sender, EventArgs e)
        {
            // Verifica se o produto e a quantidade foram selecionados
            if (Produtos.SelectedItem != null)
            {
                Produtos produtoSelecionado = (Produtos)Produtos.SelectedItem;
                int quantidade = (int)Quantidade.Value;

                for (int i = 0; i < quantidade; i++)
                {
                    Pedido.Items.Add(produtoSelecionado);
                }

                decimal subtotal = produtoSelecionado.GetPreco() * quantidade;
                TotalPedido += subtotal;

                Total.Text = $"Total: R$ {TotalPedido:F2}";


            }

            else
            {
                MessageBox.Show("Selecione um produto e a quantidade para adicionar ao pedido.");
            }

        }

        private void Remover_Click(object sender, EventArgs e)
        {
            if (Pedido.SelectedIndex != -1 || Produtos.SelectedItem != null)
            {
                // pegando o produto selecionado, da classe produto
                Produtos produtoSelecionado = (Produtos)Pedido.SelectedItem;
                Pedido.Items.Remove(produtoSelecionado);
                TotalPedido -= produtoSelecionado.GetPreco();
                Total.Text = $"Total: R$ {TotalPedido:F2}";


            }


        }

        private void Local_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Viagem_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pagamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string opcaoSelecionada = pagamento.SelectedItem.ToString();

            if (opcaoSelecionada == "Cartão de Crédito" || opcaoSelecionada == "Cartão de Débito" || opcaoSelecionada == "Pix")
            {
                MessageBox.Show("Pedido realizado com sucesso! \nForma de pagamento: " + opcaoSelecionada, "Forma de Pagamento");
                nota.Visible = false;
            }

            else if (opcaoSelecionada == "Dinheiro");
            {
                nota.Visible = true;

            }

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Quantidade_ValueChanged(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nota_TextChanged(object sender, EventArgs e)
        {
            decimal valorNota;
            decimal troco = 0; 

            if (decimal.TryParse(nota.Text, out valorNota))
            {
                valorNota = decimal.Parse(nota.Text);
                Console.Write(valorNota);

                if (valorNota>= TotalPedido)
                {
                    troco = valorNota - TotalPedido;
                    MessageBox.Show($"Valor do pedido: {TotalPedido}, você me deu {valorNota} Troco: R$ {troco:F2}", "Troco");
                }

            }
        }
    }
}


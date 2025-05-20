using System.Windows.Forms;

namespace Projeto.cantinanovo
{
    public partial class Form1 : Form
    {
        private List<Produtos> produtos = new List<Produtos>();
        private List<Produtos> pedido = new List<Produtos>();
        public Form1()
        {
            InitializeComponent();
            AdicionarProduto();
            ListarProdutos();
            FormadePagamemto();
        }


        private decimal TotalPedido = 0;
        public void AdicionarProduto()
        {

            produtos.Add(new Produtos("Pão de Queijo", 5.00m, 10));
            produtos.Add(new Produtos("X-Salada", 10.00m, 5));
            produtos.Add(new Produtos("X-Bacon", 12.00m, 3));
            produtos.Add(new Produtos("Refrigerante", 4.00m, 20));
            produtos.Add(new Produtos("Suco Natural", 6.00m, 15));
            produtos.Add(new Produtos("Água Mineral", 2.00m, 30));

        }

        public void FormadePagamemto()
        {
            pagamento.Items.Add("Dinheiro");
            pagamento.Items.Add("Cartão de Crédito");
            pagamento.Items.Add("Cartão de Débito");
            pagamento.Items.Add("Pix");

            //pagamento.SelectedIndexChanged += pagamento_SelectedIndexChanged_1; // ? CORRETO

        }


        public void ListarProdutos()
        {
            Produtos.Items.Clear();
            foreach (var produto in produtos)
            {
                Produtos.Items.Add($"{produto.GetNome()} - {produto.GetPreco()}");
            }
        }

        public void ListarPedido()
        {
            Pedido.Items.Clear();
            foreach (var produto in pedido)
            {
                Pedido.Items.Add($"{produto.GetNome()} - {produto.GetPreco()}");
            }
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
            if (Produtos.SelectedIndex != -1)
            {
                var produtoSelecionado = produtos[Produtos.SelectedIndex];
                pedido.Add(produtoSelecionado);
                ListarPedido();
                this.TotalPedido += produtoSelecionado.GetPreco();
                Total.Text = $"Total: R$ {TotalPedido:F2}";
            }
        }

        private void Remover_Click(object sender, EventArgs e)
        {

        }

        private void Local_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Viagem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Pedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pedido.Items.Clear();
            foreach (var produto in pedido)
            {
                //listBox1.Items.Add($"{produto.GetNome()}-{produto.GetPreco()}"); não preciso diss por conta do to string
                Pedido.Items.Add(produto);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pagamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //string opcaoSelecionada = pagamento.SelectedItem.ToString();
            //MessageBox.Show("Você selecionou: " + opcaoSelecionada, "Forma de Pagamento");
        }
    }
}

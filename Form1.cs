using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto.cantinanovo
{
    public partial class Form1 : Form
    {
        //Produtos List<ListProduto> = new List<Produtos>();
        public Form1()
        {
            InitializeComponent();
            AdicionarProduto();
            FormadePagamemto();
            Quantidade.Minimum = 1;
            BackColor = Color.FromArgb(124, 122, 106);
            pictureBox1.BackColor = Color.FromArgb(230, 255, 0);
            pictureBox2.BackColor = Color.FromArgb(230, 255, 0);

            Produtos.BackColor = Color.FromArgb(202, 196, 183);
            Pedido.BackColor = Color.FromArgb(202, 196, 183);
            Color corTexto = Color.FromArgb(243, 241, 238);
            Total.BackColor = Color.FromArgb(230, 255, 0);
            finalizarPedido.BackColor = Color.FromArgb(230, 255, 0);
            label1.ForeColor = corTexto;
            label2.ForeColor = corTexto;
            label3.ForeColor = corTexto;
            label4.ForeColor = corTexto;
            Sim.ForeColor = corTexto;
            Não.ForeColor = corTexto;
            nome.ForeColor = corTexto;
            txtpagamento.ForeColor = corTexto;
            lblNota.ForeColor = corTexto;
            trocoMsg.ForeColor = corTexto;
            Quantidade.BackColor = Color.FromArgb(243, 241, 238);
            pagamento.BackColor = Color.FromArgb(243, 241, 238);
            nota.BackColor = Color.FromArgb(243, 241, 238);
            textBox1.BackColor = Color.FromArgb(243, 241, 238);




        }


        private decimal TotalPedido = 0;
        public void AdicionarProduto()
        {
            int quantidade = (int)Quantidade.Value;
            Produtos.Items.Add(new Produtos($"Pão de Queijo", 5.00m, quantidade));
            Produtos.Items.Add(new Produtos("Coxinha", 5.00m, quantidade));
            Produtos.Items.Add(new Produtos("Pastel de Carne", 6.00m, quantidade));
            Produtos.Items.Add(new Produtos("Pastel dequeijo", 5.50m, quantidade));
            Produtos.Items.Add(new Produtos("Suco Natural (300ml)", 4.00m, 15));
            Produtos.Items.Add(new Produtos("Refrigerante Lata", 4.50m, quantidade));
            Produtos.Items.Add(new Produtos("Hambúrguer Simples", 8.00m, quantidade));
            Produtos.Items.Add(new Produtos("Hambúrguer com Queijo", 9.00m, quantidade));
            Produtos.Items.Add(new Produtos("X-Tudo", 12.00m, quantidade));
            Produtos.Items.Add(new Produtos("Água Mineral (500ml)", 2.50m, quantidade));

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




                Pedido.Items.Add($"{produtoSelecionado.GetNome()} (x{quantidade})");



                decimal subtotal = produtoSelecionado.GetPreco() * quantidade;
                TotalPedido += subtotal;

                Total.Text = $"Total: R$ {TotalPedido:F2}";

                Quantidade.Value = 1; // Reseta a quantidade para 1 após adicionar o produto ao pedido


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



            if (opcaoSelecionada == "Dinheiro")
            {
                nota.Visible = true;
                lblNota.Visible = true;
                trocoMsg.Visible = true;




            }
            else
            {

                nota.Visible = false;
                lblNota.Visible = false;
                trocoMsg.Visible = false;
                // MessageBox.Show("Pedido realizado com sucesso! \nForma de pagamento: " + opcaoSelecionada, "Forma de Pagamento");

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

                if (valorNota >= TotalPedido)
                {
                    troco = valorNota - TotalPedido;
                    trocoMsg.Text = $"Troco: R$ {troco:F2}";
                }
                else
                {
                    trocoMsg.Text = "Valor insuficiente para o pagamento.";
                }


            }
        }

        private void Quantidade_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void finalizarPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Pedido realizado com sucesso! \nForma de pagamento: {pagamento.SelectedItem.ToString()}", "Forma de Pagamento");
        }

        private void label5_Click(object sender, EventArgs e)
        {


        }

        private void balcao_Click(object sender, EventArgs e)
        {
            Balcao minhaNovaJanela = new Balcao();
            minhaNovaJanela.Show(); // Exibe a nova janela
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.cantinanovo
{
    public partial class Balcao : Form
    {
        public Balcao()
        {
            InitializeComponent();
        }

        //public void AdicionarPedidos(Pedidos pedido)
        //{
        //    // Criar um item para adicionar na listViewPedidos
        //    ListViewItem item = new ListViewItem(pedido.nome);

        //    // Adicionar os produtos do pedido na listView, se necessário
        //    foreach (var produto in pedido.produtos)
        //    {
        //        item.SubItems.Add(produto.GetNome());
        //        item.SubItems.Add(produto.GetPreco().ToString("F2"));
        //    }

        //    // Adicionar o item na ListView
        //    Pedidos.Items.Add(item);
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listViewPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}

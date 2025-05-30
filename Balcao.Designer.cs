namespace Projeto.cantinanovo
{
    partial class Balcao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            statusStrip2 = new StatusStrip();
            Pedidos = new ListView();
            listView2 = new ListView();
            panel1 = new Panel();
            tipoPedido = new Label();
            formaPagamento = new Label();
            dataHora = new Label();
            fecharDetalhes = new Button();
            Cliente = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            botaoEntregar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 602);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1309, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip2
            // 
            statusStrip2.Location = new Point(0, 580);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(1309, 22);
            statusStrip2.TabIndex = 3;
            statusStrip2.Text = "statusStrip2";
            // 
            // Pedidos
            // 
            Pedidos.Location = new Point(56, 71);
            Pedidos.Name = "Pedidos";
            Pedidos.Size = new Size(361, 444);
            Pedidos.TabIndex = 4;
            Pedidos.UseCompatibleStateImageBehavior = false;
            Pedidos.SelectedIndexChanged += listViewPedidos_SelectedIndexChanged;
            // 
            // listView2
            // 
            listView2.Location = new Point(841, 71);
            listView2.Name = "listView2";
            listView2.Size = new Size(339, 430);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(tipoPedido);
            panel1.Controls.Add(formaPagamento);
            panel1.Controls.Add(dataHora);
            panel1.Controls.Add(fecharDetalhes);
            panel1.Controls.Add(Cliente);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(451, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 298);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // tipoPedido
            // 
            tipoPedido.AutoSize = true;
            tipoPedido.Location = new Point(21, 85);
            tipoPedido.Name = "tipoPedido";
            tipoPedido.Size = new Size(34, 15);
            tipoPedido.TabIndex = 13;
            tipoPedido.Text = "Tipo:";
            // 
            // formaPagamento
            // 
            formaPagamento.AutoSize = true;
            formaPagamento.Location = new Point(21, 60);
            formaPagamento.Name = "formaPagamento";
            formaPagamento.Size = new Size(124, 15);
            formaPagamento.TabIndex = 12;
            formaPagamento.Text = "Forma de Pagamento:";
            // 
            // dataHora
            // 
            dataHora.AutoSize = true;
            dataHora.Location = new Point(19, 36);
            dataHora.Name = "dataHora";
            dataHora.Size = new Size(65, 15);
            dataHora.TabIndex = 11;
            dataHora.Text = "Data/Hora:";
            // 
            // fecharDetalhes
            // 
            fecharDetalhes.Location = new Point(175, 244);
            fecharDetalhes.Name = "fecharDetalhes";
            fecharDetalhes.Size = new Size(126, 22);
            fecharDetalhes.TabIndex = 10;
            fecharDetalhes.Text = "Fechar Detalhes";
            fecharDetalhes.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(14, 10);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(47, 15);
            Cliente.TabIndex = 9;
            Cliente.Text = "Cliente:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(21, 128);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(132, 76);
            checkedListBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(21, 244);
            button1.Name = "button1";
            button1.Size = new Size(115, 22);
            button1.TabIndex = 7;
            button1.Text = "Entregar Pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // botaoEntregar
            // 
            botaoEntregar.Location = new Point(441, 93);
            botaoEntregar.Name = "botaoEntregar";
            botaoEntregar.Size = new Size(146, 50);
            botaoEntregar.TabIndex = 7;
            botaoEntregar.Text = "Entregar";
            botaoEntregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(56, 33);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 8;
            label1.Text = "Lista de Pedidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(841, 33);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 9;
            label2.Text = "Pedidos Entregues";
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 624);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botaoEntregar);
            Controls.Add(panel1);
            Controls.Add(listView2);
            Controls.Add(Pedidos);
            Controls.Add(statusStrip2);
            Controls.Add(statusStrip1);
            Name = "Balcao";
            Text = "Balcao";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private StatusStrip statusStrip2;
        private ListView Pedidos;
        private ListView listView2;
        private Panel panel1;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private Button botaoEntregar;
        private Label Cliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button fecharDetalhes;
        private Label tipoPedido;
        private Label formaPagamento;
        private Label dataHora;
        private Label label1;
        private Label label2;
    }
}
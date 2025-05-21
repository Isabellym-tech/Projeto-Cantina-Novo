namespace Projeto.cantinanovo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Produtos = new ListBox();
            label1 = new Label();
            Adicionar = new Button();
            Remover = new Button();
            txtpagamento = new Label();
            textBox1 = new TextBox();
            nome = new Label();
            Sim = new CheckBox();
            Não = new CheckBox();
            label2 = new Label();
            Pedido = new ListBox();
            Total = new Label();
            pagamento = new ComboBox();
            Quantidade = new NumericUpDown();
            label3 = new Label();
            nota = new TextBox();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)Quantidade).BeginInit();
            SuspendLayout();
            // 
            // Produtos
            // 
            Produtos.FormattingEnabled = true;
            Produtos.ItemHeight = 15;
            Produtos.Location = new Point(61, 91);
            Produtos.Name = "Produtos";
            Produtos.Size = new Size(227, 244);
            Produtos.TabIndex = 0;
            Produtos.SelectedIndexChanged += Produtos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 73);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 2;
            label1.Text = "Cardapio";
            // 
            // Adicionar
            // 
            Adicionar.Location = new Point(300, 94);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(130, 41);
            Adicionar.TabIndex = 3;
            Adicionar.Text = "Adicionar ";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // Remover
            // 
            Remover.Location = new Point(300, 161);
            Remover.Name = "Remover";
            Remover.Size = new Size(130, 51);
            Remover.TabIndex = 4;
            Remover.Text = "Remover";
            Remover.UseVisualStyleBackColor = true;
            Remover.Click += Remover_Click;
            // 
            // txtpagamento
            // 
            txtpagamento.AutoSize = true;
            txtpagamento.Location = new Point(791, 141);
            txtpagamento.Name = "txtpagamento";
            txtpagamento.Size = new Size(171, 15);
            txtpagamento.TabIndex = 8;
            txtpagamento.Text = "Escolha a forma de pagamento";
            txtpagamento.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(61, 45);
            nome.Name = "nome";
            nome.Size = new Size(107, 15);
            nome.TabIndex = 10;
            nome.Text = "Coloque seu nome";
            nome.Click += label2_Click_1;
            // 
            // Sim
            // 
            Sim.AutoSize = true;
            Sim.Location = new Point(559, 380);
            Sim.Name = "Sim";
            Sim.Size = new Size(46, 19);
            Sim.TabIndex = 11;
            Sim.Text = "Sim";
            Sim.UseVisualStyleBackColor = true;
            Sim.CheckedChanged += Local_CheckedChanged;
            // 
            // Não
            // 
            Não.AutoSize = true;
            Não.Location = new Point(559, 405);
            Não.Name = "Não";
            Não.Size = new Size(48, 19);
            Não.TabIndex = 12;
            Não.Text = "Não";
            Não.UseVisualStyleBackColor = true;
            Não.CheckedChanged += Viagem_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(559, 348);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 13;
            label2.Text = "É para viagem?";
            // 
            // Pedido
            // 
            Pedido.FormattingEnabled = true;
            Pedido.ItemHeight = 15;
            Pedido.Location = new Point(559, 91);
            Pedido.Name = "Pedido";
            Pedido.Size = new Size(182, 229);
            Pedido.TabIndex = 14;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Font = new Font("Segoe UI", 18F);
            Total.Location = new Point(791, 91);
            Total.Name = "Total";
            Total.Size = new Size(65, 32);
            Total.TabIndex = 15;
            Total.Text = "Total";
            Total.Click += label3_Click;
            // 
            // pagamento
            // 
            pagamento.FormattingEnabled = true;
            pagamento.Location = new Point(791, 176);
            pagamento.Name = "pagamento";
            pagamento.Size = new Size(131, 23);
            pagamento.TabIndex = 16;
            pagamento.SelectedIndexChanged += pagamento_SelectedIndexChanged_1;
            // 
            // Quantidade
            // 
            Quantidade.Location = new Point(60, 376);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(228, 23);
            Quantidade.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 348);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 18;
            label3.Text = "Selecione a quantidade";
            label3.Click += label3_Click_1;
            // 
            // nota
            // 
            nota.Location = new Point(791, 259);
            nota.Name = "nota";
            nota.Size = new Size(131, 23);
            nota.TabIndex = 19;
            nota.TextChanged += nota_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(791, 241);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 20;
            label4.Text = "Informe o valor do dinheiro";
            label4.Click += label4_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 450);
            Controls.Add(label4);
            Controls.Add(nota);
            Controls.Add(label3);
            Controls.Add(Quantidade);
            Controls.Add(pagamento);
            Controls.Add(Total);
            Controls.Add(Pedido);
            Controls.Add(label2);
            Controls.Add(Não);
            Controls.Add(Sim);
            Controls.Add(nome);
            Controls.Add(textBox1);
            Controls.Add(txtpagamento);
            Controls.Add(Remover);
            Controls.Add(Adicionar);
            Controls.Add(label1);
            Controls.Add(Produtos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Produtos;
        private Label label1;
        private Button Adicionar;
        private Button Remover;
        private Label txtpagamento;
        private TextBox textBox1;
        private Label nome;
        private CheckBox Sim;
        private CheckBox Não;
        private Label label2;
        private ListBox Pedido;
        private Label Total;
        private ComboBox pagamento;
        private NumericUpDown Quantidade;
        private Label label3;
        private TextBox nota;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
    }
}

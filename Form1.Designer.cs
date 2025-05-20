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
            Produtos = new ListBox();
            label1 = new Label();
            Adicionar = new Button();
            Remover = new Button();
            button3 = new Button();
            Adiconarq = new Button();
            Diminuirq = new Button();
            txtpagamento = new Label();
            textBox1 = new TextBox();
            nome = new Label();
            Local = new CheckBox();
            Viagem = new CheckBox();
            label2 = new Label();
            Pedido = new ListBox();
            Total = new Label();
            pagamento = new ComboBox();
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
            // button3
            // 
            button3.Location = new Point(299, 235);
            button3.Name = "button3";
            button3.Size = new Size(131, 54);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Adiconarq
            // 
            Adiconarq.Location = new Point(447, 105);
            Adiconarq.Name = "Adiconarq";
            Adiconarq.Size = new Size(28, 30);
            Adiconarq.TabIndex = 6;
            Adiconarq.Text = "+";
            Adiconarq.UseVisualStyleBackColor = true;
            // 
            // Diminuirq
            // 
            Diminuirq.Location = new Point(481, 107);
            Diminuirq.Name = "Diminuirq";
            Diminuirq.Size = new Size(28, 26);
            Diminuirq.TabIndex = 7;
            Diminuirq.Text = " -";
            Diminuirq.UseVisualStyleBackColor = true;
            // 
            // txtpagamento
            // 
            txtpagamento.AutoSize = true;
            txtpagamento.Location = new Point(797, 61);
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
            nome.Location = new Point(61, 40);
            nome.Name = "nome";
            nome.Size = new Size(107, 15);
            nome.TabIndex = 10;
            nome.Text = "Coloque seu nome";
            nome.Click += label2_Click_1;
            // 
            // Local
            // 
            Local.AutoSize = true;
            Local.Location = new Point(1080, 91);
            Local.Name = "Local";
            Local.Size = new Size(54, 19);
            Local.TabIndex = 11;
            Local.Text = "Local";
            Local.UseVisualStyleBackColor = true;
            Local.CheckedChanged += Local_CheckedChanged;
            // 
            // Viagem
            // 
            Viagem.AutoSize = true;
            Viagem.Location = new Point(1080, 116);
            Viagem.Name = "Viagem";
            Viagem.Size = new Size(66, 19);
            Viagem.TabIndex = 12;
            Viagem.Text = "Viagem";
            Viagem.UseVisualStyleBackColor = true;
            Viagem.CheckedChanged += Viagem_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1036, 61);
            label2.Name = "label2";
            label2.Size = new Size(193, 15);
            label2.TabIndex = 13;
            label2.Text = "Selecione se é para viagem ou local";
            // 
            // Pedido
            // 
            Pedido.FormattingEnabled = true;
            Pedido.ItemHeight = 15;
            Pedido.Location = new Point(559, 91);
            Pedido.Name = "Pedido";
            Pedido.Size = new Size(182, 229);
            Pedido.TabIndex = 14;
            Pedido.SelectedIndexChanged += Pedido_SelectedIndexChanged;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(558, 337);
            Total.Name = "Total";
            Total.Size = new Size(33, 15);
            Total.TabIndex = 15;
            Total.Text = "Total";
            Total.Click += label3_Click;
            // 
            // pagamento
            // 
            pagamento.FormattingEnabled = true;
            pagamento.Location = new Point(797, 104);
            pagamento.Name = "pagamento";
            pagamento.Size = new Size(131, 23);
            pagamento.TabIndex = 16;
            pagamento.SelectedIndexChanged += pagamento_SelectedIndexChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 450);
            Controls.Add(pagamento);
            Controls.Add(Total);
            Controls.Add(Pedido);
            Controls.Add(label2);
            Controls.Add(Viagem);
            Controls.Add(Local);
            Controls.Add(nome);
            Controls.Add(textBox1);
            Controls.Add(txtpagamento);
            Controls.Add(Diminuirq);
            Controls.Add(Adiconarq);
            Controls.Add(button3);
            Controls.Add(Remover);
            Controls.Add(Adicionar);
            Controls.Add(label1);
            Controls.Add(Produtos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Produtos;
        private Label label1;
        private Button Adicionar;
        private Button Remover;
        private Button button3;
        private Button Adiconarq;
        private Button Diminuirq;
        private Label txtpagamento;
        private TextBox textBox1;
        private Label nome;
        private CheckBox Local;
        private CheckBox Viagem;
        private Label label2;
        private ListBox Pedido;
        private Label Total;
        private ComboBox pagamento;
    }
}

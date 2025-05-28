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
            lblNota = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label4 = new Label();
            finalizarPedido = new Button();
            trocoMsg = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            balcao = new Button();
            ((System.ComponentModel.ISupportInitialize)Quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Produtos
            // 
            Produtos.FormattingEnabled = true;
            Produtos.ItemHeight = 15;
            Produtos.Location = new Point(51, 172);
            Produtos.Name = "Produtos";
            Produtos.Size = new Size(227, 244);
            Produtos.TabIndex = 0;
            Produtos.SelectedIndexChanged += Produtos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 148);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 2;
            label1.Text = "Cardápio";
            // 
            // Adicionar
            // 
            Adicionar.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Adicionar.Location = new Point(300, 267);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(130, 53);
            Adicionar.TabIndex = 3;
            Adicionar.Text = "Adicionar ";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // Remover
            // 
            Remover.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            Remover.Location = new Point(301, 333);
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
            txtpagamento.Font = new Font("Agrandir", 14F, FontStyle.Bold);
            txtpagamento.Location = new Point(948, 169);
            txtpagamento.Name = "txtpagamento";
            txtpagamento.Size = new Size(286, 25);
            txtpagamento.TabIndex = 8;
            txtpagamento.Text = "Escolha a forma de pagamento:";
            txtpagamento.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nome.Location = new Point(51, 95);
            nome.Name = "nome";
            nome.Size = new Size(150, 21);
            nome.TabIndex = 10;
            nome.Text = "Coloque seu nome:";
            nome.Click += label2_Click_1;
            // 
            // Sim
            // 
            Sim.AutoSize = true;
            Sim.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sim.Location = new Point(775, 172);
            Sim.Name = "Sim";
            Sim.Size = new Size(57, 25);
            Sim.TabIndex = 11;
            Sim.Text = "Sim";
            Sim.UseVisualStyleBackColor = true;
            Sim.CheckedChanged += Local_CheckedChanged;
            // 
            // Não
            // 
            Não.AutoSize = true;
            Não.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Não.Location = new Point(775, 197);
            Não.Name = "Não";
            Não.Size = new Size(58, 25);
            Não.TabIndex = 12;
            Não.Text = "Não";
            Não.UseVisualStyleBackColor = true;
            Não.CheckedChanged += Viagem_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            label2.Location = new Point(775, 148);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 13;
            label2.Text = "É para viagem?";
            // 
            // Pedido
            // 
            Pedido.FormattingEnabled = true;
            Pedido.ItemHeight = 15;
            Pedido.Location = new Point(559, 172);
            Pedido.Name = "Pedido";
            Pedido.Size = new Size(182, 244);
            Pedido.TabIndex = 14;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Font = new Font("Agrandir", 20F, FontStyle.Bold);
            Total.Location = new Point(948, 120);
            Total.Name = "Total";
            Total.Size = new Size(79, 36);
            Total.TabIndex = 15;
            Total.Text = "Total";
            Total.Click += label3_Click;
            // 
            // pagamento
            // 
            pagamento.FormattingEnabled = true;
            pagamento.Location = new Point(952, 197);
            pagamento.Name = "pagamento";
            pagamento.Size = new Size(131, 23);
            pagamento.TabIndex = 16;
            pagamento.SelectedIndexChanged += pagamento_SelectedIndexChanged_1;
            // 
            // Quantidade
            // 
            Quantidade.Location = new Point(301, 185);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(149, 23);
            Quantidade.TabIndex = 17;
            Quantidade.ValueChanged += Quantidade_ValueChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            label3.Location = new Point(300, 148);
            label3.Name = "label3";
            label3.Size = new Size(182, 21);
            label3.TabIndex = 18;
            label3.Text = "Selecione a quantidade";
            label3.Click += label3_Click_1;
            // 
            // nota
            // 
            nota.Location = new Point(953, 280);
            nota.Name = "nota";
            nota.Size = new Size(131, 23);
            nota.TabIndex = 19;
            nota.Visible = false;
            nota.TextChanged += nota_TextChanged;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Agrandir", 14F, FontStyle.Bold);
            lblNota.Location = new Point(953, 252);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(253, 25);
            lblNota.TabIndex = 20;
            lblNota.Text = "Informe o valor do dinheiro:";
            lblNota.Visible = false;
            lblNota.Click += label4_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agrandir", 12F, FontStyle.Bold);
            label4.Location = new Point(592, 145);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 21;
            label4.Text = "Pedido do Cliente";
            // 
            // finalizarPedido
            // 
            finalizarPedido.Font = new Font("Agrandir", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finalizarPedido.Location = new Point(953, 382);
            finalizarPedido.Name = "finalizarPedido";
            finalizarPedido.Size = new Size(200, 78);
            finalizarPedido.TabIndex = 22;
            finalizarPedido.Text = "Finalizar Pedido";
            finalizarPedido.UseVisualStyleBackColor = true;
            finalizarPedido.Click += finalizarPedido_Click;
            // 
            // trocoMsg
            // 
            trocoMsg.AutoSize = true;
            trocoMsg.Font = new Font("Agrandir", 12.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            trocoMsg.Location = new Point(953, 317);
            trocoMsg.Name = "trocoMsg";
            trocoMsg.Size = new Size(60, 23);
            trocoMsg.TabIndex = 23;
            trocoMsg.Text = "Troco:";
            trocoMsg.Visible = false;
            trocoMsg.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(-4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1233, 60);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_tela_2025_05_23_103749;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Design_sem_nome__1__removebg_preview__1_;
            pictureBox3.Location = new Point(559, 139);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // balcao
            // 
            balcao.Location = new Point(979, 490);
            balcao.Name = "balcao";
            balcao.Size = new Size(143, 35);
            balcao.TabIndex = 27;
            balcao.Text = "Balcão";
            balcao.UseVisualStyleBackColor = true;
            balcao.Click += balcao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 554);
            Controls.Add(balcao);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(trocoMsg);
            Controls.Add(finalizarPedido);
            Controls.Add(label4);
            Controls.Add(lblNota);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label lblNota;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private Button finalizarPedido;
        private Label trocoMsg;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button balcao;
    }
}

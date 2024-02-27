namespace SistemaFarmacia
{
    partial class AtualizarProduto
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
            this.campoQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.campoPreco = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.botaoAtualizar = new System.Windows.Forms.Button();
            this.campoDescricao = new System.Windows.Forms.TextBox();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoDeletar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.campoCodigo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // campoQuantidade
            // 
            this.campoQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoQuantidade.Location = new System.Drawing.Point(127, 270);
            this.campoQuantidade.Mask = "99999";
            this.campoQuantidade.Name = "campoQuantidade";
            this.campoQuantidade.Size = new System.Drawing.Size(284, 26);
            this.campoQuantidade.TabIndex = 38;
            this.campoQuantidade.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.campoQuantidade_MaskInputRejected);
            // 
            // campoPreco
            // 
            this.campoPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPreco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.campoPreco.Location = new System.Drawing.Point(90, 173);
            this.campoPreco.Mask = "99999,99";
            this.campoPreco.Name = "campoPreco";
            this.campoPreco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campoPreco.Size = new System.Drawing.Size(322, 26);
            this.campoPreco.TabIndex = 35;
            this.campoPreco.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.campoPreco_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Preço";
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.Location = new System.Drawing.Point(292, 380);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(121, 53);
            this.botaoVoltar.TabIndex = 42;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // botaoAtualizar
            // 
            this.botaoAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAtualizar.Location = new System.Drawing.Point(19, 380);
            this.botaoAtualizar.Name = "botaoAtualizar";
            this.botaoAtualizar.Size = new System.Drawing.Size(121, 53);
            this.botaoAtualizar.TabIndex = 39;
            this.botaoAtualizar.Text = "Atualizar";
            this.botaoAtualizar.UseVisualStyleBackColor = true;
            this.botaoAtualizar.Click += new System.EventHandler(this.botaoAtualizar_Click);
            // 
            // campoDescricao
            // 
            this.campoDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDescricao.Location = new System.Drawing.Point(127, 219);
            this.campoDescricao.Name = "campoDescricao";
            this.campoDescricao.Size = new System.Drawing.Size(286, 26);
            this.campoDescricao.TabIndex = 36;
            this.campoDescricao.TextChanged += new System.EventHandler(this.campoDescricao_TextChanged);
            // 
            // campoNome
            // 
            this.campoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(90, 124);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(323, 26);
            this.campoNome.TabIndex = 34;
            this.campoNome.TextChanged += new System.EventHandler(this.campoNome_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Dados do Produto";
            // 
            // botaoDeletar
            // 
            this.botaoDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDeletar.Location = new System.Drawing.Point(156, 380);
            this.botaoDeletar.Name = "botaoDeletar";
            this.botaoDeletar.Size = new System.Drawing.Size(121, 53);
            this.botaoDeletar.TabIndex = 40;
            this.botaoDeletar.Text = "Deletar";
            this.botaoDeletar.UseVisualStyleBackColor = true;
            this.botaoDeletar.Click += new System.EventHandler(this.botaoDeletar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Código";
            // 
            // campoCodigo
            // 
            this.campoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.campoCodigo.Location = new System.Drawing.Point(90, 82);
            this.campoCodigo.Mask = "99999";
            this.campoCodigo.Name = "campoCodigo";
            this.campoCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campoCodigo.Size = new System.Drawing.Size(323, 26);
            this.campoCodigo.TabIndex = 33;
            this.campoCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.campoCodigo_MaskInputRejected);
            // 
            // AtualizarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.campoCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botaoDeletar);
            this.Controls.Add(this.campoQuantidade);
            this.Controls.Add(this.campoPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.botaoAtualizar);
            this.Controls.Add(this.campoDescricao);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AtualizarProduto";
            this.Text = "AtualizarProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Button botaoAtualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoDeletar;
        public System.Windows.Forms.MaskedTextBox campoQuantidade;
        public System.Windows.Forms.MaskedTextBox campoPreco;
        public System.Windows.Forms.TextBox campoDescricao;
        public System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox campoCodigo;
    }
}
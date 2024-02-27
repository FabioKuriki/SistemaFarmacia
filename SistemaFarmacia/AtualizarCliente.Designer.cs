namespace SistemaFarmacia
{
    partial class AtualizarCliente
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
            this.caixaNaoDois = new System.Windows.Forms.CheckBox();
            this.caixaSimDois = new System.Windows.Forms.CheckBox();
            this.caixaNao = new System.Windows.Forms.CheckBox();
            this.caixaSim = new System.Windows.Forms.CheckBox();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.botaoAtualizar = new System.Windows.Forms.Button();
            this.campoFarmaciaPopular = new System.Windows.Forms.TextBox();
            this.campoPlanoSaude = new System.Windows.Forms.TextBox();
            this.campoTelefone = new System.Windows.Forms.MaskedTextBox();
            this.campoRg = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.campoCpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoDeletar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // caixaNaoDois
            // 
            this.caixaNaoDois.AutoSize = true;
            this.caixaNaoDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixaNaoDois.Location = new System.Drawing.Point(308, 388);
            this.caixaNaoDois.Name = "caixaNaoDois";
            this.caixaNaoDois.Size = new System.Drawing.Size(70, 29);
            this.caixaNaoDois.TabIndex = 86;
            this.caixaNaoDois.Text = "Não";
            this.caixaNaoDois.UseVisualStyleBackColor = true;
            this.caixaNaoDois.CheckedChanged += new System.EventHandler(this.caixaNaoDois_CheckedChanged);
            // 
            // caixaSimDois
            // 
            this.caixaSimDois.AutoSize = true;
            this.caixaSimDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixaSimDois.Location = new System.Drawing.Point(197, 388);
            this.caixaSimDois.Name = "caixaSimDois";
            this.caixaSimDois.Size = new System.Drawing.Size(67, 29);
            this.caixaSimDois.TabIndex = 85;
            this.caixaSimDois.Text = "Sim";
            this.caixaSimDois.UseVisualStyleBackColor = true;
            this.caixaSimDois.CheckedChanged += new System.EventHandler(this.caixaSimDois_CheckedChanged);
            // 
            // caixaNao
            // 
            this.caixaNao.AutoSize = true;
            this.caixaNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixaNao.Location = new System.Drawing.Point(308, 288);
            this.caixaNao.Name = "caixaNao";
            this.caixaNao.Size = new System.Drawing.Size(70, 29);
            this.caixaNao.TabIndex = 83;
            this.caixaNao.Text = "Não";
            this.caixaNao.UseVisualStyleBackColor = true;
            this.caixaNao.CheckedChanged += new System.EventHandler(this.caixaNao_CheckedChanged);
            // 
            // caixaSim
            // 
            this.caixaSim.AutoSize = true;
            this.caixaSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixaSim.Location = new System.Drawing.Point(197, 288);
            this.caixaSim.Name = "caixaSim";
            this.caixaSim.Size = new System.Drawing.Size(67, 29);
            this.caixaSim.TabIndex = 82;
            this.caixaSim.Text = "Sim";
            this.caixaSim.UseVisualStyleBackColor = true;
            this.caixaSim.CheckedChanged += new System.EventHandler(this.caixaSim_CheckedChanged);
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.Location = new System.Drawing.Point(314, 486);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(108, 53);
            this.botaoVoltar.TabIndex = 90;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // botaoAtualizar
            // 
            this.botaoAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAtualizar.Location = new System.Drawing.Point(32, 486);
            this.botaoAtualizar.Name = "botaoAtualizar";
            this.botaoAtualizar.Size = new System.Drawing.Size(108, 53);
            this.botaoAtualizar.TabIndex = 88;
            this.botaoAtualizar.Text = "Atualizar";
            this.botaoAtualizar.UseVisualStyleBackColor = true;
            this.botaoAtualizar.Click += new System.EventHandler(this.botaoAtualizar_Click);
            // 
            // campoFarmaciaPopular
            // 
            this.campoFarmaciaPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFarmaciaPopular.Location = new System.Drawing.Point(32, 435);
            this.campoFarmaciaPopular.Name = "campoFarmaciaPopular";
            this.campoFarmaciaPopular.Size = new System.Drawing.Size(390, 26);
            this.campoFarmaciaPopular.TabIndex = 87;
            this.campoFarmaciaPopular.TextChanged += new System.EventHandler(this.campoFarmaciaPopular_TextChanged);
            // 
            // campoPlanoSaude
            // 
            this.campoPlanoSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPlanoSaude.Location = new System.Drawing.Point(32, 334);
            this.campoPlanoSaude.Name = "campoPlanoSaude";
            this.campoPlanoSaude.Size = new System.Drawing.Size(390, 26);
            this.campoPlanoSaude.TabIndex = 84;
            this.campoPlanoSaude.TextChanged += new System.EventHandler(this.campoPlanoSaude_TextChanged);
            // 
            // campoTelefone
            // 
            this.campoTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTelefone.Location = new System.Drawing.Point(113, 226);
            this.campoTelefone.Mask = "(99) 99999-9999";
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(309, 26);
            this.campoTelefone.TabIndex = 81;
            this.campoTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.campoTelefone_MaskInputRejected);
            // 
            // campoRg
            // 
            this.campoRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoRg.Location = new System.Drawing.Point(89, 173);
            this.campoRg.Mask = "99.999.999-9";
            this.campoRg.Name = "campoRg";
            this.campoRg.Size = new System.Drawing.Size(330, 26);
            this.campoRg.TabIndex = 80;
            this.campoRg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.campoRg_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 79;
            this.label6.Text = "Farmácia Popular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Plano de Saúde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "RG";
            // 
            // campoCpf
            // 
            this.campoCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCpf.Location = new System.Drawing.Point(89, 123);
            this.campoCpf.Mask = "999.999.999-99";
            this.campoCpf.Name = "campoCpf";
            this.campoCpf.Size = new System.Drawing.Size(330, 26);
            this.campoCpf.TabIndex = 75;
            this.campoCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.campoCpf_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "CPF";
            // 
            // campoNome
            // 
            this.campoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(89, 70);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(333, 26);
            this.campoNome.TabIndex = 73;
            this.campoNome.TextChanged += new System.EventHandler(this.campoNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 71;
            this.label1.Text = "Dados do Cliente";
            // 
            // botaoDeletar
            // 
            this.botaoDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDeletar.Location = new System.Drawing.Point(174, 486);
            this.botaoDeletar.Name = "botaoDeletar";
            this.botaoDeletar.Size = new System.Drawing.Size(108, 53);
            this.botaoDeletar.TabIndex = 89;
            this.botaoDeletar.Text = "Deletar";
            this.botaoDeletar.UseVisualStyleBackColor = true;
            this.botaoDeletar.Click += new System.EventHandler(this.botaoDeletar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SistemaFarmacia.Properties.Resources._126510;
            this.pictureBox4.Location = new System.Drawing.Point(181, 555);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 91;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // AtualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 650);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.botaoDeletar);
            this.Controls.Add(this.caixaNaoDois);
            this.Controls.Add(this.caixaSimDois);
            this.Controls.Add(this.caixaNao);
            this.Controls.Add(this.caixaSim);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.botaoAtualizar);
            this.Controls.Add(this.campoFarmaciaPopular);
            this.Controls.Add(this.campoPlanoSaude);
            this.Controls.Add(this.campoTelefone);
            this.Controls.Add(this.campoRg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.campoCpf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AtualizarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtualizarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox caixaNaoDois;
        private System.Windows.Forms.CheckBox caixaSimDois;
        private System.Windows.Forms.CheckBox caixaNao;
        private System.Windows.Forms.CheckBox caixaSim;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Button botaoAtualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoDeletar;
        public System.Windows.Forms.TextBox campoNome;
        public System.Windows.Forms.TextBox campoFarmaciaPopular;
        public System.Windows.Forms.TextBox campoPlanoSaude;
        public System.Windows.Forms.MaskedTextBox campoTelefone;
        public System.Windows.Forms.MaskedTextBox campoRg;
        public System.Windows.Forms.MaskedTextBox campoCpf;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
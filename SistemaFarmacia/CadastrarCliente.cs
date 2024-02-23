using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class CadastrarCliente : Form
    {
        DAO bd;
        public CadastrarCliente()
        {
            InitializeComponent();
            bd = new DAO();
        }//Fim do construtor

        private void campoNome_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo nome

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campo cpf

        private void campoRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campo rg

        private void campoTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campo telefone

        private void campoPlanoSaude_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo plano saude

        private void campoFarmaciaPopular_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo farmacia popular

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            bd.Inserir(campoNome.Text, maskedTextBox1.Text, campoRg.Text, campoTelefone.Text, campoPlanoSaude.Text, 
                       campoFarmaciaPopular.Text);

            campoNome.Text = "";
            maskedTextBox1.Text = "";
            campoRg.Text = "";
            campoTelefone.Text = "";
            campoPlanoSaude.Text = "";
            campoFarmaciaPopular.Text = "";
        }//Fim do botão cadastrar

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botão voltar
    }//Fim da classe
}//Fim do projeto

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
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }//Fim do método construtor

        private void campoNome_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campoNome

        private void campoPreco_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campoPreco

        private void campoDescricao_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campoDescricao

        private void campoQuantidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campoQuantidade

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            DAOProdutos bdProdutos = new DAOProdutos();
            bdProdutos.Inserir(campoNome.Text, campoDescricao.Text, campoQuantidade.Text, campoPreco.Text);

            campoNome.Text = "";
            campoDescricao.Text = "";
            campoQuantidade.Text = "";
            campoPreco.Text = "";
        }//Fim do botaoCadastrar

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botaoVoltar
    }//Fim da classe
}//FIm do projeto

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
    public partial class AtualizarProduto : Form
    {
        DAOProdutos bdProdutos;
        public AtualizarProduto()
        {
            InitializeComponent();
            bdProdutos = new DAOProdutos();
            campoCodigo.Enabled = false;
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

        private void campoCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campoCodigo

        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            bdProdutos.Atualizar(campoNome.Text, campoDescricao.Text, campoQuantidade.Text, campoPreco.Text, campoCodigo.Text);
        }//Fim do botãoAtualizar

        private void botaoDeletar_Click(object sender, EventArgs e)
        {
            MenuCertezaProduto certeza = new MenuCertezaProduto();
            certeza.codigo = campoCodigo.Text;
            certeza.ShowDialog();
        }//Fim do botaoDeletar

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botaoVoltar
    }//Fim da classe
}//Fim do projeto

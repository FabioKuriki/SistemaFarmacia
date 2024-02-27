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
    public partial class ConsultarProduto : Form
    {
        DAOProdutos bdProdutos;
        public ConsultarProduto()
        {
            InitializeComponent();
            bdProdutos = new DAOProdutos();
            ConfigurarGrid();
            NomeColunas();
            bdProdutos.PreencherVetor();
            AdicionarDados();
        }//Fim do método construtor

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//Fim da tabela

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";//Dar um nome a coluna do dataGrid
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Descrição";
            dataGridView1.Columns[3].Name = "Quantidade";
            dataGridView1.Columns[4].Name = "Preço";
        }//Fim do método

        public void AdicionarDados()
        {
            for (int i = 0; i < bdProdutos.contador; i++)
            {
                dataGridView1.Rows.Add(bdProdutos.codigo[i], bdProdutos.nome[i],
                                       bdProdutos.descricao[i], bdProdutos.quantidade[i], bdProdutos.preco[i]);
            }//Fim do for
        }//Fim do método

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Para não adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//Para não deletar linhas
            dataGridView1.AllowUserToResizeColumns = false;//Para não redimensionar as colunas
            dataGridView1.AllowUserToResizeRows = false;//Para não redimensionar as linhas
            dataGridView1.ColumnCount = 5;//Quantidade de colunas
        }//Fim do ConfigurarGrid

        private void campoCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campoCodigo

        private void botaoConsultar_Click(object sender, EventArgs e)
        {
            EncontrarProduto();
        }//Fim do botão Consultar

        public void EncontrarProduto()
        {
            try
            {
                int id = bdProdutos.ConsultarPorCodigo(Convert.ToInt32(campoCodigo.Text));//Buscando o código digitado
                if (id == -1)
                {
                    MessageBox.Show("Código não encontrado em sistema");
                    campoCodigo.Text = "";
                }
                else
                {
                    AtualizarProduto atualizar = new AtualizarProduto();
                    atualizar.campoCodigo.Text = "" + bdProdutos.codigo[id];
                    atualizar.campoNome.Text = bdProdutos.nome[id];
                    atualizar.campoPreco.Text = bdProdutos.preco[id];
                    atualizar.campoDescricao.Text = bdProdutos.descricao[id];
                    atualizar.campoQuantidade.Text = "" + bdProdutos.quantidade[id];
                    atualizar.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Preencha o campo com um código válido\n\n" + erro);
            }
        }//Fim do método

        private void ConsultarProduto_Load(object sender, EventArgs e)
        {

        }//Fim do consultarProduto

        private void botaoVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botaoVoltar

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }//Fim da classe
}//FIm do projeto

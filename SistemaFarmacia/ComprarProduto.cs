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
    public partial class ComprarProduto : Form
    {
        DAOProdutos bdProdutos;
        private DateTime dataHora;
        public ComprarProduto()
        {
            InitializeComponent();
            bdProdutos = new DAOProdutos();
            maskedTextBox1.Enabled = false;
            ConfigurarGrid();
            NomeColunas();
            bdProdutos.PreencherVetor();
            AdicionarDados();
        }//Fim do método Construtor

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//Fim do dataGrid

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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campoCpf
        private void botaoComprar_Click(object sender, EventArgs e)
        {
            dataHora = DateTime.Now;
            string dt = dataHora.ToString("yyyy-MM-dd H:mm:ss");
            EncontrarProduto(campoCodigo.Text, dt, maskedTextBox1.Text);
        }//Fim do botaoComprar

        private void campoCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campoCodigo

        public void EncontrarProduto(string codigo, string dataHora, string cpf) //Validar código
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
                    bdProdutos.Comprar(codigo, dataHora, cpf);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Preencha o campo com um código válido\n\n" + erro);
            }
        }//Fim do método

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botãoVoltar
    }//Fim da classe
}//Fim do projeto

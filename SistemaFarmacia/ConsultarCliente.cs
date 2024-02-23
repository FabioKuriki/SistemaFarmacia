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
    public partial class ConsultarCliente : Form
    {
        DAO bd;
        public ConsultarCliente()
        {
            InitializeComponent();
            bd = new DAO();
            ConfigurarGrid();
            NomeColunas();
            bd.PreencherVetor();
            AdicionarDados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//Fim da tabela

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Nome";//Dar um nome a coluna do dataGrid
            dataGridView1.Columns[1].Name = "CPF";
            dataGridView1.Columns[2].Name = "RG";
            dataGridView1.Columns[3].Name = "Telefone";
            dataGridView1.Columns[4].Name = "Plano de Saúde";
            dataGridView1.Columns[5].Name = "Farmácia Popular";
        }//Fim do método

        public void AdicionarDados()
        {
            for (int i = 0; i < bd.contador; i++)
            {
                dataGridView1.Rows.Add(bd.nome[i], bd.cpf[i],
                                       bd.rg[i], bd.telefone[i], bd.planoSaude[i], bd.farmaciaPopular[i]);
            }//Fim do for
        }//Fim do método

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Para não adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//Para não deletar linhas
            dataGridView1.AllowUserToResizeColumns = false;//Para não redimensionar as colunas
            dataGridView1.AllowUserToResizeRows = false;//Para não redimensionar as linhas
            dataGridView1.ColumnCount = 6;//Quantidade de colunas
        }//Fim do ConfigurarGrid

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campo cpf

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bd.ConsultarPorCpf(maskedTextBox1.Text));
        }//Fim do botão consultar
    }//Fim da classe
}//Fim do projeto

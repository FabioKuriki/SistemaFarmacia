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
    public partial class ConsultarVendas : Form
    {
        DAOVendas bdVendas;
        public ConsultarVendas()
        {
            InitializeComponent();
            bdVendas = new DAOVendas();
            ConfigurarGrid();
            NomeColunas();
            bdVendas.PreencherVetor();
            AdicionarDados();
        }//Fim do método construtor

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//Fim do dataGrid


        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";//Dar um nome a coluna do dataGrid
            dataGridView1.Columns[1].Name = "Data e hora da venda";
            dataGridView1.Columns[2].Name = "CPF";
            dataGridView1.Columns[3].Name = "Código do produto";
        }//Fim do método

        public void AdicionarDados()
        {
            for (int i = 0; i < bdVendas.contador; i++)
            {
                dataGridView1.Rows.Add(bdVendas.codigoVenda[i], bdVendas.dataVenda[i],
                                       bdVendas.cpf[i], bdVendas.codigoProduto[i]);
            }//Fim do for
        }//Fim do método

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Para não adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//Para não deletar linhas
            dataGridView1.AllowUserToResizeColumns = false;//Para não redimensionar as colunas
            dataGridView1.AllowUserToResizeRows = false;//Para não redimensionar as linhas
            dataGridView1.ColumnCount = 4;//Quantidade de colunas
        }//Fim do ConfigurarGrid
    }//Fim da classe
}//Fim do projeto

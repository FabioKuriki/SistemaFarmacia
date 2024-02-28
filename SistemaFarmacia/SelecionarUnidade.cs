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
    public partial class SelecionarUnidade : Form
    {
        DAOUnidades unidades;
        public SelecionarUnidade()
        {
            InitializeComponent();
            unidades = new DAOUnidades();
            ConfigurarGrid();
            NomeColunas();
            unidades.PreencherVetor();
            AdicionarDados();
        }//Fim do método construtor

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//Fim do dataGrid

        private void campoCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campoCodigo

        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            EncontrarUnidade();
        }//Fim do botaoEntrar

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botaoVoltar

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";//Dar um nome a coluna do dataGrid
            dataGridView1.Columns[1].Name = "Endereco";
            dataGridView1.Columns[2].Name = "Estado";
        }//Fim do método

        public void AdicionarDados()
        {
            for (int i = 0; i < unidades.contador; i++)
            {
                dataGridView1.Rows.Add(unidades.codigo[i], unidades.endereco[i],
                                       unidades.estado[i]);
            }//Fim do for
        }//Fim do método

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Para não adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//Para não deletar linhas
            dataGridView1.AllowUserToResizeColumns = false;//Para não redimensionar as colunas
            dataGridView1.AllowUserToResizeRows = false;//Para não redimensionar as linhas
            dataGridView1.ColumnCount = 3;//Quantidade de colunas
        }//Fim do ConfigurarGrid

        public void EncontrarUnidade()
        {
            try
            {
                int id = unidades.ConsultarPorCodigo(Convert.ToInt32(campoCodigo.Text));//Buscando o código digitado
                if (id == -1)
                {
                    MessageBox.Show("Código não encontrado em sistema");
                    campoCodigo.Text = "";
                }
                else
                {
                    MenuFarmacia menu = new MenuFarmacia();
                    menu.ShowDialog();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Preencha o campo com um código válido\n\n" + erro);
            }
        }//Fim do método
    }//Fim da classe
}//Fim do projeto

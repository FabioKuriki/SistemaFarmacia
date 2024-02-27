using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaFarmacia
{
    public partial class ConsultarCliente : Form
    {
        DAO bd;
        public ConsultarCliente()
        {
            InitializeComponent();
            bd = new DAO();
            campoTotal.Enabled = false;
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
            campoTotal.Text = "" + bd.contador;
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
            EncontrarCliente();
        }//Fim do botão consultar


        public void EncontrarCliente()
        {
            try
            {
                int id = bd.ConsultarPorCpf(maskedTextBox1.Text);//Buscando o cpf digitado
                if (id == -1)
                {
                    MessageBox.Show("CPF não encontrado em sistema");
                    maskedTextBox1.Text = "";
                }
                else
                {
                    AtualizarCliente atualizar = new AtualizarCliente();
                    atualizar.campoNome.Text = bd.nome[id];
                    atualizar.campoCpf.Text = bd.cpf[id];
                    atualizar.campoRg.Text = bd.rg[id];
                    atualizar.campoTelefone.Text = bd.telefone[id];
                    atualizar.campoPlanoSaude.Text = bd.planoSaude[id];
                    atualizar.campoFarmaciaPopular.Text = bd.farmaciaPopular[id];
                    atualizar.ShowDialog();
                    this.Close();
                }//Fim do else
            }
            catch (Exception erro)
            {
                MessageBox.Show("Preencha o campo com um cpf válido\n\n" + erro);
            }
        }//Fim do método

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botaoVoltar

        private void campoTotal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }//Fim do campoTotal
    }//Fim da classe
}//Fim do projeto

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
    public partial class MenuProduto : Form
    {
        public MenuProduto()
        {
            InitializeComponent();
        }//Fim do método construtor

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadastro = new CadastrarProduto();
            cadastro.ShowDialog();
        }//Fim do botão cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarProduto consultar = new ConsultarProduto();
            consultar.ShowDialog();
        }//Fim do botão Consultar

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botaoVoltar
    }//Fim da classe
}//Fim do projeto

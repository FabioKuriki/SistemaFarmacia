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
    public partial class MenuCertezaProduto : Form
    {
        DAOProdutos bdProdutos;
        public string codigo;
        public MenuCertezaProduto()
        {
            bdProdutos = new DAOProdutos();
            InitializeComponent();
        }//Fim do método construtor

        private void botaoSim_Click(object sender, EventArgs e)
        {
            bdProdutos.Excluir(codigo);
            this.Close();
        }//Fim do botaoSim

        private void botaoNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botaoNao
    }//Fim da classe
}//Fim do projeto

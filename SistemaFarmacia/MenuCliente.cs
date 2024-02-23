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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }//Fim do construtor

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastro = new CadastrarCliente();
            cadastro.ShowDialog();
        }//Fim do botão Cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarCliente consultar = new ConsultarCliente();
            consultar.ShowDialog();
        }//Fim do botão consultar

        private void button3_Click(object sender, EventArgs e)
        {
            teste teste = new teste();
            teste.ShowDialog();
        }//Fim do botão atualizar
    }//Fim da classe
}//Fim do projeto

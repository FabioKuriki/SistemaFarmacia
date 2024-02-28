using MySqlX.XDevAPI;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }//Fim do método construtor

        private void Menu_Load(object sender, EventArgs e)
        {

        }//Fim do Menu_Load

        private void botaoSelecionar_Click(object sender, EventArgs e)
        {
            SelecionarUnidade selecionar = new SelecionarUnidade();
            selecionar.ShowDialog();
        }//Fim do botaoSelecionar

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUnidade cadastrar = new CadastrarUnidade();
            cadastrar.ShowDialog();
        }//Fim do botaoCadastrar
    }//Fim da classe
}//Fim do projeto

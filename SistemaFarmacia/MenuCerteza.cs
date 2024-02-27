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
    public partial class MenuCerteza : Form
    {
        DAO bd;
        public string cpf;
        public MenuCerteza()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void botaoSim_Click(object sender, EventArgs e)
        {
            bd.Excluir(cpf);
            this.Close();
        }//Fim do botão Sim

        private void botaoNao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada");
            this.Close();
        }//Fim do botão Não
    }//Fim da classe
}//Fim do projeto

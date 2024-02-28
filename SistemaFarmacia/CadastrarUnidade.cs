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
    public partial class CadastrarUnidade : Form
    {
        public CadastrarUnidade()
        {
            InitializeComponent();
        }//Fim do método construtor

        private void campoEndereco_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campoEnderco

        private void campoEstado_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campoEstado

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            DAOUnidades bdUnidades = new DAOUnidades();
            bdUnidades.Inserir(campoEndereco.Text, campoEstado.Text);
        }//Fim do botaoCadastrar
    }//Fim da classe
}//Fim do projeto

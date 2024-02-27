using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaFarmacia
{
    public partial class CadastrarCliente : Form
    {
        DAO bd;
        public CadastrarCliente()
        {
            InitializeComponent();
            bd = new DAO();
            caixaNao.Checked = true;
            caixaNaoDois.Checked = true;
        }//Fim do construtor

        private void campoNome_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo nome

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campo cpf

        private void campoRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campo rg

        private void campoTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campo telefone

        private void campoPlanoSaude_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo plano saude

        private void campoFarmaciaPopular_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo farmacia popular

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            bd.Inserir(campoNome.Text, maskedTextBox1.Text, campoRg.Text, campoTelefone.Text, campoPlanoSaude.Text, 
                       campoFarmaciaPopular.Text);

            campoNome.Text = "";
            maskedTextBox1.Text = "";
            campoRg.Text = "";
            campoTelefone.Text = "";
            if (caixaSim.Checked == true)
            {
                campoPlanoSaude.Text = "";
            }
            if (caixaSimDois.Checked == true)
            {
                campoFarmaciaPopular.Text = "";
            }
            bd.CpfExistente(maskedTextBox1.Text);
        }//Fim do botão cadastrar

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botão voltar

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }//Janela do menu CadastrarCliente

        private void caixaSim_CheckedChanged(object sender, EventArgs e)
        {
            if (caixaSim.Checked == true)
            {
                caixaSim.Enabled = false;
                caixaNao.Enabled = true;
                campoPlanoSaude.Enabled = true;
                campoPlanoSaude.Text = "";
                caixaNao.Checked = false;
            }
        }//Fim do caixaSim Plano de Saúde

        private void caixaNao_CheckedChanged(object sender, EventArgs e)
        {
            if (caixaNao.Checked == true)
            {
                caixaNao.Enabled = false;
                caixaSim.Enabled = true;
                campoPlanoSaude.Enabled = false;
                campoPlanoSaude.Text = "Não tem";
                caixaSim.Checked = false;
                caixaNao.Checked = true;
            }
        }//Fim do caixaNao Plano de Saúde

        private void caixaSimDois_CheckedChanged(object sender, EventArgs e)
        {
            if (caixaSimDois.Checked == true)
            {
                caixaSimDois.Enabled = false;
                caixaNaoDois.Enabled = true;
                campoFarmaciaPopular.Enabled = true;
                campoFarmaciaPopular.Text = "";
                caixaNaoDois.Checked = false;
            }
        }//Fim do caixaSim Farmácia Popular

        private void caixaNaoDois_CheckedChanged(object sender, EventArgs e)
        {
            if (caixaNaoDois.Checked == true)
            {
                caixaNaoDois.Enabled = false;
                caixaSimDois.Enabled = true;
                campoFarmaciaPopular.Enabled = false;
                campoFarmaciaPopular.Text = "Não tem";
                caixaSimDois.Checked = false;
                caixaNaoDois.Checked = true;
            }
        }//Fim do caixaNao Farmácia Popular
    }//Fim da classe
}//Fim do projeto

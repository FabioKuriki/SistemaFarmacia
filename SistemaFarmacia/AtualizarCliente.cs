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
    public partial class AtualizarCliente : Form
    {
        DAO bd;
        public AtualizarCliente()
        {
            InitializeComponent();
            bd = new DAO();
            campoCpf.Enabled = false;
        }

        private void campoNome_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campoNome

        private void campoCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campoCpf

        private void campoRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campoRg

        private void campoTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campoTelefone

        private void caixaSim_CheckedChanged(object sender, EventArgs e)
        {
            bd.PreencherVetor();
            if (caixaSim.Checked == true)
            {
                caixaSim.Enabled = false;
                caixaNao.Enabled = true;
                campoPlanoSaude.Enabled = true;
                campoPlanoSaude.Text = bd.planoSaude[pegarPosicao(campoCpf.Text)];
                caixaNao.Checked = false;
            }
        }//Fim do campoSim Plano de Sáude

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
        }//Fim do campoNão Plano de Sáude

        private void campoPlanoSaude_TextChanged(object sender, EventArgs e)
        {
            if (campoPlanoSaude.Text != "Não tem")
            {
                caixaSim.Checked = true;
                caixaNao.Checked = false;
            }
            else
            {
                caixaSim.Checked = false;
                caixaNao.Checked = true;
            }
        }//Fim do campoPlanoSaude

        private void caixaSimDois_CheckedChanged(object sender, EventArgs e)
        {
            if (caixaSimDois.Checked == true)
            {
                caixaSimDois.Enabled = false;
                caixaNaoDois.Enabled = true;
                campoFarmaciaPopular.Enabled = true;
                campoFarmaciaPopular.Text = bd.farmaciaPopular[pegarPosicao(campoCpf.Text)]; ;
                caixaNaoDois.Checked = false;
            }
        }//Fim do campoSim Farmácia Popular

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
        }//Fim do campoNão Farmácia Popular

        private void campoFarmaciaPopular_TextChanged(object sender, EventArgs e)
        {
            if (campoFarmaciaPopular.Text != "Não tem")
            {
                caixaSimDois.Checked = true;
                caixaNaoDois.Checked = false;
            }
            else
            {
                caixaSimDois.Checked = false;
                caixaNaoDois.Checked = true;
            }
        }//Fim do campoFarmaciaPopular

        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            bd.Atualizar(campoNome.Text, campoCpf.Text, campoRg.Text, campoTelefone.Text, campoPlanoSaude.Text, campoFarmaciaPopular.Text);
        }//Fim do botãoAtualizar

        public int pegarPosicao(string cpfAtual)
        {
            bd.PreencherVetor();
            for(int i = 0; i < bd.contador; i++)
            {
                if(cpfAtual == bd.cpf[i])
                {
                    return i;
                }
            }
            return -1;
        }//Fim do método

        private void botaoDeletar_Click(object sender, EventArgs e)
        {
            MenuCerteza certeza = new MenuCerteza();
            certeza.cpf = campoCpf.Text;
            certeza.ShowDialog();
        }//Fim do botaoDeletar

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botãoVoltar

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ComprarProduto compra = new ComprarProduto();
            compra.maskedTextBox1.Text = campoCpf.Text;
            compra.ShowDialog();
        }//Fim da imagemDeCompra
    }//Fim da classe
}//Fim do projeto

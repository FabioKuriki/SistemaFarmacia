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
    public partial class MenuFarmacia : Form
    {
        DAO bd;
        ConsultarVendas vendas;
        MenuCliente cliente;
        MenuProduto produto;
        public MenuFarmacia()
        {
            InitializeComponent();
            bd = new DAO();
            vendas = new ConsultarVendas();
            cliente = new MenuCliente();
            produto = new MenuProduto();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cliente.ShowDialog();
        }//Fim da imagem Clientes

        private void label3_Click(object sender, EventArgs e)
        {
            cliente.ShowDialog();
        }//Fim da palavra Clientes

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            produto.ShowDialog();
        }//Fim da imagem Produtos

        private void label4_Click(object sender, EventArgs e)
        {
            produto.ShowDialog();
        }//Fim da palavra Produtos

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            vendas.ShowDialog();
        }//Fim da imagem Vendas

        private void label2_Click(object sender, EventArgs e)
        {
            vendas.ShowDialog();
        }//Fim da palavra Vendas
    }//Fim da classe
}//Fim do projeto

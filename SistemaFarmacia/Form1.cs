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
        DAO bd;
        public Menu()
        {
            InitializeComponent();
            bd = new DAO();
        }//Fim do método construtor

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuCliente cliente = new MenuCliente();
            cliente.ShowDialog();
        }//Fim da imagemCliente

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuProduto produto = new MenuProduto();
            produto.ShowDialog();
        }//Fim da imagemProduto

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ConsultarVendas vendas = new ConsultarVendas();
            vendas.ShowDialog();
        }
    }//Fim da classe
}//Fim do projeto

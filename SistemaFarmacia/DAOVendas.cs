using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemaFarmacia
{
    class DAOVendas
    {
        MySqlConnection bdVendas;
        public int[] codigoVenda;
        public int[] codigoVenda2;
        public DateTime[] dataVenda;
        public string[] cpf;
        public int[] codigoProduto;
        public int[] codigoProduto2;
        public int i;
        public int contador;
        public DAOVendas()
        {
            bdVendas = new MySqlConnection("Server = localhost; Database = SistemaFarmacia; Uid = root; Password =");
            try
            {
                bdVendas.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + "\n\nAlgo deu errado!");
                bdVendas.Close();
            }//Fim do catch
        }//Fim do método construtor

        public void Inserir(string dataVenda, string cpfCliente, string codigoProduto)
        {
            string dados = "('', '" + dataVenda + "','" + cpfCliente + "','" + codigoProduto + "')";
            string sql = "insert into vendas(codigoVenda, dataVenda, cpfCliente, codigoProduto) values " + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, bdVendas);//Prepara o comando no banco de dados
                conn.ExecuteNonQuery();//Execuntando o comando no banco de dados
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n Confirme se as informações estão corretas ou se são válidas\n\n\n" + erro);
            }
        }//Fim do método Inserir

        public void PreencherVetor()
        {
            string query = "select * from vendas";

            //Instanciar os vetores
            codigoVenda = new int[100];
            dataVenda = new DateTime[100];
            cpf = new string[100];
            codigoProduto = new int[100];

            //Preencher com valores genéricos
            for (i = 0; i < 100; i++)
            {
                codigoVenda[i] = 0;
                dataVenda[i] = DateTime.Now;
                cpf[i] = "";
                codigoProduto[i] = 0;

            }//Fim do for

            //Criar o comando de consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, bdVendas);
            //Listar todos os dados que estão no banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;//Utilizar novamente o contador
            contador = 0;//Contar quantos dados eu tenho no banco

            while (leitura.Read())
            {
                codigoVenda[i] = Convert.ToInt32(leitura["codigoVenda"]);
                dataVenda[i] = Convert.ToDateTime(leitura["dataVenda"]);
                cpf[i] = "" + leitura["cpfCliente"];
                codigoProduto[i] = Convert.ToInt32(leitura["codigoProduto"]);
                i++;//Mudando do contador
                contador++;//Contar quantos dados tem no banco
            }//Fim do while

            //Encerrar o banco
            leitura.Close();
        }//Fim do método

        public void ProcurarProdutoMaisVendido()
        {
            string query = "select count(codigoProduto), codigoProduto from vendas group by codigoProduto desc";
          
            //Instanciar os vetores
            codigoVenda2= new int[100];
            codigoProduto2 = new int[100];

            //Preencher com valores genéricos
            for (i = 0; i < 100; i++)
            {
                codigoVenda2[i] = 0;
                codigoProduto2[i] = 0;
            }//Fim do for

            //Criar o comando de consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, bdVendas);
            //Listar todos os dados que estão no banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;//Utilizar novamente o contador
            contador = 0;//Contar quantos dados eu tenho no banco

            while (leitura.Read())
            {
                codigoVenda2[i] = Convert.ToInt32(leitura["count(codigoProduto)"]);
                codigoProduto2[i] = Convert.ToInt32(leitura["codigoProduto"]);
                i++;//Mudando do contador
                contador++;//Contar quantos dados tem no banco
            }//Fim do while

            //Encerrar o banco
            leitura.Close();
        }//Fim do método
    }//Fim da classe
}//Fim do projeto

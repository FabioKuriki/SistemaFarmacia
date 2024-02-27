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
    internal class DAOProdutos
    {
        MySqlConnection bdProdutos;
        public int[] codigo;
        public string[] nome;
        public string[] descricao;
        public int[] quantidade;
        public string[] preco;
        public int i;
        public int contador;
        DAOVendas bdVendas;
        public DAOProdutos()
        {
            bdVendas = new DAOVendas();
            bdProdutos = new MySqlConnection("Server = Localhost; Database = SistemaFarmacia; Uid = root; Password =");
            try
            {
                bdProdutos.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + "\n\nAlgo deu errado!");
                bdProdutos.Close();
            }//Fim do catch
        }//Fim do método construtor

        public void Inserir(string nome, string descricao, string quantidade, string preco)
        {
            string dados = "('', '" + nome + "','" + descricao + "','" + quantidade + "','" + preco + "')";
            string sql = "insert into produtos(codigo, nome, descricao, quantidade, preco) values " + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, bdProdutos);//Prepara o comando no banco de dados
                conn.ExecuteNonQuery();//Execuntando o comando no banco de dados
                MessageBox.Show("Cadastro realizado com sucesso!!!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n Confirme se as informações estão corretas ou se são válidas\n\n\n" + erro);
            }
        }//Fim do método Inserir

        public void PreencherVetor()
        {
            string query = "select * from produtos";

            //Instanciar os vetores
            codigo = new int[100];
            nome = new string[100];
            descricao = new string[100];
            quantidade = new int[100];
            preco = new string[100];

            //Preencher com valores genéricos
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                nome[i] = "";
                descricao[i] = "";
                quantidade[i] = 0;
                preco[i] = "";
            }//Fim do for

            //Criar o comando de consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, bdProdutos);
            //Listar todos os dados que estão no banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;//Utilizar novamente o contador
            contador = 0;//Contar quantos dados eu tenho no banco

            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = "" + leitura["nome"];
                descricao[i] = "" + leitura["descricao"];
                quantidade[i] = Convert.ToInt32(leitura["quantidade"]);
                preco[i] = "" + leitura["preco"];
                i++;//Mudando do contador
                contador++;//Contar quantos dados tem no banco
            }//Fim do while

            //Encerrar o banco
            leitura.Close();
        }//Fim do método

        public int ConsultarPorCodigo(int codigoParaConsultar)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (codigoParaConsultar == codigo[i])
                {
                    return i;
                }
            }
            return -1;
        }//Fim do método

        public void Atualizar(string nome, string descricao, string quantidade, string preco, string codigo)
        {
            try
            {
                string query = "update produtos set nome = '" + nome + "', descricao = '" + descricao + "', quantidade = '" + quantidade +
                               "', preco = '" + preco + "' where codigo = '" + codigo + "'";
                //Preparar o comando no BD
                MySqlCommand sql = new MySqlCommand(query, bdProdutos);
                string resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Impossível atualizar\n\n" + erro);
            }
        }//Fim do método

        public void Excluir(string codigo)
        {
            string query = "delete from produtos where codigo = '" + codigo + "'";
            MySqlCommand sql = new MySqlCommand(query, bdProdutos);
            string resultado = "" + sql.ExecuteNonQuery();

            MessageBox.Show("Dado excluido com sucesso!!!");

        }//Fim do método 

        public void Comprar(string codigoSelecionado, string dataHora, string cpfCliente)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if(Convert.ToInt32(codigoSelecionado) == codigo[i])
                {
                    if (quantidade[i] == 0)
                    {
                        MessageBox.Show("O produto selecionado está esgotado");
                    }
                    else
                    {
                        bdVendas.Inserir(dataHora, cpfCliente, codigoSelecionado);
                        string query = "update produtos set quantidade = '" + (quantidade[i] - 1) + "' where codigo = '" + codigoSelecionado + "'";
                        //Preparar o comando no BD
                        MySqlCommand sql = new MySqlCommand(query, bdProdutos);
                        string resultado = "" + sql.ExecuteNonQuery();
                        MessageBox.Show("Compra realizada com sucesso!!!");
                    }
                }
            }
        }
    }//Fim da classe
}//Fim do projeto

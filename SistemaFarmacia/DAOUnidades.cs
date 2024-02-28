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
    class DAOUnidades
    {
        MySqlConnection bdUnidades;
        public int[] codigo;
        public string[] endereco;
        public string[] estado;
        public int i;
        public int contador;
        public DAOUnidades()
        {
            bdUnidades = new MySqlConnection("Server = Localhost; Database = SistemaFarmacia; Uid = root; Password =");
            try
            {
                bdUnidades.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + "\n\nAlgo deu errado!");
                bdUnidades.Close();
            }//Fim do catch
        }//Fim do método construtor

        public void Inserir(string endereco, string estado)
        {
            string dados = "('', '" + endereco + "','" + estado + "')";
            string sql = "insert into unidade(codigoUnidade, endereco, estado) values " + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, bdUnidades);//Prepara o comando no banco de dados
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
            string query = "select * from unidade";

            //Instanciar os vetores
            codigo = new int[100];
            endereco = new string[100];
            estado = new string[100];

            //Preencher com valores genéricos
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                endereco[i] = "";
                estado[i] = "";
            }//Fim do for

            //Criar o comando de consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, bdUnidades);
            //Listar todos os dados que estão no banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;//Utilizar novamente o contador
            contador = 0;//Contar quantos dados eu tenho no banco

            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigoUnidade"]);
                endereco[i] = "" + leitura["endereco"];
                estado[i] = "" + leitura["estado"];
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
    }//Fim da classe
}//Fim do projeto

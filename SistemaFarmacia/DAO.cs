﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Crypto.Digests;

namespace SistemaFarmacia
{
    class DAO
    {
        MySqlConnection bd;
        public string[] nome;
        public string[] cpf;
        public string[] rg;
        public string[] telefone;
        public string[] planoSaude;
        public string[] farmaciaPopular;
        public int i;
        public int contador;
        public DAO()
        {
            bd = new MySqlConnection("Server = localhost; Database = SistemaFarmacia; Uid = root; Password =");
            try
            {
                bd.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + "\n\nAlgo deu errado!");
                bd.Close();
            }//Fim do catch
        }//Fim do método construtor

        public void Inserir(string nome, string cpf, string rg, string telefone, string planoSaude, string farmaciaPopular)
        {
            string dados = "('" + nome + "','" + cpf + "','" + rg + "','" + telefone + "','" + planoSaude + "', '" + farmaciaPopular + "')";
            string sql = "insert into cliente(nome, cpf, rg, telefone, planoSaude, farmaciaPopular) values " + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, bd);//Prepara o comando no banco de dados
                conn.ExecuteNonQuery();//Execuntando o comando no banco de dados
                MessageBox.Show("Cadastro realizado com sucesso!!!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//Fim do método Inserir

        public void PreencherVetor()
        {
            string query = "select * from cliente";

            //Instanciar os vetores
            nome = new string[100];
            cpf = new string[100];
            rg = new string[100];
            telefone = new string[100];
            planoSaude = new string[100];
            farmaciaPopular = new string[100];

            //Preencher com valores genéricos
            for (i = 0; i < 100; i++)
            {
                nome[i] = "";
                cpf[i] = "";
                rg[i] = "";
                telefone[i] = "";
                planoSaude[i] = "";
                farmaciaPopular[i] = "";
            }//Fim do for

            //Criar o comando de consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, bd);
            //Listar todos os dados que estão no banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;//Utilizar novamente o contador
            contador = 0;//Contar quantos dados eu tenho no banco

            while (leitura.Read())
            {
                nome[i] = "" + leitura["nome"];
                cpf[i] = "" + leitura["cpf"];
                rg[i] = "" + leitura["rg"];
                telefone[i] = "" + leitura["telefone"];
                planoSaude[i] = "" + leitura["planoSaude"];
                farmaciaPopular[i] = "" + leitura["farmaciaPopular"];
                i++;//Mudando do contador
                contador++;//Contar quantos dados tem no banco
            }//Fim do while

            //Encerrar o banco
            leitura.Close();
        }//Fim do método

        public string ConsultarPorCpf(string cpfParaConsultar)
        {
            PreencherVetor();
            for(i = 0; i < contador; i++)
            {
                if (cpfParaConsultar == cpf[i] )
                {
                    return "Nome: " + nome[i] +
                           "\nCPF: " + cpf[i] +
                           "\nRG: " + rg[i] +
                           "\nTelefone: " + telefone[i]+
                           "\nPlano de Saúde: " + planoSaude[i] +
                           "\nfarmaciaPopular: " + farmaciaPopular[i];
                }
            }
            return "Cliente não encontrado";
        }
    }//Fim da classe
}//Fim do projeto

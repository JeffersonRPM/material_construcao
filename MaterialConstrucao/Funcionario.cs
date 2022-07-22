using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace MaterialConstrucao
{
    public class csFuncionario
    {
		private string nomeFuncionario;
		private string CPF; // chave
		private string telefone;

		private ConexaoMySQL conexaoFunc = new ConexaoMySQL();

		public void setNomeFuncionario(string valor)
        {
            nomeFuncionario = valor;
        }

		public string getNomeFuncionario()
        {
			return nomeFuncionario;
        }

        public void setCPF_Funcionario(string valor)
        {
            CPF = valor;
        }
        public string getCPF_Funcionario()
        {
            return CPF;
        }

        public void setTelefoneFuncionario(string valor)
        {
            telefone = valor;
        }

        public string getTelefoneFuncionario()
        {
            return telefone;
        }

        public void inserir()
        {
            string sql = "INSERT INTO funcionario(CPF, nome, telefone) VALUES (";
            sql += "'" + CPF + "', ";
            sql += "'" + nomeFuncionario + "', ";
            sql += "'" + telefone + "'";
            sql += ")";
            conexaoFunc.executarSql(sql);
        }

        public void delete()
        {
            string sql = "Delete from funcionario WHERE CPF = '" + CPF + "';";
            conexaoFunc.executarSql(sql);
        }

        public void update()
        {
            string sql = "UPDATE funcionario SET ";
            sql += "nome = '" + nomeFuncionario + "', ";
            sql += "telefone = '" + telefone + "'";
            sql += " WHERE CPF = '" + CPF + "';";
            conexaoFunc.executarSql(sql);
        }

        public DataTable select()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select CPF, nome, telefone from funcionario;";
            adapter = conexaoFunc.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public void selectFuncionario()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet dataSet = new DataSet();
            string sql = "SELECT nome, telefone FROM funcionario WHERE CPF = '" + CPF + "';";
            adapter = conexaoFunc.executaRetornaDados(sql);
            adapter.Fill(dataSet);

            nomeFuncionario = dataSet.Tables[0].Rows[0][0].ToString();
            telefone = dataSet.Tables[0].Rows[0][1].ToString();
        }
    }
}


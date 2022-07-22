using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace MaterialConstrucao
{
	public class csCliente
	{
		private string nomeCliente;
		private string CPF; // chave
		private string CEP;
		private string telefone;
		private string cidade;
		private Int16 sigla; // ComboBox - estado
		private string numero;

		private ConexaoMySQL conexao = new ConexaoMySQL();
		public void SetNomeCliente(string valor)
		{
			nomeCliente = valor;
		}

		public string GetNomeCliente ()
        {
			return nomeCliente;
        }

		public void SetCPFCliente(string valor)
        {
			CPF = valor;
        }
		public string GetCPFCliente()
        {
			return CPF;
        }
		public void SetCEPCliente(string valor)
		{
			CEP = valor;
		}
		public string GetCEPCliente()
        {
			return CEP;
        }
		public void SetTelefoneCliente(string valor)
        {
			telefone = valor;
        }

		public string GetTelefoneCliente()
        {
			return telefone;
        }
		public void SetCidadeCliente(string valor)
        {
			cidade = valor;
        }
		public string GetCidadeCliente()
        {
			return cidade;
        }
		public void SetEstadoCliente(Int16 valor)
        {
			sigla = valor;
        }
		public Int16 GetEstadoCliente()
        {
			return sigla;
        }

		public void SetNumeroCliente(string valor)
        {
			numero = valor;
        }
		public string GetNumeroCliente()
        {
			return numero;
        }

		public void inserir()
        {
			string sql = "INSERT INTO cliente(CPF, nome, CEP,";
			sql += "cidade, estado, numero, telefone)";
			sql += " VALUES (";
			sql += "'" + CPF + "', ";
			sql += "'" + nomeCliente + "', ";
			sql += "'" + CEP + "', ";
			sql += "'" + cidade + "', ";
			sql += sigla + ", ";
			sql += "'" + numero + "', ";
			sql += "'" + telefone + "'";
			sql += ")";
			conexao.executarSql(sql);
		}
		public void delete()
        {
			string sql = "Delete from cliente WHERE CPF = '" + CPF + "';";
			conexao.executarSql(sql);
		}
		public void update()
        {
			string sql = "UPDATE cliente SET ";
			sql += "nome = '" + nomeCliente + "', ";
			sql += "CEP = '" + CEP + "', ";
			sql += "cidade = '" + cidade + "',";
			sql += "estado = " + sigla + ",";
			sql += "numero = '" + numero + "',";
			sql += "telefone = '" + telefone + "'";
			sql += " WHERE CPF = '" + CPF + "';";
			conexao.executarSql(sql);
		}
		public DataTable select()
        {
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable tabela = new DataTable();
			string sql = "Select CPF, nome, CEP, cidade, estado, numero, telefone from cliente;";
			adapter = conexao.executaRetornaDados(sql);
			adapter.Fill(tabela);
			return tabela;
		}

		public void selectCliente()
        {
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataSet dataSet = new DataSet();
			string sql = "SELECT nome, CEP, cidade, estado, numero, telefone FROM cliente WHERE CPF = '" + CPF + "';";
			adapter = conexao.executaRetornaDados(sql);
			adapter.Fill(dataSet);

			nomeCliente = dataSet.Tables[0].Rows[0][0].ToString();
			CEP = dataSet.Tables[0].Rows[0][1].ToString(); 
			cidade = dataSet.Tables[0].Rows[0][2].ToString();
			sigla = Convert.ToInt16(dataSet.Tables[0].Rows[0][3].ToString());
			numero = dataSet.Tables[0].Rows[0][4].ToString();
			telefone = dataSet.Tables[0].Rows[0][5].ToString();
		}
	}
}
	 

	

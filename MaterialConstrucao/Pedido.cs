using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace MaterialConstrucao
{
    public class csPedido
    {
        public Int32 id; // Auto Incremento
        public DateTime data;
        public string CPF_Cliente;
        public string CPF_Funcionario;
        public double valorTotal;

        private ConexaoMySQL conexao = new ConexaoMySQL();

        public void setPedidoId(Int32 valor)
        {
            id = valor;
        }

        public Int32 getPedidoId()
        {
            return id;
        }
        public void setDataPedido(DateTime valor)
        {
            data = valor;
        }

        public DateTime getDataPedido()
        {
            return data;
        }

        public void setCPF_Cliente(string valor)
        {
            CPF_Cliente = valor;
        }

        public string getCPF_Cliente()
        {
            return CPF_Cliente;
        }

        public void setCPF_Funcionario(string valor)
        {
            CPF_Funcionario = valor;
        }

        public string getCPF_Funcionario()
        {
            return CPF_Funcionario;
        }

        public void setValorPedido(double valor)
        {
            valorTotal = valor;
        }

        public double getValorPedido()
        {
            return valorTotal;
        }

        public void inserir()
        {
            string sql = "INSERT INTO pedido(idCliente, dataPedido, idFuncionario, valorTotal)";
            sql += "VALUES (";
            sql += "'" + CPF_Cliente + "', ";
            sql += "'" + data.ToString("yyyy-MM-dd") + "', ";
            sql += "'" + CPF_Funcionario + "', ";
            sql += valorTotal.ToString("N", CultureInfo.CreateSpecificCulture("en-US")) + ")";
            conexao.executarSql(sql);
        }

        public void update()
        {
            string sql = "UPDATE pedido SET ";
            sql += "idCliente = '" + CPF_Cliente + "', ";
            sql += "dataPedido = '" + data.ToString("yyyy-MM-dd") + "', ";
            sql += "idFuncionario = '" + CPF_Funcionario + "', ";
            sql += "valorTotal = " + valorTotal.ToString("N", CultureInfo.CreateSpecificCulture("en-US")); 
            sql += " WHERE id = " + id.ToString() + ";";
            conexao.executarSql(sql);
        }
        public void delete()
        {
            string sql = "DELETE FROM pedido WHERE id = " + id.ToString();
            conexao.executarSql(sql);
        }

        public DataTable select()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "SELECT id, dataPedido, cliente.nome ";
            sql += "FROM pedido ";
            sql += "INNER JOIN cliente on pedido.idCliente = cliente.CPF";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public void selectPedido()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT id, idCliente, dataPedido, idFuncionario, valorTotal FROM pedido WHERE id = " + id.ToString();
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(dataset);

            id = Convert.ToInt32(dataset.Tables[0].Rows[0][0].ToString());
            CPF_Cliente = dataset.Tables[0].Rows[0][1].ToString();
            data = Convert.ToDateTime(dataset.Tables[0].Rows[0][2].ToString());
            CPF_Funcionario = dataset.Tables[0].Rows[0][3].ToString();
            valorTotal = Convert.ToDouble(dataset.Tables[0].Rows[0][4].ToString());
        }

        public void selectPedidoUltimo()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT max(id) FROM pedido"; // max: maior id -> último pedido 
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(dataset);

            id = Convert.ToInt32(dataset.Tables[0].Rows[0][0].ToString());
        }
    }
}

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
    public class csProduto
    {
        private string Cod;
        private string nomeProduto;
        private string descricao;
        public double preco;
        public double qtdEstoque;

        private ConexaoMySQL conexaoProd = new ConexaoMySQL();

        public void setCodProduto(string valor)
        {
            Cod = valor;
        }

        public string getCodProduto()
        {
            return Cod;
        }

        public void setNomeProduto(string valor)
        {
            nomeProduto = valor;
        }

        public string getNomeProduto()
        {
            return nomeProduto;
        }

        public void setDescricaoProduto(string valor)
        {
            descricao = valor;
        }

        public string getDescricaoProduto()
        {
            return descricao;
        }

        public void setValorProduto(double valor)
        {
            preco = valor;
        }

        public double getValorProduto()
        {
            return preco;
        }

        public void setQuantidadeProduto (double valor)
        {
            qtdEstoque = valor;
        }

        public double getQuantidadeProduto()
        {
            return qtdEstoque;
        }
        public void inserir()
        {
            string sql = "INSERT INTO produto (numero, nome, descricao, preco, QtdEstoque) VALUES (";
            sql += "'" + Cod + "', ";
            sql += "'" + nomeProduto + "', ";
            sql += "'" + descricao + "', ";
            sql += preco.ToString("N", CultureInfo.CreateSpecificCulture("en-US")) + ", ";
            sql += qtdEstoque.ToString("N", CultureInfo.CreateSpecificCulture("en-US")) + ")";
            conexaoProd.executarSql(sql);
        }

        public void delete()
        {
            string sql = "Delete from produto WHERE numero = " + Cod + ";";
            conexaoProd.executarSql(sql);
        }

        public void update()
        {
            string sql = "UPDATE produto SET "; 
            sql += "nome = '" + nomeProduto + "',";
            sql += "descricao = '" + descricao + "',";
            sql += "preco = " + preco.ToString("N", CultureInfo.CreateSpecificCulture("en-US")) + ", ";
            sql += "QtdEstoque = " + qtdEstoque.ToString("N", CultureInfo.CreateSpecificCulture("en-US"));
            sql += " WHERE numero = " + Cod + ";";
            conexaoProd.executarSql(sql);
            // "N", CultureInfo.CreateSpecificCulture("en-US") -> Permite a conversão da ',' para '.'

        }
        public DataTable Select()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select numero, nome, descricao, preco, QtdEstoque from produto;";
            adapter = conexaoProd.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public void selectProduto()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet dataSet = new DataSet();
            string sql = "SELECT nome, descricao, preco, QtdEstoque FROM produto WHERE numero = '" + Cod + "';";
            adapter = conexaoProd.executaRetornaDados(sql);
            adapter.Fill(dataSet);

            nomeProduto = dataSet.Tables[0].Rows[0][0].ToString(); 
            descricao = dataSet.Tables[0].Rows[0][1].ToString();
            preco = Convert.ToDouble(dataSet.Tables[0].Rows[0][2].ToString());
            qtdEstoque = Convert.ToDouble(dataSet.Tables[0].Rows[0][3].ToString());
        }
    }
}

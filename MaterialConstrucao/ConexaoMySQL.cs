using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace MaterialConstrucao
{

        public class ConexaoMySQL
        {
        MySqlConnection conn;

            private string servidor = "";
            private string database = "";
            private string usuario = "";
            private string senha = "";

            private void dadosConexao()
            {
                string caminho = @"C:\Users\caio_\OneDrive\Área de Trabalho\MaterialConstrucao"; // @ permite o entendimento de uma única barra invertida
                string linha = "";


                if (System.IO.File.Exists(caminho))
                {
                    StreamReader arquivo = new StreamReader(caminho);
                    while (arquivo.EndOfStream == false)
                    {
                        linha = arquivo.ReadLine().ToString();
                        if (linha.Contains("servidor = "))
                        {
                            servidor = linha.Substring(11, linha.Length - 11);
                            
                        }
                        else if (linha.Contains("database = "))
                        {
                            database = linha.Substring(11, linha.Length - 11);
                        }
                        else if (linha.Contains("usuario = "))
                        {
                            usuario = linha.Substring(10, linha.Length - 10);
                        }
                        else if (linha.Contains("senha = "))
                        {
                            senha = linha.Substring(8, linha.Length - 8);
                        }
                    }

                }
            }
            private void conectaMySql() 
            {
                try 
                {
                    dadosConexao();
                    conn = new MySqlConnection("server=" + servidor + ";uid=" + usuario + ";database=" + database + ";pwd= " + senha + ";SSL Mode = NONE");
                    // servidor do banco (local); o banco de dados; usuário (raíz); senha (vazia por conta do xampp); protocolo de segurança 
                    conn.Open(); 
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }

            public void desconectaMySql(MySqlConnection conn)
            {
                conn.Close(); // fecha a conexão
            }

            public MySqlDataAdapter executaRetornaDados(string instrucaoSql)
            {
                conectaMySql();
                MySqlDataAdapter adapter = new MySqlDataAdapter(instrucaoSql, conn); // armazena as informações que
                                                                                     // foram retornadas pela instrução Select
                return adapter;
            }

            public void executarSql(string instrucaoSQL)
            {
                conectaMySql();
                MySqlCommand command = new MySqlCommand(instrucaoSQL, conn);
                command.ExecuteNonQuery(); // execução sem retorno 
            }
        }
}



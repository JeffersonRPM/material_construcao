using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace MaterialConstrucao
{
    public partial class frmConsulta : Form
    {
        csCliente cliente = new csCliente();
        csPedido pedido = new csPedido();

        private ConexaoMySQL conexao = new ConexaoMySQL();
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void preencheSelectNome()
        {
            cboSelectNome.DataSource = cliente.select();
            cboSelectNome.DisplayMember = "nome";
            cboSelectNome.ValueMember = "CPF";

            cboSelectNome.SelectedIndex = -1;  
        }

        private void preencheSelectData()
        {
            cboSelectData.DataSource = pedido.select();
            cboSelectData.DisplayMember = "dataPedido";
            cboSelectData.ValueMember = "dataPedido";

            cboSelectData.SelectedIndex = -1;
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            preencheSelectNome();
            preencheSelectData();

            preencheGrid();
        }


        private void preencheGrid()
        {
            grdSelect.DataSource = select();

            grdSelect.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdSelect.Columns[0].HeaderText = "Nome";
            grdSelect.Columns[1].HeaderText = "Data";
            grdSelect.Columns[2].HeaderText = "Valor Total";

            grdSelect.Columns[0].Width = 180;
            grdSelect.Columns[1].Width = 100;
            grdSelect.Columns[2].Width = 120;
        }

        public DataTable select()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "SELECT cliente.nome, dataPedido, sum(valorTotal)";
            sql += "FROM pedido ";
            sql += "INNER JOIN cliente on pedido.idCliente = cliente.CPF";
            sql += " group by cliente.nome, dataPedido";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        private void preencheGridSelect()
        {
            if (cboSelectData.SelectedIndex != -1)
            {
                grdSelect.DataSource = selectData();
                cboSelectNome.SelectedIndex = -1;
                cboSelectNome.Enabled = false;
            }
            if (cboSelectNome.SelectedIndex != -1)
            {
                grdSelect.DataSource = selectCliente();
                cboSelectData.SelectedIndex = -1;
                cboSelectData.Enabled = false;
            }

            grdSelect.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdSelect.Columns[0].HeaderText = "Nome";
            grdSelect.Columns[1].HeaderText = "Data";
            grdSelect.Columns[2].HeaderText = "Valor Total";

            grdSelect.Columns[0].Width = 180;
            grdSelect.Columns[1].Width = 100;
            grdSelect.Columns[2].Width = 120;

        }

        public DataTable selectData()
        {
            pedido.setDataPedido(Convert.ToDateTime(cboSelectData.SelectedValue));
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "SELECT cliente.nome, dataPedido, valorTotal FROM pedido ";
            sql += "INNER JOIN cliente on pedido.idCliente = cliente.CPF";
            sql += " WHERE dataPedido = '" + pedido.data.ToString("yyyy-MM-dd") + "';";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public DataTable selectCliente()
        {
            cliente.SetCPFCliente(Convert.ToString(cboSelectNome.SelectedValue));
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "SELECT cliente.nome, dataPedido, valorTotal FROM pedido ";
            sql += "INNER JOIN cliente on pedido.idCliente = cliente.CPF";
            sql += " WHERE cliente.CPF = '" + cliente.GetCPFCliente() + "';";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            preencheGridSelect();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            preencheGrid();
            cboSelectNome.SelectedIndex = -1;
            cboSelectData.SelectedIndex = -1;
            cboSelectNome.Enabled = true;
            cboSelectData.Enabled = true;
        }
    }
}

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
using System.Data;

namespace MaterialConstrucao
{
    public partial class CadastroPedido : Form
    {
        csCliente cliente = new csCliente();
        csFuncionario funcionario = new csFuncionario();
        csProduto produto = new csProduto();
        csPedido pedido = new csPedido();
        csItemPedido itemPedido = new csItemPedido();
        CadastroProduto prod = new CadastroProduto();

        public CadastroPedido()
        {
            InitializeComponent();
        }

        private ConexaoMySQL conexao = new ConexaoMySQL();

        private void preencheCliente()
        {
            cboCliente.DataSource = cliente.select();
            cboCliente.DisplayMember = "nome"; // declaração no banco
            cboCliente.ValueMember = "CPF";

            cboCliente.SelectedIndex = -1;
        }

        private void preencheFuncionario()
        {
            cboFuncionario.DataSource = funcionario.select();
            cboFuncionario.DisplayMember = "nome";
            cboFuncionario.ValueMember = "CPF";

            cboFuncionario.SelectedIndex = -1;
        }

        private void preencheProduto()
        {
            cboProduto.DataSource = produto.Select();
            cboProduto.DisplayMember = "nome";
            cboProduto.ValueMember = "numero";

            cboProduto.SelectedIndex = -1;
        }
        private void habilitaControlesPedido(bool status)
        {
            cboCliente.Enabled = status;
            txtData.Enabled = status;
            cboFuncionario.Enabled = status;

            mnuItemPedido.Enabled = status;
        }

        private void habilitaControlesItemPedido(bool status)
        {
            cboProduto.Enabled = status;
            txtEstoque.Enabled = status;
        }
        private void limparControlesPedido()
        {
            pedido.setCPF_Cliente("");
            cboCliente.SelectedIndex = -1;
            txtData.Text = "";
            cboFuncionario.SelectedIndex = -1;
            txtValorTotal.Text = "";
            grdProdutos.Rows.Clear();
        }

        public void limparControlesItemPedido()
        {
            cboProduto.SelectedIndex = -1;
            txtQuantidade.Text = "";
            txtEstoque.Text = "";
        }


        private void gerenciaBotoesBarraPedido(bool status)
        {
            btnNovo.Enabled = status;
            btnEditar.Enabled = status;
            btnExcluir.Enabled = status;
            btnSair.Enabled = status;
            btnSalvar.Enabled = !status;
            btnCancelar.Enabled = !status;
        }
        private void gerenciaBotoesBarraItemPedido(bool status)
        {
            btnNovoProduto.Enabled = status;
            btnEditarProduto.Enabled = status;
            btnExcluirProduto.Enabled = status;
            btnSalvarProduto.Enabled = !status;
            btnCancelarProduto.Enabled = !status;
        }

        private void formataGridPedido()
        {
            grdDadosPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosPedido.Columns[0].HeaderText = "Código";
            grdDadosPedido.Columns[1].HeaderText = "Data";
            grdDadosPedido.Columns[2].HeaderText = "Cliente";

            grdDadosPedido.Columns[0].Width = 0;
            grdDadosPedido.Columns[1].Width = 100;
            grdDadosPedido.Columns[2].Width = 180;
        }

        private void formataGridItemPedido()
        {
            grdProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdProdutos.Columns.Add("Codigo", "Codigo");  
            grdProdutos.Columns.Add("Produto", "Nome Produto");
            grdProdutos.Columns.Add("Quantidade", "Quantidade");
            grdProdutos.Columns.Add("Valor", "Valor");
            grdProdutos.Columns.Add("Total", "Total");

            grdProdutos.Columns[0].Width = 0;
            grdProdutos.Columns[1].Width = 150;
            grdProdutos.Columns[2].Width = 100;
            grdProdutos.Columns[3].Width = 60;
            grdProdutos.Columns[4].Width = 60;

        }

        private void preencheGridPedido()
        {
            grdDadosPedido.DataSource = pedido.select();
            formataGridPedido();
        }

        public void preencheGridItemPedido()
        {
            grdProdutos.Rows.Clear();

            DataSet itens = new DataSet();
            itemPedido.setIdPedido(pedido.getPedidoId()); // Passando o pedido que foi feito pelo cliente

            itens = itemPedido.selectItemPedido_do_Pedido();
            if (itens.Tables[0].Rows.Count > 0) // se existem pedidos...
            {
                foreach (DataRow linha in itens.Tables[0].Rows)
                {
                    DataGridViewRow item = new DataGridViewRow();
                    item.CreateCells(grdProdutos);
                    item.Cells[0].Value = linha[1].ToString(); // codigo do produto
                    item.Cells[1].Value = linha[2].ToString(); // nome do produto
                    item.Cells[2].Value = linha[3].ToString(); // quantidade item pedido
                    item.Cells[3].Value = linha[4].ToString(); // Valor
                    item.Cells[4].Value = linha[5].ToString(); // Valor Total
                    grdProdutos.Rows.Add(item); // Adiciona uma linha
                }
            }
        }

        private void preencheDadosControlePedido()
        {
            pedido.selectPedido();
            cboCliente.SelectedValue = pedido.getCPF_Cliente();
            txtData.Text = pedido.getDataPedido().ToString();
            cboFuncionario.SelectedValue = pedido.getCPF_Funcionario();
            txtValorTotal.Text = pedido.getValorPedido().ToString();
        }

        private void salvarPedido()
        {
            pedido.setCPF_Cliente(Convert.ToString(cboCliente.SelectedValue));
            pedido.setCPF_Funcionario(Convert.ToString(cboFuncionario.SelectedValue));
            pedido.setDataPedido(Convert.ToDateTime(txtData.Text));
            pedido.setValorPedido(pedido.valorTotal);

            if (pedido.getPedidoId() == 0)
            {

                pedido.inserir();

                //busca o ultimo pedido salvo
                pedido.selectPedidoUltimo();
                itemPedido.setIdPedido(pedido.getPedidoId());

                for (int i = 0; i < grdProdutos.Rows.Count; i++)
                {
                    itemPedido.setQuantidade(Convert.ToInt32(grdProdutos.Rows[i].Cells[2].Value.ToString()));
                    cboProduto.ValueMember = "numero";
                    itemPedido.setIdProduto(Convert.ToInt32(grdProdutos.Rows[i].Cells[0].Value.ToString()));
                    itemPedido.inserir();
                }
                grdProdutos.Rows.Clear();
            }
            else
            {
                pedido.update();

                itemPedido.setIdPedido(pedido.getPedidoId());

                itemPedido.deleteAll();

                for (int i = 0; i < grdProdutos.Rows.Count; i++)
                {
                    itemPedido.setQuantidade(Convert.ToDouble(grdProdutos.Rows[i].Cells[2].Value.ToString()));
                    cboProduto.ValueMember = "numero";
                    itemPedido.setIdProduto(Convert.ToInt32(grdProdutos.Rows[i].Cells[0].Value.ToString()));
                    itemPedido.inserir();
                }
                grdProdutos.Rows.Clear();
            }
        }

        private void excluiPedido()
        {
            pedido.delete();
        }

        private void CadastroPedido_Load(object sender, EventArgs e)
        {
            habilitaControlesPedido(false);
            gerenciaBotoesBarraPedido(true);
            preencheGridPedido();

            preencheCliente();
            preencheFuncionario();
            preencheProduto();

            formataGridItemPedido();
            habilitaControlesItemPedido(false);
            gerenciaBotoesBarraItemPedido(true);
            txtQuantidade.Enabled = false;
            txtValorTotal.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaControlesPedido(true);
            limparControlesPedido();
            gerenciaBotoesBarraPedido(false);
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitaControlesPedido(true);
            gerenciaBotoesBarraPedido(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o Pedido?", "Aviso!!!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                habilitaControlesPedido(false);
                limparControlesPedido();
                gerenciaBotoesBarraPedido(true);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvarPedido();
            habilitaControlesPedido(false);
            limparControlesPedido();
            gerenciaBotoesBarraPedido(true);
            preencheGridPedido();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (pedido.getPedidoId() != 0)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir o Pedido?", "Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (retorno == DialogResult.Yes)
                {
                    excluiPedido();
                    limparControlesPedido();
                    preencheGridPedido();
                }
            }
            else
            {
                MessageBox.Show("Selecione o Pedido para Excluir!!", "Aviso!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdDadosPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                pedido.setPedidoId(Convert.ToInt32(grdDadosPedido.Rows[grdDadosPedido.CurrentRow.Index].Cells[0].Value.ToString()));
                preencheDadosControlePedido();
                preencheGridItemPedido();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            habilitaControlesItemPedido(true);
            limparControlesItemPedido();
            gerenciaBotoesBarraItemPedido(false);
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            habilitaControlesItemPedido(true);
            gerenciaBotoesBarraItemPedido(false);
        }

        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            habilitaControlesItemPedido(false);
            limparControlesItemPedido();
            gerenciaBotoesBarraItemPedido(true);
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            DataGridViewRow item = new DataGridViewRow();
            item.CreateCells(grdProdutos);
            if (Convert.ToDouble(txtQuantidade.Text) > Convert.ToDouble(cboProduto.SelectedValue)) 
            {
                MessageBox.Show("Quantidade em estoque insuficiente!", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cboProduto.ValueMember = "numero";
                item.Cells[0].Value = cboProduto.SelectedValue; // numero do produto
                item.Cells[1].Value = cboProduto.Text; // Nome Produto
                item.Cells[2].Value = txtQuantidade.Text; // Quantidade
                cboProduto.ValueMember = "preco";
                item.Cells[3].Value = cboProduto.SelectedValue.ToString(); //Valor do produto
                item.Cells[4].Value = (Convert.ToDouble(cboProduto.SelectedValue) * Convert.ToDouble(txtQuantidade.Text)).ToString();
                grdProdutos.Rows.Add(item);
                pedido.valorTotal += Convert.ToDouble(item.Cells[4].Value);
                cboProduto.ValueMember = "numero";
                double resultado = Convert.ToDouble(txtEstoque.Text) - Convert.ToDouble(txtQuantidade.Text);
                string sql = "UPDATE produto SET QtdEstoque = ";
                sql += resultado.ToString();
                sql += " WHERE numero = '" + cboProduto.SelectedValue.ToString() + "';";
                conexao.executarSql(sql);
                habilitaControlesItemPedido(false);
                limparControlesItemPedido();
                gerenciaBotoesBarraItemPedido(true);
                txtQuantidade.Enabled = false;
            }
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
                grdProdutos.Rows.RemoveAt(grdProdutos.CurrentRow.Index);
        }

        private void grdProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboProduto.ValueMember = "numero";
            cboProduto.SelectedValue = Convert.ToInt32(grdProdutos.Rows[grdProdutos.CurrentRow.Index].Cells[0].Value.ToString());
            txtQuantidade.Text = grdProdutos.Rows[grdProdutos.CurrentRow.Index].Cells[2].Value.ToString();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        { 
                cboProduto.ValueMember = "QtdEstoque";
                txtQuantidade.Enabled = true;
                txtEstoque.Text = cboProduto.SelectedValue.ToString();
        }
        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            cboProduto.DataSource = produto.Select();
            cboProduto.SelectedIndex = -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialConstrucao
{
    public partial class CadastroFuncionario : Form
    {
        csFuncionario func = new csFuncionario();

        bool novoFuncionario = false;
        private void habilitaControles(bool status)
        {
            txtNomeF.Enabled = status;
            txtCPF_F.Enabled = status;
            txtTelefoneF.Enabled = status;
        }

        private void limparControles()
        {
            txtNomeF.Text = "";
            txtCPF_F.Text = "";
            txtTelefoneF.Text = "";
        }

        private void gerenciaBotoesBarra(bool status)
        {
            btnNovo.Enabled = status;
            btnEditar.Enabled = status;
            btnExcluir.Enabled = status;
            btnSair.Enabled = status;
            btnSalvar.Enabled = !status;
            btnCancelar.Enabled = !status;
        }

        private void formataGrid()
        {
            grdDadosFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosFuncionario.Columns[0].HeaderText = "CPF";
            grdDadosFuncionario.Columns[1].HeaderText = "Nome";
            grdDadosFuncionario.Columns[2].HeaderText = "Telefone";

            grdDadosFuncionario.Columns[0].Width = 90;
            grdDadosFuncionario.Columns[1].Width = 100;
            grdDadosFuncionario.Columns[2].Width = 150;
        }

        private void preencheGrid()
        {
            grdDadosFuncionario.DataSource = func.select();
            formataGrid();
        }

        private void excluiFuncionario()
        {
            func.delete();
        }

        private void salvarFuncionario()
        {
            func.setCPF_Funcionario(txtCPF_F.Text);
            func.setNomeFuncionario(txtNomeF.Text);
            func.setTelefoneFuncionario(txtTelefoneF.Text);

            if (novoFuncionario == true) 
            {
                func.inserir();
            }
            else
            {
                func.update();
            }
            novoFuncionario = false;
        }

        private void preencheDadosControles()
        {
            func.selectFuncionario();

            txtCPF_F.Text = func.getCPF_Funcionario();
            txtNomeF.Text = func.getNomeFuncionario();
            txtTelefoneF.Text = func.getTelefoneFuncionario();
        }

        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            habilitaControles(false);
            gerenciaBotoesBarra(true);
            preencheGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaControles(true);
            limparControles();
            gerenciaBotoesBarra(false);
            novoFuncionario = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitaControles(true);
            gerenciaBotoesBarra(false);
            novoFuncionario = false;
            txtCPF_F.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o cadastro do Cliente?", "Aviso!!!",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                habilitaControles(false);
                limparControles();
                gerenciaBotoesBarra(true);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaDados() == true)
            {
                salvarFuncionario();
                habilitaControles(false);
                limparControles();
                gerenciaBotoesBarra(true);
                preencheGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (func.getCPF_Funcionario() != "") 
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir os dados do funcionario selecionado?", "Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (retorno == DialogResult.Yes)
                {
                    excluiFuncionario();
                    limparControles();
                    preencheGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione o Funcionario para excluir", "Aviso!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validaDados()
        {
            if (txtNomeF.Text.Trim().Length <= 3)
            {
                MessageBox.Show("Nome do Funcionário é obrigatório, informe!", "Aviso!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeF.Focus();
                return false;
            }
            if (txtCPF_F.Text.Trim().Length != 14)
            {
                MessageBox.Show("CPF é obrigatório, informe!", "Aviso!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF_F.Focus();
                return false;
            }
            return true;
        }

        private void grdDadosFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDadosFuncionario.CurrentRow != null)
            {
                func.setCPF_Funcionario((grdDadosFuncionario.Rows[grdDadosFuncionario.CurrentRow.Index].Cells[0].Value.ToString()));
                preencheDadosControles();
            }
        }
    }
}

           

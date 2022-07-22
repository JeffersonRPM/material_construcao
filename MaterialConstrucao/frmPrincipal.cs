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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente fcliente = new CadastroCliente();
            fcliente.MdiParent = this; 
            fcliente.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre fSobre = new Sobre();
            fSobre.MdiParent = this;
            fSobre.Show();
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto fProduto = new CadastroProduto();
            fProduto.MdiParent = this;
            fProduto.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario funcionario = new CadastroFuncionario();
            funcionario.MdiParent = this;
            funcionario.Show();
        }

        private void PedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPedido fPedido = new CadastroPedido();
            fPedido.MdiParent = this;
            fPedido.Show();
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(XXX) XXXX-XXXX");
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta();
            consulta.MdiParent = this;
            consulta.Show();
        }
    }
}

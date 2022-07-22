
namespace MaterialConstrucao
{
    partial class CadastroCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.cboSiglaC = new System.Windows.Forms.ComboBox();
            this.lblSiglaC = new System.Windows.Forms.Label();
            this.lblCidadeC = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCidadeC = new System.Windows.Forms.TextBox();
            this.lblNumeroC = new System.Windows.Forms.Label();
            this.lblCEP_C = new System.Windows.Forms.Label();
            this.lblTelefoneC = new System.Windows.Forms.Label();
            this.lblCPF_C = new System.Windows.Forms.Label();
            this.lblNomeC = new System.Windows.Forms.Label();
            this.grdDadosCliente = new System.Windows.Forms.DataGridView();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.txtCEP_C = new System.Windows.Forms.TextBox();
            this.txtCPF_C = new System.Windows.Forms.TextBox();
            this.txtTelefone_C = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosCliente)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSiglaC
            // 
            this.cboSiglaC.FormattingEnabled = true;
            this.cboSiglaC.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboSiglaC.Location = new System.Drawing.Point(372, 211);
            this.cboSiglaC.Name = "cboSiglaC";
            this.cboSiglaC.Size = new System.Drawing.Size(56, 21);
            this.cboSiglaC.TabIndex = 27;
            // 
            // lblSiglaC
            // 
            this.lblSiglaC.AutoSize = true;
            this.lblSiglaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiglaC.Location = new System.Drawing.Point(369, 188);
            this.lblSiglaC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSiglaC.Name = "lblSiglaC";
            this.lblSiglaC.Size = new System.Drawing.Size(60, 20);
            this.lblSiglaC.TabIndex = 25;
            this.lblSiglaC.Text = "Estado";
            // 
            // lblCidadeC
            // 
            this.lblCidadeC.AutoSize = true;
            this.lblCidadeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeC.Location = new System.Drawing.Point(437, 188);
            this.lblCidadeC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidadeC.Name = "lblCidadeC";
            this.lblCidadeC.Size = new System.Drawing.Size(59, 20);
            this.lblCidadeC.TabIndex = 26;
            this.lblCidadeC.Text = "Cidade";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(565, 268);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(72, 20);
            this.txtNumero.TabIndex = 22;
            // 
            // txtCidadeC
            // 
            this.txtCidadeC.Location = new System.Drawing.Point(441, 211);
            this.txtCidadeC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCidadeC.Name = "txtCidadeC";
            this.txtCidadeC.Size = new System.Drawing.Size(225, 20);
            this.txtCidadeC.TabIndex = 23;
            // 
            // lblNumeroC
            // 
            this.lblNumeroC.AutoSize = true;
            this.lblNumeroC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroC.Location = new System.Drawing.Point(561, 243);
            this.lblNumeroC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroC.Name = "lblNumeroC";
            this.lblNumeroC.Size = new System.Drawing.Size(151, 20);
            this.lblNumeroC.TabIndex = 20;
            this.lblNumeroC.Text = "Número Residencial";
            // 
            // lblCEP_C
            // 
            this.lblCEP_C.AutoSize = true;
            this.lblCEP_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP_C.Location = new System.Drawing.Point(368, 243);
            this.lblCEP_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEP_C.Name = "lblCEP_C";
            this.lblCEP_C.Size = new System.Drawing.Size(41, 20);
            this.lblCEP_C.TabIndex = 21;
            this.lblCEP_C.Text = "CEP";
            // 
            // lblTelefoneC
            // 
            this.lblTelefoneC.AutoSize = true;
            this.lblTelefoneC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneC.Location = new System.Drawing.Point(486, 129);
            this.lblTelefoneC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefoneC.Name = "lblTelefoneC";
            this.lblTelefoneC.Size = new System.Drawing.Size(71, 20);
            this.lblTelefoneC.TabIndex = 19;
            this.lblTelefoneC.Text = "Telefone";
            // 
            // lblCPF_C
            // 
            this.lblCPF_C.AutoSize = true;
            this.lblCPF_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF_C.Location = new System.Drawing.Point(369, 129);
            this.lblCPF_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF_C.Name = "lblCPF_C";
            this.lblCPF_C.Size = new System.Drawing.Size(40, 20);
            this.lblCPF_C.TabIndex = 17;
            this.lblCPF_C.Text = "CPF";
            // 
            // lblNomeC
            // 
            this.lblNomeC.AutoSize = true;
            this.lblNomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeC.Location = new System.Drawing.Point(368, 79);
            this.lblNomeC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeC.Name = "lblNomeC";
            this.lblNomeC.Size = new System.Drawing.Size(51, 20);
            this.lblNomeC.TabIndex = 15;
            this.lblNomeC.Text = "Nome";
            // 
            // grdDadosCliente
            // 
            this.grdDadosCliente.AllowUserToAddRows = false;
            this.grdDadosCliente.AllowUserToDeleteRows = false;
            this.grdDadosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosCliente.Location = new System.Drawing.Point(13, 89);
            this.grdDadosCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdDadosCliente.Name = "grdDadosCliente";
            this.grdDadosCliente.ReadOnly = true;
            this.grdDadosCliente.Size = new System.Drawing.Size(330, 302);
            this.grdDadosCliente.TabIndex = 14;
            this.grdDadosCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados_CellClick);
            // 
            // txtNomeC
            // 
            this.txtNomeC.Location = new System.Drawing.Point(373, 104);
            this.txtNomeC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(412, 20);
            this.txtNomeC.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnEditar,
            this.btnCancelar,
            this.btnSalvar,
            this.btnExcluir,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(1200, 154);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(799, 57);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(54, 54);
            this.btnNovo.ToolTipText = "Cadastra novo cliente";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(54, 54);
            this.btnEditar.Text = "toolStripButton2";
            this.btnEditar.ToolTipText = "Edita dados do cliente";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(54, 54);
            this.btnCancelar.Text = "toolStripButton3";
            this.btnCancelar.ToolTipText = "Cancelar cadastro";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(54, 54);
            this.btnSalvar.Text = "toolStripButton4";
            this.btnSalvar.ToolTipText = "Salvar dados do cliente";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(54, 54);
            this.btnExcluir.Text = "toolStripButton5";
            this.btnExcluir.ToolTipText = "Excluir dados do cliente";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 54);
            this.btnSair.Text = "toolStripButton6";
            this.btnSair.ToolTipText = "Sair do cadastro";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtCEP_C
            // 
            this.txtCEP_C.Location = new System.Drawing.Point(372, 268);
            this.txtCEP_C.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCEP_C.Name = "txtCEP_C";
            this.txtCEP_C.Size = new System.Drawing.Size(185, 20);
            this.txtCEP_C.TabIndex = 24;
            // 
            // txtCPF_C
            // 
            this.txtCPF_C.Location = new System.Drawing.Point(373, 153);
            this.txtCPF_C.Name = "txtCPF_C";
            this.txtCPF_C.Size = new System.Drawing.Size(100, 20);
            this.txtCPF_C.TabIndex = 28;
            // 
            // txtTelefone_C
            // 
            this.txtTelefone_C.Location = new System.Drawing.Point(490, 153);
            this.txtTelefone_C.Name = "txtTelefone_C";
            this.txtTelefone_C.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone_C.TabIndex = 28;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 414);
            this.Controls.Add(this.txtTelefone_C);
            this.Controls.Add(this.txtCPF_C);
            this.Controls.Add(this.cboSiglaC);
            this.Controls.Add(this.lblSiglaC);
            this.Controls.Add(this.lblCidadeC);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCidadeC);
            this.Controls.Add(this.txtCEP_C);
            this.Controls.Add(this.lblNumeroC);
            this.Controls.Add(this.lblCEP_C);
            this.Controls.Add(this.lblTelefoneC);
            this.Controls.Add(this.lblCPF_C);
            this.Controls.Add(this.lblNomeC);
            this.Controls.Add(this.grdDadosCliente);
            this.Controls.Add(this.txtNomeC);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosCliente)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSiglaC;
        private System.Windows.Forms.Label lblSiglaC;
        private System.Windows.Forms.Label lblCidadeC;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCidadeC;
        private System.Windows.Forms.Label lblNumeroC;
        private System.Windows.Forms.Label lblCEP_C;
        private System.Windows.Forms.Label lblTelefoneC;
        private System.Windows.Forms.Label lblCPF_C;
        private System.Windows.Forms.Label lblNomeC;
        private System.Windows.Forms.DataGridView grdDadosCliente;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.TextBox txtCEP_C;
        private System.Windows.Forms.TextBox txtCPF_C;
        private System.Windows.Forms.TextBox txtTelefone_C;
    }
}



namespace MaterialConstrucao
{
    partial class CadastroPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPedido));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.grdDadosPedido = new System.Windows.Forms.DataGridView();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.mnuItemPedido = new System.Windows.Forms.ToolStrip();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.lbl_ItemProduto = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.ToolStripButton();
            this.btnEditarProduto = new System.Windows.Forms.ToolStripButton();
            this.btnCancelarProduto = new System.Windows.Forms.ToolStripButton();
            this.btnSalvarProduto = new System.Windows.Forms.ToolStripButton();
            this.btnExcluirProduto = new System.Windows.Forms.ToolStripButton();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.Atualizar = new System.Windows.Forms.ToolStrip();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosPedido)).BeginInit();
            this.mnuItemPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.Atualizar.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.MaximumSize = new System.Drawing.Size(1800, 237);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(836, 57);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // grdDadosPedido
            // 
            this.grdDadosPedido.AllowUserToAddRows = false;
            this.grdDadosPedido.AllowUserToDeleteRows = false;
            this.grdDadosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosPedido.Location = new System.Drawing.Point(15, 65);
            this.grdDadosPedido.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.grdDadosPedido.Name = "grdDadosPedido";
            this.grdDadosPedido.ReadOnly = true;
            this.grdDadosPedido.Size = new System.Drawing.Size(290, 465);
            this.grdDadosPedido.TabIndex = 42;
            this.grdDadosPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosPedido_CellClick);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(495, 175);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(91, 26);
            this.txtData.TabIndex = 43;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(491, 151);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 20);
            this.lblData.TabIndex = 44;
            this.lblData.Text = "Data";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(326, 98);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(208, 28);
            this.cboCliente.TabIndex = 45;
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(540, 98);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(210, 28);
            this.cboFuncionario.TabIndex = 46;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(322, 75);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 47;
            this.lblCliente.Text = "Cliente";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(536, 75);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(92, 20);
            this.lblProduto.TabIndex = 48;
            this.lblProduto.Text = "Funcionário";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(322, 151);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(85, 20);
            this.lblValorTotal.TabIndex = 49;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(326, 175);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(162, 26);
            this.txtValorTotal.TabIndex = 50;
            // 
            // mnuItemPedido
            // 
            this.mnuItemPedido.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuItemPedido.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.mnuItemPedido.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovoProduto,
            this.btnEditarProduto,
            this.btnCancelarProduto,
            this.btnSalvarProduto,
            this.btnExcluirProduto});
            this.mnuItemPedido.Location = new System.Drawing.Point(317, 219);
            this.mnuItemPedido.MaximumSize = new System.Drawing.Size(1800, 237);
            this.mnuItemPedido.Name = "mnuItemPedido";
            this.mnuItemPedido.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.mnuItemPedido.Size = new System.Drawing.Size(284, 57);
            this.mnuItemPedido.TabIndex = 51;
            this.mnuItemPedido.Text = "toolStrip2";
            // 
            // grdProdutos
            // 
            this.grdProdutos.AllowUserToAddRows = false;
            this.grdProdutos.AllowUserToDeleteRows = false;
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Location = new System.Drawing.Point(317, 284);
            this.grdProdutos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.ReadOnly = true;
            this.grdProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdProdutos.Size = new System.Drawing.Size(433, 130);
            this.grdProdutos.TabIndex = 42;
            this.grdProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProdutos_CellClick);
            // 
            // cboProduto
            // 
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(317, 445);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(208, 28);
            this.cboProduto.TabIndex = 45;
            // 
            // lbl_ItemProduto
            // 
            this.lbl_ItemProduto.AutoSize = true;
            this.lbl_ItemProduto.Location = new System.Drawing.Point(313, 422);
            this.lbl_ItemProduto.Name = "lbl_ItemProduto";
            this.lbl_ItemProduto.Size = new System.Drawing.Size(65, 20);
            this.lbl_ItemProduto.TabIndex = 47;
            this.lbl_ItemProduto.Text = "Produto";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(536, 422);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(147, 20);
            this.lblQuantidade.TabIndex = 47;
            this.lblQuantidade.Text = "Quantidade (Saída)";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(540, 447);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(162, 26);
            this.txtQuantidade.TabIndex = 50;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(494, 499);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(162, 26);
            this.txtEstoque.TabIndex = 50;
            this.txtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(341, 494);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(147, 36);
            this.btnEstoque.TabIndex = 52;
            this.btnEstoque.Text = "Verificar Estoque:";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovoProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoProduto.Image")));
            this.btnNovoProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(54, 54);
            this.btnNovoProduto.Text = "toolStripButton1";
            this.btnNovoProduto.ToolTipText = "Cadastra novo produto";
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProduto.Image")));
            this.btnEditarProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(54, 54);
            this.btnEditarProduto.Text = "toolStripButton2";
            this.btnEditarProduto.ToolTipText = "Edita dados do produto";
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarProduto.Image")));
            this.btnCancelarProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(54, 54);
            this.btnCancelarProduto.Text = "toolStripButton3";
            this.btnCancelarProduto.ToolTipText = "Cancelar cadastro";
            this.btnCancelarProduto.Click += new System.EventHandler(this.btnCancelarProduto_Click);
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarProduto.Image")));
            this.btnSalvarProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(54, 54);
            this.btnSalvarProduto.Text = "toolStripButton4";
            this.btnSalvarProduto.ToolTipText = "Salvar dados do produto";
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluirProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirProduto.Image")));
            this.btnExcluirProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(54, 54);
            this.btnExcluirProduto.Text = "toolStripButton5";
            this.btnExcluirProduto.ToolTipText = "Excluir dados do produto";
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(54, 54);
            this.btnNovo.Text = "toolStripButton1";
            this.btnNovo.ToolTipText = "Cadastra novo pedido";
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
            this.btnEditar.ToolTipText = "Edita dados do pedido";
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
            this.btnSalvar.ToolTipText = "Salvar pedido";
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
            this.btnExcluir.ToolTipText = "Excluir pedido";
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
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.Color.Transparent;
            this.Atualizar.Dock = System.Windows.Forms.DockStyle.None;
            this.Atualizar.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.Atualizar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAtualizar});
            this.Atualizar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Atualizar.Location = new System.Drawing.Point(673, 493);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(46, 37);
            this.Atualizar.TabIndex = 53;
            this.Atualizar.Text = "Atualizar";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(34, 34);
            this.btnAtualizar.Text = "toolStripButton1";
            this.btnAtualizar.ToolTipText = "Atualizar Estoque";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // CadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 547);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.mnuItemPedido);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lbl_ItemProduto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.cboProduto);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.grdProdutos);
            this.Controls.Add(this.grdDadosPedido);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadastroPedido";
            this.Text = "CadastroPedido";
            this.Load += new System.EventHandler(this.CadastroPedido_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosPedido)).EndInit();
            this.mnuItemPedido.ResumeLayout(false);
            this.mnuItemPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.Atualizar.ResumeLayout(false);
            this.Atualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.DataGridView grdDadosPedido;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.ToolStrip mnuItemPedido;
        private System.Windows.Forms.ToolStripButton btnNovoProduto;
        private System.Windows.Forms.ToolStripButton btnEditarProduto;
        private System.Windows.Forms.ToolStripButton btnCancelarProduto;
        private System.Windows.Forms.ToolStripButton btnSalvarProduto;
        private System.Windows.Forms.ToolStripButton btnExcluirProduto;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.Label lbl_ItemProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.ToolStrip Atualizar;
        private System.Windows.Forms.ToolStripButton btnAtualizar;
    }
}
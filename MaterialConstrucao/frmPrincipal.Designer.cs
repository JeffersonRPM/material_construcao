
namespace MaterialConstrucao
{
    partial class frmPrincipal
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
            this.CadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // CadastroToolStripMenuItem
            // 
            this.CadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClienteToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.ProdutoToolStripMenuItem,
            this.PedidoToolStripMenuItem});
            this.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem";
            this.CadastroToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.CadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // ClienteToolStripMenuItem
            // 
            this.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem";
            this.ClienteToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.ClienteToolStripMenuItem.Text = "Cliente";
            this.ClienteToolStripMenuItem.Click += new System.EventHandler(this.ClienteToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // ProdutoToolStripMenuItem
            // 
            this.ProdutoToolStripMenuItem.Name = "ProdutoToolStripMenuItem";
            this.ProdutoToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.ProdutoToolStripMenuItem.Text = "Produto";
            this.ProdutoToolStripMenuItem.Click += new System.EventHandler(this.ProdutoToolStripMenuItem_Click);
            // 
            // PedidoToolStripMenuItem
            // 
            this.PedidoToolStripMenuItem.Name = "PedidoToolStripMenuItem";
            this.PedidoToolStripMenuItem.Size = new System.Drawing.Size(184, 30);
            this.PedidoToolStripMenuItem.Text = "Pedido";
            this.PedidoToolStripMenuItem.Click += new System.EventHandler(this.PedidoToolStripMenuItem_Click);
            // 
            // ConsultaToolStripMenuItem
            // 
            this.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem";
            this.ConsultaToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.ConsultaToolStripMenuItem.Text = "Consulta";
            this.ConsultaToolStripMenuItem.Click += new System.EventHandler(this.ConsultaToolStripMenuItem_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastroToolStripMenuItem,
            this.ConsultaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 33);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.contatoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // contatoToolStripMenuItem
            // 
            this.contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            this.contatoToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.contatoToolStripMenuItem.Text = "Contato";
            this.contatoToolStripMenuItem.Click += new System.EventHandler(this.contatoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MaterialConstrucao.Properties.Resources.A_importância_do_CRM_para_lojas_de_materiais_de_construção;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "Material de Construção";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem CadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatoToolStripMenuItem;
    }
}

namespace MaterialConstrucao
{
    partial class frmConsulta
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
            this.grdSelect = new System.Windows.Forms.DataGridView();
            this.cboSelectNome = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cboSelectData = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblNomes = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSelect
            // 
            this.grdSelect.AllowUserToAddRows = false;
            this.grdSelect.AllowUserToDeleteRows = false;
            this.grdSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSelect.Location = new System.Drawing.Point(16, 105);
            this.grdSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdSelect.Name = "grdSelect";
            this.grdSelect.ReadOnly = true;
            this.grdSelect.Size = new System.Drawing.Size(434, 374);
            this.grdSelect.TabIndex = 0;
            // 
            // cboSelectNome
            // 
            this.cboSelectNome.FormattingEnabled = true;
            this.cboSelectNome.Location = new System.Drawing.Point(16, 69);
            this.cboSelectNome.Name = "cboSelectNome";
            this.cboSelectNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboSelectNome.Size = new System.Drawing.Size(160, 28);
            this.cboSelectNome.TabIndex = 1;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(12, 9);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(80, 20);
            this.lblSelect.TabIndex = 2;
            this.lblSelect.Text = "Filtrar por:";
            // 
            // cboSelectData
            // 
            this.cboSelectData.FormattingEnabled = true;
            this.cboSelectData.Location = new System.Drawing.Point(182, 69);
            this.cboSelectData.Name = "cboSelectData";
            this.cboSelectData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboSelectData.Size = new System.Drawing.Size(160, 28);
            this.cboSelectData.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(364, 69);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(86, 28);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Buscar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(457, 451);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 28);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar os Filtros";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblNomes
            // 
            this.lblNomes.AutoSize = true;
            this.lblNomes.Location = new System.Drawing.Point(12, 46);
            this.lblNomes.Name = "lblNomes";
            this.lblNomes.Size = new System.Drawing.Size(126, 20);
            this.lblNomes.TabIndex = 4;
            this.lblNomes.Text = "Nome do Cliente";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(178, 46);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(119, 20);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data do Pedido";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 505);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNomes);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cboSelectData);
            this.Controls.Add(this.cboSelectNome);
            this.Controls.Add(this.grdSelect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSelect;
        private System.Windows.Forms.ComboBox cboSelectNome;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cboSelectData;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblNomes;
        private System.Windows.Forms.Label lblData;
    }
}
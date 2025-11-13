namespace WFA_Estoque
{
    partial class MainForm
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
            this.pnlEstoque = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.lvwEstoque = new System.Windows.Forms.ListView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.tbxFornecedor = new System.Windows.Forms.TextBox();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.pnlEstoque.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEstoque
            // 
            this.pnlEstoque.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlEstoque.Controls.Add(this.btnNovo);
            this.pnlEstoque.Controls.Add(this.btnEditar);
            this.pnlEstoque.Controls.Add(this.btnRemover);
            this.pnlEstoque.Controls.Add(this.tbxBuscar);
            this.pnlEstoque.Controls.Add(this.lvwEstoque);
            this.pnlEstoque.Controls.Add(this.lblBuscar);
            this.pnlEstoque.Controls.Add(this.lblEstoque);
            this.pnlEstoque.Location = new System.Drawing.Point(12, 12);
            this.pnlEstoque.Name = "pnlEstoque";
            this.pnlEstoque.Size = new System.Drawing.Size(468, 440);
            this.pnlEstoque.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(9, 406);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 24);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(165, 406);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 24);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar Selecionado";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(338, 406);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 24);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover Selecionado";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.Location = new System.Drawing.Point(134, 104);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(324, 20);
            this.tbxBuscar.TabIndex = 1;
            this.tbxBuscar.TextChanged += new System.EventHandler(this.tbxBuscar_TextChanged);
            // 
            // lvwEstoque
            // 
            this.lvwEstoque.HideSelection = false;
            this.lvwEstoque.Location = new System.Drawing.Point(10, 127);
            this.lvwEstoque.Name = "lvwEstoque";
            this.lvwEstoque.Size = new System.Drawing.Size(448, 273);
            this.lvwEstoque.TabIndex = 1;
            this.lvwEstoque.UseCompatibleStateImageBehavior = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(6, 105);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(131, 19);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar por nome:";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(0, 11);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(164, 49);
            this.lblEstoque.TabIndex = 0;
            this.lblEstoque.Text = "Estoque";
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCadastro.Controls.Add(this.btnSalvar);
            this.pnlCadastro.Controls.Add(this.tbxQuantidade);
            this.pnlCadastro.Controls.Add(this.tbxPreco);
            this.pnlCadastro.Controls.Add(this.tbxFornecedor);
            this.pnlCadastro.Controls.Add(this.tbxDescricao);
            this.pnlCadastro.Controls.Add(this.tbxCodigo);
            this.pnlCadastro.Controls.Add(this.lblQuantidade);
            this.pnlCadastro.Controls.Add(this.lblPreco);
            this.pnlCadastro.Controls.Add(this.lblFornecedor);
            this.pnlCadastro.Controls.Add(this.lblDescricao);
            this.pnlCadastro.Controls.Add(this.lblCodigo);
            this.pnlCadastro.Controls.Add(this.lblCadastro);
            this.pnlCadastro.Location = new System.Drawing.Point(494, 12);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(328, 440);
            this.pnlCadastro.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(132, 406);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 24);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(105, 322);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(213, 20);
            this.tbxQuantidade.TabIndex = 1;
            // 
            // tbxPreco
            // 
            this.tbxPreco.Location = new System.Drawing.Point(105, 274);
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.Size = new System.Drawing.Size(213, 20);
            this.tbxPreco.TabIndex = 1;
            this.tbxPreco.Enter += new System.EventHandler(this.tbxPreco_Enter);
            this.tbxPreco.Leave += new System.EventHandler(this.tbxPreco_Leave);
            // 
            // tbxFornecedor
            // 
            this.tbxFornecedor.Location = new System.Drawing.Point(105, 224);
            this.tbxFornecedor.Name = "tbxFornecedor";
            this.tbxFornecedor.Size = new System.Drawing.Size(213, 20);
            this.tbxFornecedor.TabIndex = 1;
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(105, 175);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(213, 20);
            this.tbxDescricao.TabIndex = 1;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(105, 126);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(213, 20);
            this.tbxCodigo.TabIndex = 1;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(3, 323);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(96, 19);
            this.lblQuantidade.TabIndex = 0;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(45, 274);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(54, 19);
            this.lblPreco.TabIndex = 0;
            this.lblPreco.Text = "Preço:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(6, 225);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(93, 19);
            this.lblFornecedor.TabIndex = 0;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(18, 176);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(81, 19);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(36, 127);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(81, 11);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(177, 49);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Cadastro";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(834, 464);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.pnlEstoque);
            this.Name = "MainForm";
            this.Text = "Gerenciamento de Estoque Unitri";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlEstoque.ResumeLayout(false);
            this.pnlEstoque.PerformLayout();
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEstoque;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.TextBox tbxPreco;
        private System.Windows.Forms.TextBox tbxFornecedor;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.ListView lvwEstoque;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
    }
}


namespace WFA_Estoque
{
    partial class Form1
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
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlEstoque
            // 
            this.pnlEstoque.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEstoque.Location = new System.Drawing.Point(12, 12);
            this.pnlEstoque.Name = "pnlEstoque";
            this.pnlEstoque.Size = new System.Drawing.Size(494, 354);
            this.pnlEstoque.TabIndex = 0;
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCadastro.Location = new System.Drawing.Point(512, 12);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(276, 426);
            this.pnlCadastro.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.pnlEstoque);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEstoque;
        private System.Windows.Forms.Panel pnlCadastro;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Estoque
{
    public partial class MainForm : Form
    {
        
        private Estoque estoque = new Estoque();

        private string caminhoCsv = "produtos.csv";
      
        public MainForm()
        {
            InitializeComponent();

            ConfigurarListView();
            AtualizarLista();
        }

        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lvwEstoque.SelectedItems.Clear();
            tbxCodigo.ReadOnly = false;
            tbxCodigo.Focus();

            LimparFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarSelecionado();
        }

        private void EditarSelecionado()
        {
            var p = ProdutoSelecionado();
            if (p != null)
            {
                //MessageBox.Show("Selecione um item padra editar.", "Atenção", );
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                var p = ProdutoSelecionado();
                if (p != null)
                {
                    if (MessageBox.Show($"Remover o produto '{p.Descricao}' (codigo {p.Codigo})?",
                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        estoque.RemoverProdutoPorCodigo(p.Codigo);
                        AtualizarLista();
                        SalvarCsv();
                    }
                }
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Produto ProdutoSelecionado()
        {
            if (lvwEstoque.SelectedItems.Count == 0)
                return null;

            var item = lvwEstoque.SelectedItems[0];
            string codigo = item.SubItems[0].Text.Trim();
            return estoque.BuscarProdutoPorCodigo(codigo);
        }
    }       

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            { 
                var p = ProdutoSelecionado();
                if (p == null)
                {
                    MessageBox.Show("Selecione um item para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show($"Remover o produto '{p.Descricao}' (código {p.Codigo})?",
                                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    estoque.RemoverProdutoPorCodigo(p.Codigo);
                    AtualizarLista();
                    SalvarCsv();
                }
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível remover o produto.\nDetalhes: {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var p = LerFormulario();

                if (lvwEstoque.SelectedItems.Count == 0)
                {
                    if (estoque.BuscarProdutoPorCodigo(p.Codigo) != null)
                        throw new InvalidOperationException($"Já existe um produto com código '{p.Codigo}");

                    estoque.AdicionarProduto(p);
                }
                else
                {
                    var codigoOriginal = lvwEstoque.SelectedItems[0].SubItems[0].Text;

                    p.Codigo = codigoOriginal;

                    estoque.AtualizarProduto(p);    
                }

                AtualizarLista();
                lvwEstoque.SelectedItems.Clear();
                tbxCodigo.ReadOnly = false;
                LimparFormulario();

                MessageBox.Show("Produto Salvo com sucesso.", "Sucesso", MessageBoxButtons.OK);
                SalvarCsv();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível salvar o produto.\nDetalhes: {ex.Message}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CarregarCsv();
        }

        private void tbxPreco_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(tbxPreco.Text, NumberStyles.Any, new CultureInfo("pt-br"), out float valor))
            {
                tbxPreco.Text = valor.ToString("C2", new CultureInfo("pt-br"));
            }
        }

        private void tbxPreco_Enter(object sender, EventArgs e)
        {
            tbxPreco.Text = tbxPreco.Text.Replace("R$", "").Trim();
        }

        public void SalvarCsv()
        {
            try
            {
                using (var sw = new StreamWriter(caminhoCsv, false))
                {
                    foreach (var p in estoque.Itens)
                    {
                        string linha = $"{p.Codigo.Replace(";", " ")};{p.Descricao.Replace(";", " ")};{p.Fornecedor.Replace(";", " ")};{p.Preco.ToString("0.##", new CultureInfo("pt-BR"))};{p.Quantidade}";
                        sw.WriteLine(linha);
                    }

                }
                MessageBox.Show("Produtos salvos em produtos.csv", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Não tem permissão para salvar o arquivo.", "Permissão negada.", MessageBoxButtons.OK);
            }
            catch (IOException)
            {
                MessageBox.Show("Não foi possivel salvar, inacessível ou em uso.", "Arquivo em uso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar CSV.\nDetalhes: {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void CarregarCsv()
        {
            try
            {
                if (!File.Exists(caminhoCsv))
                {
                    MessageBox.Show("Arquivo produto.csv não encontrado", "Informação", MessageBoxButtons.OK);
                    return;
                }

                var novo = new Estoque();

                int erros = 0;

                using (var sr = new StreamReader(caminhoCsv))
                {
                    while (!sr.EndOfStream)
                    {
                        string linha = sr.ReadLine();
                        if (string.IsNullOrWhiteSpace(linha))
                            continue;

                        try
                        {
                            string[] partes = linha.Split(';');
                            if (partes.Length < 5)
                                throw new FormatException("Linha com colunas insuficientes");

                            string codigo = partes[0];
                            string descricao = partes[1];
                            string fornecedor = partes[2];
                            float preco = float.Parse(partes[3], new CultureInfo("pt-br"));
                            int quantidade = int.Parse(partes[4]);

                            novo.AdicionarProduto(new Produto(codigo, descricao, fornecedor, preco, quantidade));
    
                        }
                        catch
                        {
                            erros++;
                        }
                    }
                }

                estoque.Itens.Clear();
                foreach (var p in novo.Itens)
                    estoque.Itens.Add(p);

                AtualizarLista();

                if (erros > 0)
                    MessageBox.Show($"Arquivo foi carregado com avisos. Linhas com erro: {erros}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Arquivo carregado com sucesso!", "Sucesso", MessageBoxButtons.OK);
            }
            catch (IOException)
            {
                MessageBox.Show("Arquivo em uso ou inacessível.", "Arquivo em uso.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado ao carregar arquivo.\nDetlhes: {ex}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditarSelecionado()
        {
            var p = ProdutoSelecionado();
            if (p == null)
            {
                MessageBox.Show("Selecione um item para editar.", "Item não selecionado", MessageBoxButtons.OK);
                return;
            }

            tbxCodigo.Text = p.Codigo;
            tbxDescricao.Text = p.Descricao;
            tbxFornecedor.Text = p.Fornecedor;
            tbxPreco.Text = p.Preco.ToString("0.##", new CultureInfo("pt-br"));
            tbxQuantidade.Text = p.Quantidade.ToString();

            tbxCodigo.ReadOnly = true;
            tbxCodigo.Focus();
            tbxCodigo.SelectAll();
        }
        private void LimparFormulario()
        {
            tbxCodigo.Clear();
            tbxDescricao.Clear();
            tbxFornecedor.Clear();
            tbxPreco.Clear();
            tbxQuantidade.Clear();

            tbxCodigo.Focus();
        }

        private Produto ProdutoSelecionado()
        {
            if (lvwEstoque.SelectedItems.Count == 0)
                return null;

            var item = lvwEstoque.SelectedItems[0];
            string codigo = item.SubItems[0].Text.Trim();
            return estoque.BuscarProdutoPorCodigo(codigo);
        }

        private void AtualizarLista()
        {
            var dados = estoque.BuscarProdutoPorDescricao(tbxBuscar.Text);

            lvwEstoque.BeginUpdate();
            lvwEstoque.Items.Clear();

            for (int i = 0; i < dados.Count; i++)
            {
                var p = dados[i];
                var item = new ListViewItem(p.Codigo);
                item.SubItems.Add(p.Descricao);
                item.SubItems.Add(p.Fornecedor);
                item.SubItems.Add(p.Preco.ToString("0.##", new CultureInfo("pt-bt")));
                item.SubItems.Add(p.Quantidade.ToString());

                item.Tag = p;

                lvwEstoque.Items.Add(item);

            }

            lvwEstoque.EndUpdate();

            for (int i = 0; i < lvwEstoque.Columns.Count; i++)
                lvwEstoque.Columns[i].Width = -2;
        }

        private void ConfigurarListView()
        {
            lvwEstoque.View = View.Details;
            lvwEstoque.FullRowSelect = true;
            lvwEstoque.GridLines = true;
            lvwEstoque.MultiSelect = false;
            lvwEstoque.HideSelection = false;

            if (lvwEstoque.Columns.Count == 0)
            {
                lvwEstoque.Columns.Add("Código", 100, HorizontalAlignment.Left);
                lvwEstoque.Columns.Add("Descrição", 220, HorizontalAlignment.Left);
                lvwEstoque.Columns.Add("Fornecedor", 160, HorizontalAlignment.Left);
                lvwEstoque.Columns.Add("Preço", 80, HorizontalAlignment.Right);
                lvwEstoque.Columns.Add("Quantidade", 90, HorizontalAlignment.Right);
            }

        }

        private Produto LerFormulario()
        {
            string codigo = tbxCodigo.Text.Trim();
            string descricao = tbxDescricao.Text.Trim();
            string fornecedor = tbxFornecedor.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("O Código não pode estar vazio.");
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentException("A Descrição não pode estar vazia.");

            string textoPreco = tbxPreco.Text.Replace("R$", "").Trim();

            if (!float.TryParse(textoPreco, NumberStyles.Float, new CultureInfo("pt-br"), out float preco))
                throw new FormatException("Preço ivalido. Use vírgula como separador decimal (ex.: 10,50).");
            if (!int.TryParse(tbxQuantidade.Text.Trim(), out int quantidade))
                throw new FormatException("Quantidade inválida, use números inteiros.");

            return new Produto(codigo, descricao, fornecedor, preco, quantidade);
        }



    }       

}

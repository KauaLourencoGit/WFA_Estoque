using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Estoque
{
    internal class Produto
    {
        private string codigo;
        private string descricao;
        private string fornecedor;
        private float preco;
        private int quantidade;

        public Produto(string codigo, string descricao, string fornecedor, float preco, int quantidade)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.fornecedor = fornecedor;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
        public float Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Estoque
{
    internal class Estoque
    {
        private List<Produto> itens = new List<Produto>();

        public List<Produto> Itens { get => itens; set => itens = value; }


        public void ValidarProduto(Produto p)
        {
            if (p == null)
                throw new ArgumentNullException(nameof(p), "O produto não pode ser nulo.");
            if (string.IsNullOrWhiteSpace(p.Codigo))
                throw new ArgumentException("O Código não pode estar vazio.");
            if (string.IsNullOrWhiteSpace(p.Descricao))
                throw new ArgumentException("A Descrição não pode estar vazia.");
            if (p.Preco < 0)
                throw new ArgumentException("O preço não pode ser negativo.");
            if (p.Quantidade < 0)
                throw new ArgumentException("A quantidade não pode ser negativa.");
        }
        
        public void AdicionarProduto(Produto p)
        {
            ValidarProduto(p);

            //if (BuscarProdutoPorCodigo(p.Codigo) != null)
                //throw new InvalidOperationException($"Já existe um produto com o código '{p.Codigo}'.");

            Itens.Add(p);

        }

        
    }
}

using Loja.Models.Entity;
using Loja.Repository;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Service
{
    public class ProdutoService
    {
        private ProdutoRepository produtoRepository;

        public ProdutoService(ProdutoRepository repository)
        {
            produtoRepository = repository;
        }

        public List<Produto> getListaProduto()
        {
            var listaProduto = produtoRepository.Get();

            return listaProduto;
        }

        public List<Produto> getProduto()
        {
            var listaProduto = produtoRepository.Get();

            return listaProduto;
        }

        public bool InsertProduto(Produto produto)
        {
            return produtoRepository.InsertProduto(produto);
        }

        public bool AlterarProduto(Produto produto)
        {
            return produtoRepository.AlterarProduto(produto);
        }

    }
}

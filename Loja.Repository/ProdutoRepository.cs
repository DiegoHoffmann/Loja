using Loja.Models.Entity;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Repository
{
    public class ProdutoRepository
    {
        private readonly IMongoCollection<Produto> _produtos;
        public ProdutoRepository(ILojaDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _produtos = database.GetCollection<Produto>(settings.LojaCollectionName);
        }

        public List<Produto> Get() =>
            _produtos.Find(produto => true).ToList();

        public bool InsertProduto(Produto produto)
        {
            _produtos.InsertOne(produto);
            return true;
        
        }

        public bool AlterarProduto(Produto produtoIn)
        {
            _produtos.ReplaceOne(produto => produto.Id == produtoIn.Id, produtoIn);
            return true;
        }
    }
}

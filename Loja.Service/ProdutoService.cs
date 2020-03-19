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
        private readonly IMongoCollection<Produto> _produtos;

        public ProdutoService(ILojaDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _produtos = database.GetCollection<Produto>(settings.LojaCollectionName);
        }

        public List<Produto> Get() =>
            _produtos.Find(produto => produto.Id == 1).ToList();
    }
}

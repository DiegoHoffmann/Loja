using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Models.Entity
{
    public class Produto
    {
        [BsonId]
        public int Id { get; set; }
        [BsonElement("nome")]
        public string Nome { get; set; }
        [BsonElement("valor")]
        public decimal Valor { get; set; }
        public int IdCategoria { get; set; }

    }
}

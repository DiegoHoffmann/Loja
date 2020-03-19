using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Repository
{
    public class LojaDatabaseSettings : ILojaDatabaseSettings
    {
        public string LojaCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ILojaDatabaseSettings
    {
        string LojaCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}

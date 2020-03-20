using System.Collections.Generic;
using AutoMapper;
using Loja.Models.DTO;
using Loja.Models.Entity;
using Loja.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Loja.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutoService ProdutoService;
        private IMapper Imapper;

        public ProdutosController(ProdutoService produtoService, IMapper mapper)
        {
            ProdutoService = produtoService;
            Imapper = mapper;
        }
        // GET: /<controller>/
        [HttpGet("lista-produto")]
        public List<ProdutoDTO> ListarProdutos()
        {
            var produto = ProdutoService.getListaProduto();

            List<ProdutoDTO> lstProd = Imapper.Map<List<ProdutoDTO>>(produto);
           
            return lstProd;
        }

        [HttpPost("inserir-produto")]
        public bool InserirProduto(Produto produto)
        {
            return ProdutoService.InsertProduto(produto);
        }

        [HttpPut("alterar-produto")]
        public bool AlterarProduto(string id, Produto produto)
        { 
            ProdutoService.AlterarProduto(produto);
            return true;
        }

    }
}

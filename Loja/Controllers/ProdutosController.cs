using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Loja.Models.DTO;
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
        public ProdutoDTO ListarProdutos()
        {
            var produto = ProdutoService.Get().FirstOrDefault();

            var prod = Imapper.Map<ProdutoDTO>(produto);
           
            return prod;
        }
    }
}

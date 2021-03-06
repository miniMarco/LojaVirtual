using LojaVirtual.Dominio.Entidade;
using LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepositorio _repositorio;
        // GET: Produtos
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            IEnumerable<Produto> produtos = _repositorio.Produtos.Take(10);
            return View(produtos);
        }
    }
}
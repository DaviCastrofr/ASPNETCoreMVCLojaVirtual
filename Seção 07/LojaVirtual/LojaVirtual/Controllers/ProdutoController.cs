using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Vizualizar()
        {
            return View();
        }
        private Produto GetProduto()
        {
            return new Produto
            Id = 1,
            N = "asdasdasd",
            de = "sdasdas",
            v = 474.00M   }
    }
}

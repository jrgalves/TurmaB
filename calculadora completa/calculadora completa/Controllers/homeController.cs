using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace calculadora_completa.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        // POST: home
        [HttpPost]
        public ActionResult Index(string bt)
        {
            //determinar qual o conteudo do botao
            return View();
        }
    }
}
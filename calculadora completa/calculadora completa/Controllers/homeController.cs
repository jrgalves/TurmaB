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
            ViewBag.visor = "0";
            Session["PrimeiroOperador"] = true;
            return View();
        }
        // POST: home
        [HttpPost]
        public ActionResult Index(string bt,string visor)
        {
            switch (bt) {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    //determinar se no visor so existe zero
                    if (visor.Equals("0")) visor = bt;
                    else visor += bt;
                    //visor =visor+bt
                    break;
                case ",":
                    if (!visor.Contains(",")) visor += ",";
                        break;
                case "+/-":
                    // visor = Convert.ToDouble(visor) * -1 + "";
                    if (visor.StartsWith("-")) visor = visor.Replace("-", "");
                    else if (!visor.Equals("0")) visor = "-" + visor;
                    break;
                case "C":
                    visor = "0";
                    Session["PrimeiroOperador"] = true;
                    break;
                case "+":
                case "-":
                case "x":
                case ":":
                    if ((bool)Session["PrimeiroOperador"])
                    {
                        //guardar valor do visor
                        Session["operando"] = visor;
                        //limpar o visor
                        visor = "0";
                        //guardar o operador
                        Session["operador"] = bt;
                        //marcar como tendo utilizado o operador
                        Session["PrimeiroOperador"] = false;
                    }
                    else
                    {
                        //se nao é a primeira vez que se clica num operador
                        //vou utilizar os valores anteriores
                        switch ((string)Session["operador"])
                        {
                            //recuperar codigo da primeira calculadora
                            case "":
                                break;
                        }
                        //guardar os novos valores

                    }
                    break;
            }
            //entregar os valores a view
            ViewBag.Visor = visor;    
            //determinar qual o conteudo do botao
            return View();
        }
    }
}
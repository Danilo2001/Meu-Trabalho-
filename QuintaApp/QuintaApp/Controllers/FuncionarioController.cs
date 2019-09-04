using QuintaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuintaApp.Models
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {

            Funcionario funcionario = new Funcionario()
            {
                FuncId = 1,
                FuncNome = "Broquinho",
                FuncFuncao = "Fulião"
            };
            return View(funcionario);
        }

        [HttpPost]
        public ActionResult Listar(Funcionario funcionario)
        {
            return View(funcionario);
        }
    }
}
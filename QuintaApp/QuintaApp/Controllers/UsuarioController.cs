using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuintaApp.Models;

namespace QuintaApp.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }

        public ActionResult ValidaLogin(string login)
        {
            var dbEXMPLO = new Collection<string>
            {
                "Caraio",
                "Fedendo",
                "Infante"
            };
            return Json(dbEXMPLO.All(a => a.ToLower() != login.ToLower()),JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            /*if (string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "O campo Nome é obrigátorio");
            }*/
            
            if (usuario.Senha != usuario.ConfirmarSenha)
            {
                ModelState.AddModelError("", "As senhas são diferentes");
            }

            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }
         
        public ActionResult Resultado (Usuario usuario)
        {
            return View(usuario);
        }
    }
}
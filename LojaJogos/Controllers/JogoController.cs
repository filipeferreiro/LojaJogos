using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaJogos.Models;

namespace LojaJogos.Controllers
{
    public class JogoController : Controller
    {
        public ActionResult Index()
        {
            Jogo jogo = new Jogo();
            return View(jogo);
        }

        [HttpPost]
        public ActionResult Index(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                return View("Listar", jogo);
            }
            return View(jogo);
        }
        public ActionResult Listar(Jogo jogo)
        {
            return View(jogo);
        }
    }
}
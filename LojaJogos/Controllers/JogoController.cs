using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaJogos.Models;
using LojaJogos.Repositorio;

namespace LojaJogos.Controllers
{
    public class JogoController : Controller
    {
        public ActionResult Index()
        {
            Jogo jogo = new Jogo();
            return View(jogo);
        }
        Acoes acoes = new Acoes();

        [HttpPost]
        public ActionResult Cadjogo(Jogo jogo)
        {
            acoes.CadastrarJogo(jogo);
            return View(jogo);
        }
        public ActionResult ListarJogos()
        {
            var ExibirJogo = new Acoes();
            var TodosJogos = ExibirJogo.ListarJogo();
            return View(TodosJogos);
        }
    }
}
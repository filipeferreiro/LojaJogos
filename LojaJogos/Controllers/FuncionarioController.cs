using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaJogos.Models;
using LojaJogos.Repositorio;

namespace LojaJogos.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            Funcionario funcionario = new Funcionario();
            return View(funcionario);
        }
        Acoes acoes = new Acoes();

        [HttpPost]
        public ActionResult CadFuncionario(Funcionario funcionario)
        {
            acoes.CadastrarFuncionario(funcionario);
            return View(funcionario);
        }
        public ActionResult ListarFuncionario()
        {
            var ExibirFunc = new Acoes();
            var TodosFunc = ExibirFunc.ListarFuncionario();
            return View(TodosFunc);
        }
    }
}
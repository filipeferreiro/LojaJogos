using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaJogos.Models;
using LojaJogos.Repositorio;

namespace LojaJogos.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            Cliente cliente = new Cliente();
            return View(cliente);
        }
        Acoes acoes = new Acoes();

        [HttpPost]
        public ActionResult CadCliente(Cliente cliente)
        {
            acoes.CadastrarCliente(cliente);
            return View(cliente);
        }
        public ActionResult ListarCliente()
        {
            var ExibirCliente = new Acoes();
            var TodosCliente = ExibirCliente.ListarCliente();
            return View(TodosCliente);
        }
    }
}
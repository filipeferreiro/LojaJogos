﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaJogos.Models;

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
        [HttpPost]
        public ActionResult Index(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                return View("Listar", funcionario);
            }
             return View(funcionario);
        }
        public ActionResult Listar(Funcionario funcionario)
        {
            return View(funcionario);
        }
    }
}
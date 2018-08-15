using Mvc_PagedList_FNH_3L.Modelo;
using Mvc_PagedList_FNH_3L.Models;
using Mvc_PagedList_FNH_3L.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_PagedList_FNH_3L.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index(PessoaModel pessoa)
        {
            PessoaServico pessoaServico = new PessoaServico();
            var pessoas = pessoaServico.Pessoas();
            return View();
        }
    }
}
using Mvc_PagedList_FNH_3L.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_PagedList_FNH_3L.Models
{
    public class Pessoa : IPessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
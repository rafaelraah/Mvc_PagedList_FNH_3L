using Mvc_PagedList_FNH_3L.Modelo;
using Mvc_PagedList_FNH_3L.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_PagedList_FNH_3L.Servico
{
    public class PessoaServico
    {
        PessoaRepositorio pessoaRepo;

        public PessoaServico()
        {
            pessoaRepo = new PessoaRepositorio();
        }

        public IEnumerable<Pessoa> Pessoas()
        {
            return pessoaRepo.Pessoas();
        }

    }
}

using Mvc_PagedList_FNH_3L.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_PagedList_FNH_3L.Repositorio
{
    public class PessoaRepositorio : RepositorioBase
    {

        public IEnumerable<IPessoa> Pessoas()
        {
            IEnumerable<IPessoa> listaPessoas = AbrirSessao().QueryOver<IPessoa>().List().AsEnumerable();
            FecharSessao();
            return listaPessoas;
        }
        

    }
}

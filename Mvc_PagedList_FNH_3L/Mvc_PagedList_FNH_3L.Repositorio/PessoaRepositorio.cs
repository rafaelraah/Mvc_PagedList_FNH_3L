using Mvc_PagedList_FNH_3L.Modelo;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_PagedList_FNH_3L.Repositorio
{
    public class PessoaRepositorio : RepositorioBase
    {

        public IEnumerable<Pessoa> Pessoas()
        {
            List<Pessoa> teste;
            using (ISession session = NHibernate.NHibernateHelper.OpenSession())
            {
                teste = session.QueryOver<Pessoa>().List().ToList();
            }

            IEnumerable<Pessoa> listaPessoas = AbrirSessao().QueryOver<Pessoa>().List().AsEnumerable();
            FecharSessao();
            return listaPessoas;
        }
        

    }
}

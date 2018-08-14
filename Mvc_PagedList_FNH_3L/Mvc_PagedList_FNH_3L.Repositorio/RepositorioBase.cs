using Mvc_PagedList_FNH_3L.Repositorio.NHibernate;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_PagedList_FNH_3L.Repositorio
{
    public class RepositorioBase
    {
        private ISession sessao = null;

        public ISession AbrirSessao()
        {
            return sessao = NHibernateHelper.OpenSession();
        }

        public void FecharSessao()
        {
            sessao.Close();
            sessao.Dispose();
        }
    }
}

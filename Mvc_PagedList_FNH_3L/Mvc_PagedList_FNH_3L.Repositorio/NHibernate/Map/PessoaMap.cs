using FluentNHibernate.Mapping;
using Mvc_PagedList_FNH_3L.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_PagedList_FNH_3L.Repositorio.NHibernate.Map
{
    public class PessoaMap : ClassMap<IPessoa>
    {
        public PessoaMap()
        {
            Table("Pessoa");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome);
            Map(x => x.Idade);
        }
    }
}

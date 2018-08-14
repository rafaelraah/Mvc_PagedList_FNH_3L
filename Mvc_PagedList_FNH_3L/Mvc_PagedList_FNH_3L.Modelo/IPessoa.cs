using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_PagedList_FNH_3L.Modelo
{
    public interface IPessoa
    {
        int Id { get; set; }
        string Nome { get; set; }
        int Idade { get; set; }
    }
}

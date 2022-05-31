using AluraApiSolid.Models;
using AluraApiSolid.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Dados
{
    public interface IQuery<T>
    {
        IEnumerable<T> Resgatar(Parameters parameters = null);
        T ResgatarPorId(int id);

    }
}

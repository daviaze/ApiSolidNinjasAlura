using AluraApiSolid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Dados
{
    public interface IQuery<T>
    {
        IEnumerable<T> Resgatar();
        T ResgatarPorId(int id);

    }
}

using AluraApiSolid.Dados;
using AluraApiSolid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Daos.Interfaces
{
    public interface IVilaDAO : IQuery<Vila>, ICommand<Vila>
    {
    }
}

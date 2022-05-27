using AluraApiSolid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Services
{
    public interface INinjaService
    {
        IEnumerable<Ninja> GetNinjas();
        Ninja GetNinjaById(int id);
        void PostNinja(Ninja ninja);
        bool PutNinja(Ninja ninja, int id);
        bool DeleteNinja(int id);
    }
}

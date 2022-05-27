using AluraApiSolid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Services
{
    public interface IVilaService
    {
        IEnumerable<Vila> GetVilas();
        Vila GetVilaById(int id);
        void PostVila(Vila vila);
        bool PutVila(Vila vila, int id);
        bool DeleteVila(int id);
    }
}

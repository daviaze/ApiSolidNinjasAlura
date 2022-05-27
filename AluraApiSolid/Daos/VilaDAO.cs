using AluraApiSolid.Context;
using AluraApiSolid.Daos.Interfaces;
using AluraApiSolid.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Daos
{
    public class VilaDAO : IVilaDAO
    {
        private readonly VilaContext _vilacontext;

        public VilaDAO(VilaContext vilacontext)
        {
            _vilacontext = vilacontext;
        }

        public void Alterar(Vila obj, int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Ninja ninja)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Vila obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vila> Resgatar()
        {
            return _vilacontext.Vilas.Include(v => v.Ninjas).AsNoTracking().AsSplitQuery().ToList();
        }

        public Vila ResgatarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

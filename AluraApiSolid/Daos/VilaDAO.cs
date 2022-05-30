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
        private readonly NinjaContext _vilacontext;

        public VilaDAO(NinjaContext vilacontext)
        {
            _vilacontext = vilacontext;
        }

        public void Alterar(Vila obj, int id)
        {
            _vilacontext.Update(obj);
            _vilacontext.SaveChanges();
        }

        public void Excluir(Vila ninja)
        {
            _vilacontext.Remove(ninja);
            _vilacontext.SaveChanges();
        }

        public void Incluir(Vila obj)
        {
            _vilacontext.Vilas.Add(obj);
            _vilacontext.SaveChanges();
        }

        public IEnumerable<Vila> Resgatar()
        {
            return _vilacontext.Vilas.Include(v => v.Ninjas).AsNoTracking().AsSplitQuery().ToList();
        }

        public Vila ResgatarPorId(int id)
        {
            return _vilacontext.Vilas.FirstOrDefault(v => v.Id == id);
        }
    }
}

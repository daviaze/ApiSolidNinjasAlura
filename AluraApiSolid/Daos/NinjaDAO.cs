using AluraApiSolid.Context;
using AluraApiSolid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AluraApiSolid.Daos.Interfaces
{
    public class NinjaDAO : INinjaDAO
    {
        private readonly NinjaContext _ninjaContext;

        public NinjaDAO(NinjaContext ninjaContext)
        {
            _ninjaContext = ninjaContext;
        }

        public void Alterar(Ninja obj, int id)
        {
            _ninjaContext.Update(obj);
            _ninjaContext.SaveChanges();
        }

        public void Excluir(Ninja ninja)
        {
            _ninjaContext.Ninjas.Remove(ninja);
            _ninjaContext.SaveChanges();
        }

        public void Incluir(Ninja obj)
        {
            _ninjaContext.Ninjas.Add(obj);
            _ninjaContext.SaveChanges();
        }

        public IEnumerable<Ninja> Resgatar()
        {
            return _ninjaContext.Ninjas
                .Include(i => i.Cla)
                .Include(i => i.Vila)
                .AsSplitQuery()
                .AsNoTracking()
                .ToList();
        }

        public Ninja ResgatarPorId(int id)
        {
            return _ninjaContext.Ninjas
                .Include(n => n.Cla)
                .Include(n => n.Vila)
                .AsSplitQuery()
                .AsNoTracking()
                .FirstOrDefault(n => n.Id == id);
        }
    }
}

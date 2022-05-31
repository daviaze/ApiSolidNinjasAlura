using AluraApiSolid.Daos.Interfaces;
using AluraApiSolid.Models;
using AluraApiSolid.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Services
{
    public class NinjaService : INinjaService
    {
        INinjaDAO _ninjaDao;

        public NinjaService(INinjaDAO ninjaDao)
        {
            _ninjaDao = ninjaDao;
        }

        public IEnumerable<Ninja> GetNinjas(Parameters parameters)
        {
            return _ninjaDao.Resgatar(parameters);
        }

        public Ninja GetNinjaById(int id)
        {
            return _ninjaDao.ResgatarPorId(id);
        }
        public bool DeleteNinja(int id)
        {
            Ninja exists = _ninjaDao.ResgatarPorId(id);
            if (exists != null)
            {
                _ninjaDao.Excluir(exists);
                return true;
            }
            return false;
        }

        public void PostNinja(Ninja ninja)
        {
            _ninjaDao.Incluir(ninja);
        }

        public bool PutNinja(Ninja ninja, int id)
        {
            Ninja exists = _ninjaDao.ResgatarPorId(id);
            if (exists != null)
            {
                exists.Nome = ninja.Nome;
                exists.Idade = ninja.Idade;
                exists.VilaId = ninja.VilaId;
                exists.ClaId = ninja.ClaId;
                exists.Cla = ninja.Cla;
                exists.Vila = ninja.Vila;

                _ninjaDao.Alterar(exists, id);
                return true;
            }
            return false;
        }
    }
}

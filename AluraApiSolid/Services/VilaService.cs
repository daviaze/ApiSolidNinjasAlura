using AluraApiSolid.Daos.Interfaces;
using AluraApiSolid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Services
{
    public class VilaService : IVilaService
    {
        IVilaDAO _vilaDAO;

        public VilaService(IVilaDAO vilaDAO)
        {
            _vilaDAO = vilaDAO;
        }

        public bool DeleteVila(int id)
        {
            Vila exists = _vilaDAO.ResgatarPorId(id);
            if (exists != null)
            {
                _vilaDAO.Excluir(exists);
                return true;
            }
            return false;
        }

        public Vila GetVilaById(int id)
        {
            return _vilaDAO.ResgatarPorId(id);
        }

        public IEnumerable<Vila> GetVilas()
        {
            return _vilaDAO.Resgatar();
        }

        public void PostVila(Vila vila)
        {
            _vilaDAO.Incluir(vila);
        }

        public bool PutVila(Vila vila, int id)
        {
            Vila exists = _vilaDAO.ResgatarPorId(id);
            if (exists != null)
            {
                exists.Nome = vila.Nome;
                _vilaDAO.Alterar(exists, id);
                return true;
            }
            return false;
        }
    }
}

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
            throw new NotImplementedException();
        }

        public Vila GetVilaById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vila> GetVilas()
        {
            return _vilaDAO.Resgatar();
        }

        public void PostVila(Vila vila)
        {
            throw new NotImplementedException();
        }

        public bool PutVila(Vila vila, int id)
        {
            throw new NotImplementedException();
        }
    }
}

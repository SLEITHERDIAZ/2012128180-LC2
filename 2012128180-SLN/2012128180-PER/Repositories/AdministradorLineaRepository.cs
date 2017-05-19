using _2012128180_EN.Entities;
using _2012128180_EN.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.Repositories
{
    public class AdministradorLineaRepository : Repository<AdministradorLinea>, IAdministradorLineaRepository
    {
        private readonly jeffdiazDbContext _Context;

        public AdministradorLineaRepository(jeffdiazDbContext context)
        {
            _Context = context;
        }
        private AdministradorLineaRepository()
        {

        }
    }
}

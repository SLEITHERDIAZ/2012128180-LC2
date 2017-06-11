using _2012128180_EN.Entities;
using _2012128180_EN.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.Repositories
{
    public class AdministradorEquipoRepository : Repository<AdministradorEquipo>, IAdministradorEquipoRepository
    {

        public AdministradorEquipoRepository(JeffdiazDbContext _context) : base(_context)
        {

        }

    }
}

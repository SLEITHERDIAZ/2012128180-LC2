using _2012128180_EN.Entities;
using _2012128180_EN.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.Repositories
{
    public class TipoTrabajadorRepository : Repository<TipoTrabajador>, ITipoTrabajadorRepository
    {
        private readonly jeffdiazDbContext _Context;

        public TipoTrabajadorRepository(jeffdiazDbContext context)
        {
            _Context = context;
        }
        private TipoTrabajadorRepository()
        {

        }
    }
}

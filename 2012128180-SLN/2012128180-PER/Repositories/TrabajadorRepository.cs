using _2012128180_EN.Entities;
using _2012128180_EN.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.Repositories
{
    public class TrabajadorRepository : Repository<Trabajador>, ITrabajadorRepository
    {
        private readonly jeffdiazDbContext _Context;

        public TrabajadorRepository(jeffdiazDbContext context)
        {
            _Context = context;
        }
        private TrabajadorRepository()
        {

        }
    }
}

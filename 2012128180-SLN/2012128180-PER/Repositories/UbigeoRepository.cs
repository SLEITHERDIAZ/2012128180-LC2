using _2012128180_ENT;
using _2012128180_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Repositories
{
    public class UbigeoRepository : Repository<Ubigeo>, IUbigeoRepository
    {
        private _2012128180DbContext _Context;

        public UbigeoRepository(_2012128180DbContext context)
        {
            _Context = context;
        }
    }
}

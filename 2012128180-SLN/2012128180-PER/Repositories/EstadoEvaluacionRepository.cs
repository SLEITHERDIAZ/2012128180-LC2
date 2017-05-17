using _2012128180_ENT;
using _2012128180_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Repositories
{
    public class EstadoEvaluacionRepository : Repository<_2012128180_ENT.EstadoEvaluacionRepository>, IEstadoEvaluacionRepository
    {
        private _2012128180DbContext _Context;

        public EstadoEvaluacionRepository(_2012128180DbContext context)
        {
            _Context = context;
        }
    }
}

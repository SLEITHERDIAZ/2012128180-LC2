using _2012128180_EN.Entities;
using _2012128180_EN.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012128180_PER.Persistence.Repositories
{
    public class EvaluacionRepository : Repository<Evaluacion>, IEvaluacionRepository
    {
        private readonly jeffdiazDbContext _Context;

        public EvaluacionRepository(jeffdiazDbContext context)
        {
            _Context = context;
        }
        private EvaluacionRepository()
        {

        }
    }
}

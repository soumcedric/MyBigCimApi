using Abstraction.Repositories;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class DemandeRepository : EntityRepository<Demande>, IDemandeRepository
    {
        public DemandeRepository(ApplicationContext context) : base(context)
        {
            
        }
    }
}

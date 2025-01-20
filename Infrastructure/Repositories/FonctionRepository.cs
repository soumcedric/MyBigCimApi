using Abstraction.Repositories;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public sealed class FonctionRepository : EntityRepository<Fonction>, IFonctionRepository
    {
        public FonctionRepository(ApplicationContext context) : base(context)
        {
        }
    }
}

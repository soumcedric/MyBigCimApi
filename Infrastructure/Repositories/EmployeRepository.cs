using Abstraction.Repositories;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public sealed class EmployeRepository : EntityRepository<Employe>, IEmployeRepository
    {
        public EmployeRepository(ApplicationContext context) : base(context)
        {
        }
    }
}

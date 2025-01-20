using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Repositories;
using Core.Entity;
using Infrastructure;

namespace Infrastructure.Repositories
{
    public class ServiceRepository:EntityRepository<Service>, IServiceRepository
    {
        public ServiceRepository(ApplicationContext context):base(context)
        {
            
        }
    }
}

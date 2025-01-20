using Abstraction.Repositories;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class AggregateRepository<TAggregate>:IAggregateRepository<TAggregate> where TAggregate : EntityBase
    {
    }
}

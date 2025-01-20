using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public interface IServiceHandler<Command> where Command : class
    {
        void Add(Command entity);
        void Update(Command entity);
        void Delete(Command entity);
    }
}

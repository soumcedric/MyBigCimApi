using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public interface IRequestHandler<Tcommand, TResponse> where Tcommand : class
                                                          where TResponse: class
    {
        TResponse Handle(Tcommand command);
        
    }
}

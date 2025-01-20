using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Command;
using Application.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler
{
    public class GetAllServiceQueryHandler : IRequestHandler<GetAllService, ObjectResponse<string>>
    {
        IServiceRepository _service;

        public GetAllServiceQueryHandler(IServiceRepository service)
        {
            _service = service;
        }

        public ObjectResponse<string> Handle(GetAllService command)
        {
            throw new NotImplementedException();
        }
    }
}

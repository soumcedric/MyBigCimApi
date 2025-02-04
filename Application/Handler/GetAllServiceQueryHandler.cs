using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Command;
using Application.Dtos;
using Application.Mapper;
using Application.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler
{
    public class GetAllServiceQueryHandler : IRequestHandler<GetAllService, ObjectResponse<ServiceDto>>
    {
        IServiceRepository _service;

        public GetAllServiceQueryHandler(IServiceRepository service)
        {
            _service = service;
        }

        public ObjectResponse<ServiceDto> Handle(GetAllService command)
        {
            var retour = _service.FindAll();
            if (retour == null)
                return new ObjectResponse<ServiceDto>
                {
                    Message = "No data found",
                };
            else
            {
                List<ServiceDto> liste = new();
                retour.ToList().ForEach(x => liste.Add(x.ToDto()));
                return new ObjectResponse<ServiceDto>
                {
                    Response = liste
                };
            }
        }
    }
}

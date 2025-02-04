using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Dtos;
using Application.Mapper;
using Application.Query;
using Application.Query.Employe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler.Employe
{
    public class GetAllEmployeQueryHandler : IRequestHandler<GetAllEmploye, ObjectResponse<EmployeDto>>
    {
        private readonly IEmployeRepository _employeRepository;
        public GetAllEmployeQueryHandler(IEmployeRepository employe)
        {
            _employeRepository = employe;
        }
        public ObjectResponse<EmployeDto> Handle(GetAllEmploye command)
        {
            var retour = _employeRepository.FindAll();
            var liste = new List<EmployeDto>();
            if(retour == null)
                return new ObjectResponse<EmployeDto>
                {
                    Message = "No data found",
                };
            else
            {
                retour.ToList().ForEach(x => liste.Add(x.ToDto()));
                return new ObjectResponse<EmployeDto>
                {
                    Response = liste
                };
            }
        }
    }
}

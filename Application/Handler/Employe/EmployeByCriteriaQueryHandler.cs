using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Command.Employe;
using Application.Dtos;
using Application.Mapper;
using Application.Query.Employe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler.Employe
{
    public class EmployeByCriteriaQueryHandler : IRequestHandler<EmployeByCriteria, ObjectResponse<EmployeDto>>
    {
        IEmployeRepository _employeRepository { get; set; }
        public EmployeByCriteriaQueryHandler(IEmployeRepository employeRepository)
        {
            _employeRepository = employeRepository;
        }
        public ObjectResponse<EmployeDto> Handle(EmployeByCriteria command)
        {
            if (command == null)
            {
                return new ObjectResponse<EmployeDto>
                {
                    Message = "Parameter not valid",
                };
            }
            else
            {
                var retour = _employeRepository.FindAll();
                var liste = new List<EmployeDto>();
                if (retour == null)
                    return new ObjectResponse<EmployeDto>
                    {
                        Message = "No data found",
                    };
                else
                {
                    retour.ToList().ForEach(x => liste.Add(x.ToDto()));
                    var result = liste.Where(x => command.NomPrenoms.Contains(x.Nom)
                                                  || command.NomPrenoms.Contains(x.Prenom)
                                                  || x.Matricule == command.Matricule);
                    return new ObjectResponse<EmployeDto>
                    {
                        Response = result
                    };
                }
            }
        }
    }
}

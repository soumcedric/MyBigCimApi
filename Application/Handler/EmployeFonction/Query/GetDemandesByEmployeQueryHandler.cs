using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Dtos;
using Application.Mapper;
using Application.Query.Demande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler.EmployeFonction.Query
{
    public class GetDemandesByEmployeQueryHandler : IRequestHandler<GetDemandesByEmployeQuery, ObjectResponse<DemandeDto>>
    {
        IDemandeRepository _demandeRepository;
        IEmployeRepository _employeRepository;
       public GetDemandesByEmployeQueryHandler(IDemandeRepository demandeRepository, IEmployeRepository employeRepository)
        {
            _demandeRepository = demandeRepository;
            _employeRepository = employeRepository;
        }

        public ObjectResponse<DemandeDto> Handle(GetDemandesByEmployeQuery command)
        {
            var includes = new string[] { "Employe" };
            var demandes = _demandeRepository.FindAllWithInclude(includes);
            var demandesEmploye = demandes.Where(x => x.Employe.Id == command.EmployeId && x.TypeDemande == command.TypeDemande).ToList();
            if (demandesEmploye != null)
            {
                List<DemandeDto> demandesDto = new();
                foreach (var item in demandesEmploye)
                {
                    demandesDto.Add(item.ToDto());
                }
                return new ObjectResponse<DemandeDto> { Response = demandesDto };
            }

            return new ObjectResponse<DemandeDto> { Response = null, Message = "no records" };
        }
    }
}

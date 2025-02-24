using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Dtos;
using Application.Mapper;
using Application.Query.Demande;
using Application.Query.EmployeFonction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler.Demande.Query
{
    public class GetAllDemandeQueryHandler : IRequestHandler<GetAllDemandeQuery, ObjectResponse<DemandeDto>>
    {
        IDemandeRepository _demandeRepository;
        public GetAllDemandeQueryHandler(IDemandeRepository demandeRep)
        {
            _demandeRepository = demandeRep;
        }
        public ObjectResponse<DemandeDto> Handle(GetAllDemandeQuery command)
        {
            var includes = new string[] { "Employe" };
            var liste = _demandeRepository.FindAllWithInclude(includes);
            if (liste != null)
            {
                List<DemandeDto> demandes = new();
                foreach (var item in liste)
                {
                    demandes.Add(item.ToDto());
                }
                return new ObjectResponse<DemandeDto> { Response = demandes };
            }
            return new ObjectResponse<DemandeDto> { Response = null };
        }
    }
}

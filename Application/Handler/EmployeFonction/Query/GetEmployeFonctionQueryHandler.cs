using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Dtos;
using Application.Mapper;
using Application.Query.EmployeFonction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler.EmployeFonction.Query
{
    public class GetEmployeFonctionQueryHandler:IRequestHandler<GetEmployeFonctionQuery, ObjectResponse<EmployeFonctionDto>>
    {
        IEmployeFonctionRepository _repository;
        public GetEmployeFonctionQueryHandler(IEmployeFonctionRepository repository)
        {
            _repository = repository;
        }
        public ObjectResponse<EmployeFonctionDto> Handle(GetEmployeFonctionQuery command)
        {
            // Include related entities 'Employe' and 'Departement'
            var retour = _repository.FindAllWithInclude();
            if (retour == null || !retour.Any())
            {
                return new ObjectResponse<EmployeFonctionDto>() { Message = "No data found" };
            }

            var liste = new List<EmployeFonctionDto>();
            retour.ToList().ForEach(x => liste.Add(x.ToDto()));
            return new ObjectResponse<EmployeFonctionDto> { Response = liste };
        }
    }
  
}

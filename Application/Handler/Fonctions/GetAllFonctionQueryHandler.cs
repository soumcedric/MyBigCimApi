using Abstraction.Interface;
using Application.Query;
using Application.Query.Fonctions;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.Repositories;
using Application.Command;
using Application.Mapper;
using Application.Dtos;


namespace Application.Handler.Fonctions
{
    public class GetAllFonctionQueryHandler: IRequestHandler<GetAllFonction, ObjectResponse<FonctionDto>>
    {
        IFonctionRepository _repository;

        public GetAllFonctionQueryHandler(IFonctionRepository repository)
        {
            _repository = repository;
        }

        public ObjectResponse<FonctionDto> Handle(GetAllFonction command)
        {
            var retour = _repository.FindAll();
            if (retour == null)
                return new ObjectResponse<FonctionDto> {
                    Message = "No data found",
                };
            else
            {
                return new ObjectResponse<FonctionDto>
                {
                    Response =  FonctionMapper.ToDtos(retour.ToList()),
                };
            }
        }
        }
    }
   


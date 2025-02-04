using Abstraction.Interface;
using Application.Command.Fonction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Command;
using Application.Mapper;
using Application.Command.Employe;

namespace Application.Handler.Employe
{
    public class AddEmployeCommandHandler : IRequestHandler<AddEmployeCommand, ObjectResponse<string>>
    {
        IEmployeRepository _repository;
        public AddEmployeCommandHandler(IEmployeRepository repository)
        {
            _repository = repository;
        }
        public ObjectResponse<string> Handle(AddEmployeCommand command)
        {
            if (command is null)
            {
                return new ObjectResponse<string>{ Message = "Le paramètre est nulle" };
            }

            var query = command.ToRequest();
            _repository.Add(query);
            return new ObjectResponse<string> { Message = "Employé ajouté avec succès" };
        }
    }
}

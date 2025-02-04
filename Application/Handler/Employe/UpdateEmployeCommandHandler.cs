using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Command.Employe;
using Application.Mapper;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler.Employe
{
    public class UpdateEmployeCommandHandler : IRequestHandler<UpdateEmployeCommand, ObjectResponse<string>>
    {
        IEmployeRepository _repository;
        public UpdateEmployeCommandHandler(IEmployeRepository repository)
        {
            _repository = repository;
        }
        public ObjectResponse<string> Handle(UpdateEmployeCommand command)
        {
           
            if (command is null)
            {
                return new ObjectResponse<string> { Message = "Employé non trouvé" };
            }
            else
            {

                var employeToUpdate = command.ToRequest();
                _repository.Update(employeToUpdate);
                return new ObjectResponse<string> { Message = "Employé modifié avec succès" };
            }
        }
    }
}

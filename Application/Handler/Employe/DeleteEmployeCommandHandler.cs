using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Command.Common;
using Application.Command.Employe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler.Employe
{
    public class DeleteEmployeCommandHandler : IRequestHandler<DeleteCommand, ObjectResponse<string>>
    {
        IEmployeRepository _repository;
        public DeleteEmployeCommandHandler(IEmployeRepository repository)
        {
            _repository = repository;
        }
        public ObjectResponse<string> Handle(DeleteCommand command)
        {
            var employeToDelete = _repository.FindById(command.Id);
            if (command.Id == Guid.Empty)
            {
                return new ObjectResponse<string> { Message = "Employé non trouvé" };
            }
            else
            {
                employeToDelete.Delete();
                _repository.Update(employeToDelete);
                return new ObjectResponse<string> { Message = null};
            }
        }
    }
}

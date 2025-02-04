using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Command.Common;
using Application.Command.Fonction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler.Fonctions
{
    public class DeleteFonctionCommandHandler : IRequestHandler<DeleteCommand, ObjectResponse<string>>
    {
        IFonctionRepository _repo;
        public DeleteFonctionCommandHandler(IFonctionRepository repo)
        {
            _repo = repo;
        }
        public ObjectResponse<string> Handle(DeleteCommand command)
        {
            if(command.Id == Guid.Empty)
                return new ObjectResponse<string> { Message = "Id is required" };

            var fonctionToDelete = _repo.FindById(command.Id);
            if(fonctionToDelete == null)
                return new ObjectResponse<string> { Message = "Fonction not found" };

            fonctionToDelete.Delete();
            _repo.Update(fonctionToDelete);
            return new ObjectResponse<string> { Message = "Fonction Deleted" };

        }
    }
}

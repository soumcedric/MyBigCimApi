using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Command;
using Application.Command.Fonction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Mapper;

namespace Application.Handler.Fonctions
{
    public class AddFonctionCommandHandler : IRequestHandler<AddFonctionCommand, ObjectResponse<string>>
    {
        IFonctionRepository _repository { get; set; }
        public AddFonctionCommandHandler(IFonctionRepository repository)
        {
            _repository = repository;
        }
        public ObjectResponse<string> Handle(AddFonctionCommand command)
        {
            if (command is null)
                throw new ArgumentNullException("null parameter");

            var query = command.ToRequest();
            _repository.Add(query);
            return null;
        }
    }
}

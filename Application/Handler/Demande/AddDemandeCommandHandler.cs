using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Command.Demande;
using Application.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler.Demande
{
    public class AddDemandeCommandHandler : ICommandHandler<AddDemandeCommand, ObjectResponse<string>>
    {
        private readonly IDemandeRepository _demandeRepository;
        private readonly IEmployeRepository _employeRepository;

      
        public AddDemandeCommandHandler(IDemandeRepository demandeRepository, IEmployeRepository employeRepository)
        {
            _demandeRepository = demandeRepository;
            _employeRepository = employeRepository;
        }

        //public AddDemandeCommandHandler()
        //{

        //}

        public async Task<ObjectResponse<string>> Handle(AddDemandeCommand command, CancellationToken cancellation = default)
        {

            try
            {
                //get employe
                var employe = _employeRepository.FindById(command.EmployeId);

                var value = command.ToEntity(employe);
              
                _demandeRepository.Add(value);
                return new ObjectResponse<string>
                {
                    Message = null
                };
            }
            catch (Exception ex)
            {
                return new ObjectResponse<string>
                {
                    Message = ex.Message
                };
            }

        }
    }
}

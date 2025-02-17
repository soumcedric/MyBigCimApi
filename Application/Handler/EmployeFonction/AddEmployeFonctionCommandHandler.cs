using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Command.EmployeFonction;
using Application.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler.EmployeFonction
{
    public class AddEmployeFonctionCommandHandler : ICommandHandler<AddEmployeFonctionCommand, ObjectResponse<string>>
    {
        IEmployeFonctionRepository _repository { get; set; }
        IFonctionRepository _repFonction { get; set;   }
        IEmployeRepository _repEmploye { get; set; }
        IServiceRepository _repService { get; set; }


        public AddEmployeFonctionCommandHandler(IEmployeFonctionRepository repository, IFonctionRepository repFonction, IEmployeRepository repEmploye, IServiceRepository repService)
        {
            _repository = repository;
            _repFonction = repFonction;
            _repEmploye = repEmploye;
            _repService = repService;
        }

        public AddEmployeFonctionCommandHandler()
        {
            
        }

        public async Task<ObjectResponse<string>> Handle(AddEmployeFonctionCommand command, CancellationToken cancellation = default)
        {
            try
            {
                if (command is null)
                {
                    return new ObjectResponse<string> { Message = "Le paramètre est nulle" };
                }

                //get employe
                var employe = _repEmploye.FindAll().FirstOrDefault(x => x.Matricule == command.Matricule);
                //get fonction
                var fonction = _repFonction.FindById(command.FonctionId);
                // get service
                var service = _repService.FindById(command.ServiceId);

                var value = EmployeFonctionMapper.ToRequest(employe, fonction, service);

                _repository.Add(value);

                return new ObjectResponse<string> { Message = null };

            }
            catch (Exception ex)
            {
                return new ObjectResponse<string> { Message = $"{ex.Message}" };
            }

        }
    }
}

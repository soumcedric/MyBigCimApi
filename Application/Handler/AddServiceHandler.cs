using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Command;
using Application.Mapper;

namespace Application.Handler
{
    public class AddServiceHandler : IRequestHandler<ServiceCmd, ObjectResponse<string>>
    {
        IServiceRepository _repository {  get; set; }
        public AddServiceHandler()
        {
            
        }
        public AddServiceHandler(IServiceRepository repository)
        {
            _repository = repository;
        }
        public ObjectResponse<string> Handle(ServiceCmd command)
        {
            if (command is null)
                throw new ArgumentNullException("null parameter");

            var query = command.ToRequest();
            _repository.Add(query);
            return null;
        }

      
    }
}

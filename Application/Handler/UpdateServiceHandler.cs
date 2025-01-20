using Abstraction.Interface;
using Abstraction.Repositories;
using Application.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handler
{
    public class UpdateServiceHandler : IRequestHandler<ServiceCmd, ObjectResponse<string>>
    {
        IServiceRepository _service { get; set; }
        public UpdateServiceHandler(IServiceRepository service)
        {
            _service = service;
        }
        public ObjectResponse<string> Handle(ServiceCmd command)
        {
            if (command == null)
                throw new ArgumentNullException("null parameter");

            //get record
            var value = _service.FindById(command.Id);
            if (value == null)
                throw new ArgumentNullException("Service Not Found");

            value.Libelle = command.Libelle;
            value.Code = command.Code;

            _service.Update(value);
            return null;
            
        }
    }
}

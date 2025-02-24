using Abstraction.Interface;
using Application.Command.EmployeFonction;
using Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Command.Demande;
using Application.Query.Demande;
using Application.Dtos;

namespace BigCimApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemandeController : ControllerBase
    {
        readonly IRequestHandler<GetAllDemandeQuery, ObjectResponse<DemandeDto>> _handler;
        public DemandeController(IRequestHandler<GetAllDemandeQuery, ObjectResponse<DemandeDto>> handler)
        {
            _handler = handler;
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Post(AddDemandeCommand command, ICommandHandler<AddDemandeCommand, ObjectResponse<string>> handler)
        {
            var result = handler.Handle(command);
            return NoContent();
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            GetAllDemandeQuery command = new();
            var result = _handler.Handle(command);
            if (string.IsNullOrEmpty(result.Message))
                return Ok(result.Response);
            else
                return BadRequest(result.Message);
          
        }

        [HttpGet]
        [Route("GetDemandesByEmploye")]
        public IActionResult Get([FromQuery] GetDemandesByEmployeQuery query, IRequestHandler<GetDemandesByEmployeQuery, ObjectResponse<DemandeDto>> queryHandler)
        {
            if(query == null)
                return BadRequest("Query is null");
            if (query.EmployeId == Guid.Empty  || query.TypeDemande == null)
                return BadRequest("EmployeId is null");

            var result = queryHandler.Handle(query);
            if (string.IsNullOrEmpty(result.Message))
                return Ok(result.Response);
            else
                return BadRequest(result.Message);

        }
    }
}

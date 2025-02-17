using Abstraction.Repositories;
using Application.Command;
using Application.Command.Employe;
using Application.Handler.Employe;
using Application.Query.Employe;
using Microsoft.AspNetCore.Mvc;
using Application.Command.Common;

namespace BigCimApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : Controller
    {

        IEmployeRepository _repository { get; set; }
        public EmployeController(IEmployeRepository repository)
        {
            _repository = repository;
        }

      

        [HttpPost]
        [Route("Add")]
        public IActionResult Post()
        {
            //AddEmployeCommandHandler handler = new(_repository);
            //if(cmd is null)
            //    return BadRequest("Le paramètre est nulle");

            //var retour = handler.Handle(cmd);
            //if (string.IsNullOrEmpty(retour.Message))
            //    return Ok();
            //else
            //    return BadRequest(retour.Message);
            return NoContent();
          
        }

        [HttpPut]
        public IActionResult Put(UpdateEmployeCommand cmd)
        {
            UpdateEmployeCommandHandler handler = new(_repository);
            if (cmd is null)
                return BadRequest("Le paramètre est nulle");

            var retour = handler.Handle(cmd);
            if (string.IsNullOrEmpty(retour.Message))
                return Ok();
            else
                return BadRequest(retour.Message);
        }
        [HttpDelete]
        public IActionResult Delete(DeleteCommand cmd)
        {
            DeleteEmployeCommandHandler handler = new(_repository);
            if (cmd is null)
                return BadRequest("Le paramètre est nulle");

            var retour = handler.Handle(cmd);
            if (string.IsNullOrEmpty(retour.Message))
                return Ok();
            else
                return BadRequest(retour.Message);
        }

        [HttpGet]
        public IActionResult Get()
        {
            GetAllEmployeQueryHandler handler = new(_repository);
            var retour = handler.Handle(new GetAllEmploye()); 
            if(retour.Response is not null)
                return Ok(retour.Response);
            else
                return BadRequest(retour.Message);
        }

        [HttpPost]
        [Route("EmployeByCriteria")]
        public IActionResult EmployeByCriteria()
        {
            

            return NoContent();

        }

        [HttpPost]
        [Route("GetByCriteria")]
        public IActionResult GetByCriteria(EmployeByCriteria value)
        {
            EmployeByCriteriaQueryHandler handler = new(_repository);
            var retour = handler.Handle(value);
            if (retour.Response is not null)
                return Ok(retour.Response);
            else
                return BadRequest(retour.Message);
        }




    }
}

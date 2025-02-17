using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using Application.Command;
using Application.Command.EmployeFonction;
using Abstraction.Interface;
using Application;
using Application.Query.EmployeFonction;
using Application.Dtos;

namespace BigCimApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeFonctionController : Controller
    {
        
        public EmployeFonctionController()
        {
            
        }


        [HttpPost]
        public IActionResult Add(AddEmployeFonctionCommand command, ICommandHandler<AddEmployeFonctionCommand, ObjectResponse<string> > handler)
        {
            var result = handler.Handle(command);
            return NoContent();
        }

        //[HttpPut]
        //public IActionResult Update(EmployeFonctionCommand command)
        //{
        //    return NoContent();
        //}

        //[HttpGet]
        //public IActionResult GetAllEmployeFonction()
        //{
        //    return NoContent();
        //}

        [HttpGet]
        public IActionResult GetAllEmployeFonction(IRequestHandler<GetEmployeFonctionQuery, ObjectResponse<EmployeFonctionDto>> handler)
        {
            var command = new GetEmployeFonctionQuery();
            var result = handler.Handle(command);
            if (string.IsNullOrEmpty(result.Message))
            {
                return Ok(result.Response);
            }
            else
            {
                return NotFound(result.Message);
            }

            // return NoContent();

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using Application.Command;

namespace BigCimApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeFonctionController : Controller
    {

        [HttpPost]
        public IActionResult Add(EmployeFonctionCommand command)
        {
            return NoContent();
        }

        [HttpPut]
        public IActionResult Update(EmployeFonctionCommand command)
        {
            return NoContent();
        }

        [HttpGet]
        public IActionResult GetAllEmployeFonction()
        {
            return NoContent();
        }

        [HttpGet]
        public IActionResult GetAllEmployeFonction(Guid id)
        {
            return NoContent();
        }
    }
}

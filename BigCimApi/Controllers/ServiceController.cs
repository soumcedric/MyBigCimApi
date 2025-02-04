using Microsoft.AspNetCore.Mvc;
using Application.Command;
using Application.Handler;
using Abstraction.Repositories;

namespace BigCimApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : Controller
    {
        IServiceRepository _service { get; set; }
        public ServiceController(IServiceRepository service)
        {
            _service = service;
        }
        [HttpPost]
       // [Route("Add")]
        public IActionResult Post(ServiceCmd cmd)
        {
            AddServiceHandler handler = new(_service);
            handler.Handle(cmd);
            return NoContent();
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(ServiceCmd cmd)
        {
            UpdateServiceHandler handler = new(_service);
            handler.Handle(cmd);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(ServiceCmd cmd)
        {
            return Json(true);
        }

        [HttpGet]
        //[Route("Delete")]
        public IActionResult Get()
        {
            GetAllServiceQueryHandler handler = new(_service);
            var retour = handler.Handle(new());
            if (string.IsNullOrEmpty(retour.Message))
                return Ok(retour.Response);
            else
                return BadRequest(retour.Message);
            
        }

    }
}

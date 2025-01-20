using Abstraction.Repositories;
using Application.Command;
using Application.Handler;
using Application.Handler.Fonctions;
using Application.Query.Fonctions;
using Microsoft.AspNetCore.Mvc;

namespace BigCimApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FonctionController : Controller
    {
        IFonctionRepository _repository { get; set; }
        public FonctionController(IFonctionRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        public IActionResult Add(ServiceCmd cmd)
        {
            return Json(true);
        }

        [HttpPut]
        public IActionResult Update(ServiceCmd cmd)
        {
            return Json(true);
        }
        [HttpDelete]
        public IActionResult Delete(ServiceCmd cmd)
        {
            return Json(true);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var query = new GetAllFonction();
            GetAllFonctionQueryHandler handler = new(_repository);
            var retour = handler.Handle(query);
            if(string.IsNullOrEmpty(retour.Message))
               return Ok(retour.Response);
            else
                return BadRequest(retour.Message);
        }
    }
}

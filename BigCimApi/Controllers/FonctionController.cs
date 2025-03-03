﻿using Abstraction.Repositories;
using Application.Command;
using Application.Command.Fonction;
using Application.Handler;
using Application.Handler.Fonctions;
using Application.Query.Fonctions;
using Microsoft.AspNetCore.Mvc;
using Application.Handler.Fonctions;
using Application.Command.Common;

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
        public IActionResult Post(AddFonctionCommand cmd)
        {
            
            AddFonctionCommandHandler handler = new(_repository);
            var retour = handler.Handle(cmd);
            //if (string.IsNullOrEmpty(retour.Message))
            //    return Ok();
            //else
            //    return BadRequest(retour.Message);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(ServiceCmd cmd)
        {
            return Json(true);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            DeleteCommand cmd = new();
            cmd.Id = Guid.Parse(id);
            DeleteFonctionCommandHandler handler = new(_repository);
            var retour = handler.Handle(cmd);
            return Ok();
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

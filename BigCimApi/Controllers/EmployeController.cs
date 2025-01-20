using Application.Command;
using Microsoft.AspNetCore.Mvc;

namespace BigCimApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : Controller
    {
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
    }
}

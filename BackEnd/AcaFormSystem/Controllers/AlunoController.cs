using AcaFormSystemAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcaFormSystemAPI.Controllers
{  
   [ApiController]
   [Route("[controller]")]
   public class AlunoController : ControllerBase
   {

        [HttpPost(Name = "CreateAluno")]
        public ActionResult CreateAluno ( Aluno aluno)
        {
            return Ok(aluno);

        }
         

        }
}

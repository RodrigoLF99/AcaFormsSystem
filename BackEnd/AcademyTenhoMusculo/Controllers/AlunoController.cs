using Academy.Domain.Entities;
using Academy.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AcademyTenhoMusculo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController (IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpPost("CreateAluno")]
        public ActionResult CreateAluno(Aluno objetoAluno)
        {
            _alunoService.CreateAluno(objetoAluno);

            return Ok(objetoAluno);
        }
        [HttpPost("GetAllAluno")]
        public ActionResult GetAllAluno()
        {
            var result = _alunoService.GetAllAluno();

            return Ok(result);
        }

    }
}

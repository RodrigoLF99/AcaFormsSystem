using AcaFormSystemAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcaFormSystemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {

        [HttpPost(Name = "CreateAluno")]
        public ActionResult CreateAluno(Aluno aluno)
        {
            if (aluno.Idade >= 18)
            {

                string resultado = "Aluno cadastrado com sucesso";

                return Ok(resultado);

            }
            else
            {

                string resultado = "precisa de um responsalvel";

                return Ok(resultado);

            }

        }




        [HttpGet(Name = "GetAluno")]
        public ActionResult GetAluno()
        {

            var ListaAlunos = new List<Aluno>();

            var alunoObject1 = new Aluno();
            alunoObject1.Matricula = 2230;
            alunoObject1.Nome = "Thiago";
            alunoObject1.Idade = 27;
            alunoObject1.Peso = 80;
            alunoObject1.Altura = 187;
            alunoObject1.Endereco = "Rua Vargas";
            alunoObject1.Telefone = 991643104;
            alunoObject1.Email = "thiago@gmail.com";



            var alunoObject2 = new Aluno();
            alunoObject2.Matricula = 2231;
            alunoObject2.Nome = "Felipe";
            alunoObject2.Idade = 16;
            alunoObject2.Peso = 75;
            alunoObject2.Altura = 176;
            alunoObject2.Endereco = "Rua Jorge";
            alunoObject2.Telefone = 967485321;
            alunoObject2.Email = "felipe@gmail.com";

            ListaAlunos.Add(alunoObject1);
            ListaAlunos.Add (alunoObject2);

            return Ok(ListaAlunos);

        }
    }
}



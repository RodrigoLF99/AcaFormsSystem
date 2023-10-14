using AcaFormSystemAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcaFormSystemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {

        [HttpPost( "CreateAluno")]
        public ActionResult CreateAluno(Aluno aluno)
        {
            if (aluno.Idade >= 18)
            {

                string resultado = "Aluno cadastrado com sucesso";

                return Ok(resultado);

            }
            else
            {

                string resultado = "Aluno necessita da aprovação dos Pais";

                return Ok(resultado);

            }

        }




        [HttpGet( "GetAluno")]
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



            var alunoObject3 = new Aluno();
            alunoObject3.Matricula = 2230;
            alunoObject3.Nome = "Priscila";
            alunoObject3.Idade = 17;
            alunoObject3.Peso = 70;
            alunoObject3.Altura = 167;
            alunoObject3.Endereco = "Rua Vargas";
            alunoObject3.Telefone = 991643552;
            alunoObject3.Email = "priscila@gmail.com";


            var alunoObject4 = new Aluno();
            alunoObject4.Matricula = 2230;
            alunoObject4.Nome = "Amanda";
            alunoObject4.Idade = 20;
            alunoObject4.Peso = 74;
            alunoObject4.Altura = 165;
            alunoObject4.Endereco = "Rua Vargas";
            alunoObject4.Telefone = 991643699;
            alunoObject4.Email = "Amanda@gmail.com";



            var alunoObject5 = new Aluno();
            alunoObject5.Matricula = 2230;
            alunoObject5.Nome = "Thiago";
            alunoObject5.Idade = 27;
            alunoObject5.Peso = 80;
            alunoObject5.Altura = 187;
            alunoObject5.Endereco = "Rua Vargas";
            alunoObject5.Telefone = 991643104;
            alunoObject5.Email = "thiago@gmail.com";

            ListaAlunos.Add(alunoObject1);
            ListaAlunos.Add(alunoObject2);
            ListaAlunos.Add(alunoObject3);
            ListaAlunos.Add(alunoObject4);
            ListaAlunos.Add(alunoObject5);
           
            return Ok(ListaAlunos);

        }




        [HttpGet("GetAlunoByName")]
        public ActionResult GetAlunoByName(string nome)
        {
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



            var alunoObject3 = new Aluno();
            alunoObject3.Matricula = 2230;
            alunoObject3.Nome = "Priscila";
            alunoObject3.Idade = 17;
            alunoObject3.Peso = 70;
            alunoObject3.Altura = 167;
            alunoObject3.Endereco = "Rua Vargas";
            alunoObject3.Telefone = 991643552;
            alunoObject3.Email = "priscila@gmail.com";


            var alunoObject4 = new Aluno();
            alunoObject4.Matricula = 2230;
            alunoObject4.Nome = "Amanda";
            alunoObject4.Idade = 20;
            alunoObject4.Peso = 74;
            alunoObject4.Altura = 165;
            alunoObject4.Endereco = "Rua Vargas";
            alunoObject4.Telefone = 991643699;
            alunoObject4.Email = "Amanda@gmail.com";



            var alunoObject5 = new Aluno();
            alunoObject5.Matricula = 2230;
            alunoObject5.Nome = "Thiago";
            alunoObject5.Idade = 27;
            alunoObject5.Peso = 80;
            alunoObject5.Altura = 187;
            alunoObject5.Endereco = "Rua Vargas";
            alunoObject5.Telefone = 991643104;
            alunoObject5.Email = "thiago@gmail.com";




            if (nome == alunoObject1.Nome  )
            {
                return Ok(alunoObject1);
            }
            


            if (nome == alunoObject2.Nome)
            {
                return Ok(alunoObject2);
            }


            if (nome == alunoObject3.Nome)
            {
                return Ok(alunoObject3);
            }


            if (nome == alunoObject4.Nome)
            {
                return Ok(alunoObject4);
            }


            if (nome == alunoObject5.Nome)
            {
                return Ok(alunoObject5);
            }
            else 
            { 
              return Ok("Aluno não encontrado" );
            
            }
        }



    }
}


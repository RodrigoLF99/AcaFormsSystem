using AcaFormSystemAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcaFormSystemAPI.Controllers
{
    
   
        [ApiController]
        [Route("[controller]")]
        public class FuncionarioController : ControllerBase
        {

            [HttpPost(Name = "CreateFuncionario")]
            public ActionResult CreateFuncionario(Funcionario funcionario)
            {
                if (funcionario.Idade >= 18)
                {

                    string resultado = "Funcionario cadastrado com sucesso";

                    return Ok(resultado);

                }
                else
                {

                    string resultado = "Funcionario precisa ter mais de 18 anos";

                    return Ok(resultado);

                }

            }




            [HttpGet(Name = "GetFuncionario")]
            public ActionResult GetFuncionario()
            {

                var ListaFuncionario = new List<Funcionario>();

                var funcionarioObject1 = new Funcionario();
                funcionarioObject1.Matricula = 2230;
            funcionarioObject1.Nome = "Thiago";
            funcionarioObject1.Idade = 27;
            funcionarioObject1.Peso = 80;
            funcionarioObject1.Altura = 187;
            funcionarioObject1.Endereco = "Rua Vargas";
            funcionarioObject1.Telefone = 991643104;
            funcionarioObject1.Email = "thiago@gmail.com";



                var funcionarioObject2 = new Funcionario();
            funcionarioObject2.Matricula = 2231;
            funcionarioObject2.Nome = "Felipe";
            funcionarioObject2.Idade = 16;
            funcionarioObject2.Peso = 75;
            funcionarioObject2.Altura = 176;
            funcionarioObject2.Endereco = "Rua Jorge";
            funcionarioObject2.Telefone = 967485321;
            funcionarioObject2.Email = "felipe@gmail.com";

            ListaFuncionario.Add(funcionarioObject1);
                ListaFuncionario.Add(funcionarioObject2);

                return Ok(ListaFuncionario);

            }
        }
    }






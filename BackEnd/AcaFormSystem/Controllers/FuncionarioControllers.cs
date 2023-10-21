using AcaFormSystemAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcaFormSystemAPI.Controllers
{
    
   
        [ApiController]
        [Route("[controller]")]
        public class FuncionarioController : ControllerBase
        {

            [HttpPost("CreateFuncionario")]
            public ActionResult CreateFuncionario(Funcionario funcionario) //
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




            [HttpGet("GetFuncionario")]
            public ActionResult GetFuncionario()
            {

            var ListaFuncionarios = new List<Funcionario>();

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




            var funcionarioObject3 = new Funcionario();
            funcionarioObject3.Matricula = 2230;
            funcionarioObject3.Nome = "Priscila";
            funcionarioObject3.Idade = 17;
            funcionarioObject3.Peso = 70;
            funcionarioObject3.Altura = 167;
            funcionarioObject3.Endereco = "Rua Vargas";
            funcionarioObject3.Telefone = 991643552;
            funcionarioObject3.Email = "priscila@gmail.com";


            var funcionarioObject4 = new Funcionario();
            funcionarioObject4.Matricula = 2230;
            funcionarioObject4.Nome = "Amanda";
            funcionarioObject4.Idade = 20;
            funcionarioObject4.Peso = 74;
            funcionarioObject4.Altura = 165;
            funcionarioObject4.Endereco = "Rua Vargas";
            funcionarioObject4.Telefone = 991643699;
            funcionarioObject4.Email = "Amanda@gmail.com";



            var funcionarioObject5 = new Funcionario();
            funcionarioObject5.Matricula = 2230;
            funcionarioObject5.Nome = "Thiago";
            funcionarioObject5.Idade = 27;
            funcionarioObject5.Peso = 80;
            funcionarioObject5.Altura = 187;
            funcionarioObject5.Endereco = "Rua Vargas";
            funcionarioObject5.Telefone = 991643104;
            funcionarioObject5.Email = "thiago@gmail.com";

            ListaFuncionarios.Add(funcionarioObject1);
            ListaFuncionarios.Add(funcionarioObject2);
            ListaFuncionarios.Add(funcionarioObject3);
            ListaFuncionarios.Add(funcionarioObject4);
            ListaFuncionarios.Add(funcionarioObject5);

            return Ok(ListaFuncionarios);

            }


        [HttpGet("GetFuncionarioByName")]
        public ActionResult GetFuncionarioByName(string nome)
        {
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




            var funcionarioObject3 = new Funcionario();
            funcionarioObject3.Matricula = 2230;
            funcionarioObject3.Nome = "Priscila";
            funcionarioObject3.Idade = 17;
            funcionarioObject3.Peso = 70;
            funcionarioObject3.Altura = 167;
            funcionarioObject3.Endereco = "Rua Vargas";
            funcionarioObject3.Telefone = 991643552;
            funcionarioObject3.Email = "priscila@gmail.com";


            var funcionarioObject4 = new Funcionario();
            funcionarioObject4.Matricula = 2230;
            funcionarioObject4.Nome = "Amanda";
            funcionarioObject4.Idade = 20;
            funcionarioObject4.Peso = 74;
            funcionarioObject4.Altura = 165;
            funcionarioObject4.Endereco = "Rua Vargas";
            funcionarioObject4.Telefone = 991643699;
            funcionarioObject4.Email = "Amanda@gmail.com";



            var funcionarioObject5 = new Funcionario();
            funcionarioObject5.Matricula = 2230;
            funcionarioObject5.Nome = "Thiago";
            funcionarioObject5.Idade = 27;
            funcionarioObject5.Peso = 80;
            funcionarioObject5.Altura = 187;
            funcionarioObject5.Endereco = "Rua Vargas";
            funcionarioObject5.Telefone = 991643104;
            funcionarioObject5.Email = "thiago@gmail.com";


            if (nome == funcionarioObject1.Nome)
            {
                return Ok(funcionarioObject1);
            }



            if (nome == funcionarioObject2.Nome)
            {
                return Ok(funcionarioObject2);
            }


            if (nome == funcionarioObject3.Nome)
            {
                return Ok(funcionarioObject3);
            }


            if (nome == funcionarioObject4.Nome)
            {
                return Ok(funcionarioObject4);
            }


            if (nome == funcionarioObject5.Nome)
            {
                return Ok(funcionarioObject5);
            }
            else
            {
                return Ok("|Funcionário não encontrado");

            }
        }

        }
    }






using AcaFormSystemAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcaFormSystemAPI.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class FornecedorController : ControllerBase
    {
        [HttpPost("CreateFornecedor")]
        public ActionResult CreateFornecedor(Fornecedor fornecedor)
        {
            if (fornecedor.Quantidade >= 10)
            {

                string resultado = "Fornecedor cadastrado com sucesso";

                return Ok(resultado);

            }
            else
            {

                string resultado = "Fornecedor precisa ter mais de 10 quantidade";

                return Ok(resultado);

            }

        }

        [HttpGet("GetFornecedor")]
        public ActionResult GetFornecedor()
        {
            var ListaFornecedores = new List<Fornecedor>();

            var fornecedorObject1 = new Fornecedor();
            fornecedorObject1.Cnpj = 2230;
            fornecedorObject1.Nome = "Thiago";
            fornecedorObject1.Mercadoria = 80;
            fornecedorObject1.Quantidade = 187;
            fornecedorObject1.Endereco = "Rua Vargas";
            fornecedorObject1.Telefone = 991643104;
            fornecedorObject1.Email = "thiago@gmail.com";

            var fornecedorObject2 = new Fornecedor();
            fornecedorObject2.Cnpj = 2231;
            fornecedorObject2.Nome = "Felipe";
            fornecedorObject2.Mercadoria = 75;
            fornecedorObject2.Quantidade = 176;
            fornecedorObject2.Endereco = "Rua Jorge";
            fornecedorObject2.Telefone = 967485321;
            fornecedorObject2.Email = "felipe@gmail.com";

            var fornecedorObject3 = new Fornecedor();
            fornecedorObject3.Cnpj = 2230;
            fornecedorObject3.Nome = "Priscila";
            fornecedorObject3.Mercadoria = 70;
            fornecedorObject3.Quantidade = 167;
            fornecedorObject3.Endereco = "Rua Vargas";
            fornecedorObject3.Telefone = 991643552;
            fornecedorObject3.Email = "priscila@gmail.com";

            var fornecedorObject4 = new Fornecedor();
            fornecedorObject4.Cnpj = 2230;
            fornecedorObject4.Nome = "Amanda";
            fornecedorObject4.Mercadoria = 74;
            fornecedorObject4.Quantidade = 165;
            fornecedorObject4.Endereco = "Rua Vargas";
            fornecedorObject4.Telefone = 991643699;
            fornecedorObject4.Email = "Amanda@gmail.com";

            var fornecedorObject5 = new Fornecedor();
            fornecedorObject5.Cnpj = 2230;
            fornecedorObject5.Nome = "Thiago";
            fornecedorObject5.Mercadoria = 80;
            fornecedorObject5.Quantidade = 187;
            fornecedorObject5.Endereco = "Rua Vargas";
            fornecedorObject5.Telefone = 991643104;
            fornecedorObject5.Email = "thiago@gmail.com";

            ListaFornecedores.Add(fornecedorObject1);
            ListaFornecedores.Add(fornecedorObject2);
            ListaFornecedores.Add(fornecedorObject3);
            ListaFornecedores.Add(fornecedorObject4);
            ListaFornecedores.Add(fornecedorObject5);

            return Ok(ListaFornecedores);
        }

        [HttpGet("GetFornecedorByName")]
        public ActionResult GetFornecedorByName(string nome)
        {
            var fornecedorObject1 = new Fornecedor();
            fornecedorObject1.Cnpj = 2230;
            fornecedorObject1.Nome = "Thiago";
            fornecedorObject1.Mercadoria = 80;
            fornecedorObject1.Quantidade = 187;
            fornecedorObject1.Endereco = "Rua Vargas";
            fornecedorObject1.Telefone = 991643104;
            fornecedorObject1.Email = "thiago@gmail.com";

            var fornecedorObject2 = new Fornecedor();
            fornecedorObject2.Cnpj = 2231;
            fornecedorObject2.Nome = "Felipe";
            fornecedorObject2.Mercadoria = 75;
            fornecedorObject2.Quantidade = 176;
            fornecedorObject2.Endereco = "Rua Jorge";
            fornecedorObject2.Telefone = 967485321;
            fornecedorObject2.Email = "felipe@gmail.com";

            var fornecedorObject3 = new Fornecedor();
            fornecedorObject3.Cnpj = 2230;
            fornecedorObject3.Nome = "Priscila";
            fornecedorObject3.Mercadoria = 70;
            fornecedorObject3.Quantidade = 167;
            fornecedorObject3.Endereco = "Rua Vargas";
            fornecedorObject3.Telefone = 991643552;
            fornecedorObject3.Email = "priscila@gmail.com";

            var fornecedorObject4 = new Fornecedor();
            fornecedorObject4.Cnpj = 2230;
            fornecedorObject4.Nome = "Amanda";
            fornecedorObject4.Mercadoria = 74;
            fornecedorObject4.Quantidade = 165;
            fornecedorObject4.Endereco = "Rua Vargas";
            fornecedorObject4.Telefone = 991643699;
            fornecedorObject4.Email = "Amanda@gmail.com";

            var fornecedorObject5 = new Fornecedor();
            fornecedorObject5.Cnpj = 2230;
            fornecedorObject5.Nome = "Thiago";
            fornecedorObject5.Mercadoria = 80;
            fornecedorObject5.Quantidade = 187;
            fornecedorObject5.Endereco = "Rua Vargas";
            fornecedorObject5.Telefone = 991643104;
            fornecedorObject5.Email = "thiago@gmail.com";

            if (nome == fornecedorObject1.Nome)
            {
                return Ok(fornecedorObject1);
            }

            if (nome == fornecedorObject2.Nome)
            {
                return Ok(fornecedorObject2);
            }

            if (nome == fornecedorObject3.Nome)
            {
                return Ok(fornecedorObject3);
            }

            if (nome == fornecedorObject4.Nome)
            {
                return Ok(fornecedorObject4);
            }

            if (nome == fornecedorObject5.Nome)
            {
                return Ok(fornecedorObject5);
            }
            else
            {
                return Ok("Fornecedor não encontrado");
            }
        }

    }
}

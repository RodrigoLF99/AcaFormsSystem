namespace AcaFormSystemAPI.Entities
{
    public class Fornecedor
    {

        public int Cnpj { get; set; }
        public string? Nome { get; set; }
        public int Mercadoria { get; set; }
        public int Quantidade { get; set; }
        public string? Endereco { get; set; }
        public int Telefone { get; set; }
        public string? Email { get; set; }
    }
}

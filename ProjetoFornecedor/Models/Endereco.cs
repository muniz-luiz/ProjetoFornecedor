namespace ProjetoFornecedor.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorID { get; set; }

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        //EF relation
        public Fornecedor Fornecedor { get; set; }
    }
}

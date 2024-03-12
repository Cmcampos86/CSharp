using Sample_Class.AutoMapper.Interface;

namespace Sample_Class.AutoMapper.Entidades
{
    public class Endereco : IEndereco
    {
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
    }
}

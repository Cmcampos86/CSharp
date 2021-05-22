using Sample_Class.AutoMapper.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

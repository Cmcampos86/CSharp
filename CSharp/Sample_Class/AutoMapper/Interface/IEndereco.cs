using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Class.AutoMapper.Interface
{
    public interface IEndereco
    {
        string Cep { get; set; }
        string Cidade { get; set; }
        string Pais { get; set; }
        string Rua { get; set; }
    }
}

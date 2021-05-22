using Sample_Class.AutoMapper.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Class.AutoMapper.Entidades
{
    public class AlunoViewItem
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public IEndereco Endereco { get; set; }
        public string Genero { get; set; }
        public int Idade { get; set; }
        public DateTime Nascimento { get; set; }
        public List<Disciplina> Disciplina { get; set; }
    }
}

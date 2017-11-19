using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Entidades
{
    public class Funcionario : Pessoa
    {
        public long codigoFuncionario { get; set; }
        public long rg { get; set; }
        public DateTime dataNascimento { get; set; }
        public long cep { get; set; }

        public Funcionario() : base() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Entidades
{
    public class Pessoa
    {
        public String nome{ get; set; }
        public long cpf { get; set; }
        public String sexo { get; set; }
        public long ddd { get; set; }
        public long telefone { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }
        public String rua { get; set; }

        public Pessoa(){}
    }
}

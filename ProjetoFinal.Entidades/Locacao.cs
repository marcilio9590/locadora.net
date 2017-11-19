using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Entidades
{
    class Locacao
    {
        public long codigo { get; set; }
        public TimeSpan data { get; set; }
        public double total { get; set; }
        public Cliente cliente { get; set; }
        public Funcionario funcionario { get; set; }
        public List<Filmes> filmes { get; set; }
    }
}

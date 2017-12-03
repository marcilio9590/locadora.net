using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Entidades
{
    public class Locacao
    {
        public long codigoLocacao { get; set; }
        public TimeSpan data { get; set; }
        public double total { get; set; }
        public long status { get; set; }
        public Cliente cliente { get; set; }
        public Funcionario funcionario { get; set; }
        public List<Filmes> filmes { get; set; }

        public Locacao()
        {
            this.cliente = new Cliente();
            this.funcionario = new Funcionario();
            this.filmes = new List<Filmes>(0);
        }
    }
}

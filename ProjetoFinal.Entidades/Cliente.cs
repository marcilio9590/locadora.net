using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Entidades
{
    public class Cliente : Pessoa
    {
        public long codigoCliente { get; set; }
        public String email { get; set; }

        public Cliente() : base() { }
    }
}

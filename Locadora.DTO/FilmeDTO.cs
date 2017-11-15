using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.DTO
{
    public class FilmeDTO
    {
        private int codigo;
        private String nome;
        private String genero;
        private Decimal preco;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Genero { get => genero; set => genero = value; }
        public decimal Preco { get => preco; set => preco = value; }
    }
}

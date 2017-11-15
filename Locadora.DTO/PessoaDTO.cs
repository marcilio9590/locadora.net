using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.DTO
{
    class PessoaDTO
    {
        private int codigo;
        private String nome;
        private String rua;
        private String numeroCasa;
        private String cep;
        private String bairro;
        private String cidade;
        private String cpf;
        private String rg;
        private String sexo;
        private DateTime dataNascimento;
        private String telefone;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rua { get => rua; set => rua = value; }
        public string NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}

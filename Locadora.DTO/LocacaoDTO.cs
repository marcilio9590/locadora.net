using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.DTO
{
    class LocacaoDTO
    {
        private int codigoLocacao;
        private int codigoCliente;
        private int codigoFuncionario;
        private String nomeCliente;
        private String nomeFuncionario;
        private Decimal total;
        private DateTime data;
        private List<FilmeDTO> filmes;

        public int CodigoLocacao { get => codigoLocacao; set => codigoLocacao = value; }
        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        public int CodigoFuncionario { get => codigoFuncionario; set => codigoFuncionario = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string NomeFuncionario { get => nomeFuncionario; set => nomeFuncionario = value; }
        public decimal Total { get => total; set => total = value; }
        public DateTime Data { get => data; set => data = value; }
        public List<FilmeDTO> Filmes { get => filmes; set => filmes = value; }
    }
}

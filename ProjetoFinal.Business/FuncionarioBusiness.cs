using ProjetoFinal.Dados;
using ProjetoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Business
{
    public class FuncionarioBusiness
    {
        public Funcionario buscarFuncionario(String codigo)
        {
            Funcionario f = new Funcionario();
            FuncionarioDados dao = new FuncionarioDados();

            try
            {
                f = dao.buscarFuncionario(codigo);

            }
            catch (Exception e)
            {
                throw e;
            }

            return f;
        }
    }
}

using ProjetoFinal.Dados;
using ProjetoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Business
{
    public class LocacaoBusiness
    {

        public DataTable GetItens()
        {
            LocacaoDados objID = new LocacaoDados();

            return objID.Consultar();
        }

        public void SetItem(Locacao item)
        {
            LocacaoDados objID = new LocacaoDados();

            objID.Inserir(item);
        }

        public DataTable getFilmesLocacao(String codigo)
        {
            LocacaoDados objID = new LocacaoDados();
            try
            {
                return objID.ConsultarFilmes(codigo);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

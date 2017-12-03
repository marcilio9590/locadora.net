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
    public class FilmesBusiness
    {
        public DataTable GetItens()
        {
            FilmesDados objID = new FilmesDados();

            return objID.Consultar();
        }

        public void SetItem(Filmes item)
        {
            FilmesDados objID = new FilmesDados();

            objID.Inserir(item);
        }

        public Filmes buscarFilme(String codigo)
        {
            Filmes f = null;
            FilmesDados dao = new FilmesDados();

            try
            {
                f = dao.buscarFilme(codigo);
            }
            catch (Exception e)
            {
                throw e;
            }

            return f;
        }
    }
}

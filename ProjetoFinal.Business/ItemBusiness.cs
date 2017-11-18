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
    public class ItemBusiness
    {
        public DataTable GetItens()
        {
            ItemDados objID = new ItemDados();

            return objID.Consultar();
        }

        public void SetItem(Filmes item)
        {
            ItemDados objID = new ItemDados();

            objID.Inserir(item);
        }
    }
}

using ProjetoFinal.Dados;
using ProjetoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Business
{
    public class ClienteBusiness
    {

        public Cliente buscarCliente(String codigo)
        {
            Cliente c = new Cliente();
            ClienteDados dao = new ClienteDados();

            try
            {
                c = dao.buscarCliente(codigo);

            }
            catch (Exception e)
            {
                throw e;
            }

            return c;
        }
    }
}

using MySql.Data.MySqlClient;
using ProjetoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Dados
{
    public class ClienteDados
    {
        private MySqlConnection con;

        public Cliente buscarCliente(String codigo)
        {
            con = ManageConnection.GetInstance().GetConection();
            String query = "SELECT * FROM CLIENTES WHERE cod_cliente = ?codCliente";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?codCliente", codigo);
                MySqlDataReader dataReader = cmd.ExecuteReader();



                Cliente c = null;
                if (dataReader.Read())
                {
                    c.nome = dataReader["nome"].ToString();
                    c.codigoCliente = long.Parse(dataReader["cod_cliente"].ToString());
                }


                return c;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
        }
    }
}

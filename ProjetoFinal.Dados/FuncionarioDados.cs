using MySql.Data.MySqlClient;
using ProjetoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Dados
{
    public class FuncionarioDados
    {
        private MySqlConnection con;

        public Funcionario buscarFuncionario(String codigo)
        {
            con = ManageConnection.GetInstance().GetConection();
            String query = "SELECT * FROM funcionarios WHERE cod_funcionario = ?codFuncionario";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?codFuncionario", codigo);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                Funcionario c = null;
                if (dataReader.Read())
                {
                    c = new Funcionario();
                    c.nome = dataReader["nome"].ToString();
                    c.codigoFuncionario = long.Parse(dataReader["cod_funcionario"].ToString());
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

using MySql.Data.MySqlClient;
using ProjetoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Dados
{
    public class LocacaoDados
    {

        private MySqlConnection con;

        FilmesDados filmesDados = new FilmesDados();

        public void InserirLocacao(Locacao item)
        {
            con = ManageConnection.GetInstance().GetConection();
            String query = "INSERT INTO locacoes (cod_cliente,cod_funcionario,data,total,status) VALUES";
            query += "(?codigocliente, ?codigofuncionario, ?data, ?total, ?status)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?codigocliente", item.cliente.codigoCliente);
                cmd.Parameters.AddWithValue("?codigofuncionario", item.funcionario.codigoFuncionario);
                cmd.Parameters.AddWithValue("?data", item.data);
                cmd.Parameters.AddWithValue("?total", item.total);
                cmd.Parameters.AddWithValue("?status", 0);
                cmd.ExecuteNonQuery();
                long id = cmd.LastInsertedId;
                cmd.Dispose();
                inserirFilmesLocacao(id,item.filmes);
            }
            finally
            {
                con.Close();
            }
        }

        public void inserirFilmesLocacao(long id, List<Filmes> filmes)
        {
            con = ManageConnection.GetInstance().GetConection();
            MySqlCommand cmd = null;
            try
            {
                con.Open();
                foreach (Filmes item in filmes)
                {
                    String query = "INSERT INTO itens_locacao (cod_locacao,cod_filme) VALUES (?codigoLocacao,?codigoFilme)";
                    cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("?codigoLocacao", id);
                    cmd.Parameters.AddWithValue("?codigoFilme", item.codigo);
                    cmd.ExecuteNonQuery();
                    atualizarStatusFilme(item);
                }
                cmd.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            } finally
            {
                con.Close();
            }
        }

        private void atualizarStatusFilme(Filmes item)
        {
            filmesDados.atualizarStatusFilmes(item);
        }

        private long recuperarIdInserido()
        {
            long id = 0;
            con = ManageConnection.GetInstance().GetConection();
            String query = "SELECT LAST_INSERT_ID()";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    id = long.Parse(dataReader["LAST_INSERT_ID()"].ToString());
                }
                return id;
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

        public DataTable Consultar()
        {
            con = ManageConnection.GetInstance().GetConection();
            String query = "Select l.cod_locacao, c.cod_cliente, c.nome, l.data,l.status,l.total from locacoes l inner join clientes c on  l.cod_cliente = c.cod_cliente;";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dtItens = new DataTable();
                da.Fill(dtItens);

                return dtItens;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ConsultarFilmes(String id)
        {
            con = ManageConnection.GetInstance().GetConection();
            String query = "SELECT il.cod_locacao, il.codigo, f.cod_filme, f.nome, f.preco " +
                "FROM filmes f inner join itens_locacao il on f.cod_filme = il.cod_filme where il.cod_locacao = ?codigo";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?codigo", id);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dtItens = new DataTable();
                da.Fill(dtItens);
                return dtItens;
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

        public void excluirFilmeLocacao(String codigoLocacao, String codigoItem, String codigoFilme)
        {
            con = ManageConnection.GetInstance().GetConection();
            con.Open();

            MySqlTransaction myTrans;
            myTrans = con.BeginTransaction(IsolationLevel.ReadCommitted);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.Transaction = myTrans;

            try
            {
                cmd.CommandText = "DELETE from itens_locacao WHERE codigo = ?codigo";
                cmd.Parameters.AddWithValue("?codigo", codigoItem);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE filmes set status = 1 where cod_filme = ?codigoFilme";
                cmd.Parameters.AddWithValue("?codigoFilme", codigoFilme);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE locacoes l inner join filmes f on ?codigoFilme = f.cod_filme set l.total = l.total - f.preco where l.cod_locacao =  ?codigolocacao";
                cmd.Parameters.AddWithValue("?cod_filme", codigoFilme);
                cmd.Parameters.AddWithValue("?codigolocacao", codigoLocacao);
                cmd.ExecuteNonQuery();
                myTrans.Commit();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                myTrans.Rollback();
                Console.WriteLine(e.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        public void excluirLocacao(List<String> lista)
        {
            con = ManageConnection.GetInstance().GetConection();
            con.Open();

            MySqlTransaction myTrans;
            myTrans = con.BeginTransaction(IsolationLevel.ReadCommitted);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.Transaction = myTrans;

            try
            {

                for (int i = 0; i < lista.Count; i++)
                {
                    String codigo = lista[i];

                    cmd.CommandText = "UPDATE filmes AS a INNER JOIN itens_locacao AS b ON a.cod_filme = b.cod_filme SET a.status = 1 WHERE  b.cod_locacao = ?codigo";
                    cmd.Parameters.AddWithValue("?codigo", codigo);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "DELETE FROM itens_locacao WHERE cod_locacao = ?codigo2";
                    cmd.Parameters.AddWithValue("?codigo2", codigo);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "DELETE FROM locacoes WHERE cod_locacao = ?codigo3";
                    cmd.Parameters.AddWithValue("?codigo3", codigo);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                }
                    myTrans.Commit();
                    cmd.Dispose();
            }
            catch (Exception e)
            {
                myTrans.Rollback();
                Console.WriteLine(e.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        public void atualizarTotal(String codigoLocacao, String codigoFilme)
        {
            con = ManageConnection.GetInstance().GetConection();
            con.Open();
            MySqlCommand cmd = null;
            try
            {
                String query = "UPDATE locacoes l inner join filmes f on ?codigoFilme = f.cod_filme set l.total = l.total + f.preco where l.cod_locacao = ?codigoLocacao";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?codigoLocacao", codigoLocacao);
                cmd.Parameters.AddWithValue("?codigoFilme", codigoFilme);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
    }
}

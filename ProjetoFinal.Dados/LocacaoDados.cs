using MySql.Data.MySqlClient;
using ProjetoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Dados
{
    public class LocacaoDados
    {

        private MySqlConnection con;

        public void Inserir(Locacao item)
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
                cmd.Parameters.AddWithValue("?status", item.status);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void Atualizar(Locacao item)
        {
            con = ManageConnection.GetInstance().GetConection();
            String query = "UPDATE locacoes SET cod_cliente = ?codigocliente, cod_funcionario = ?codigofuncionario," +
                " total = ?total";
            query += " WHERE cod_locacao = ?codigolocacao";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?codigocliente", item.cliente.codigoCliente);
                cmd.Parameters.AddWithValue("?codigofuncionario", item.funcionario.codigoFuncionario);
                cmd.Parameters.AddWithValue("?total", item.total);
                cmd.Parameters.AddWithValue("?codigolocacao", item.codigoLocacao);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void Remover(String itemcodigo, Int32 itemid)
        {
            con = ManageConnection.GetInstance().GetConection();
            String query = "DELETE FROM filmes ";
            query += "WHERE cod_filme = ?itemcodigo";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemcodigo", itemcodigo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Consultar()
        {
            con = ManageConnection.GetInstance().GetConection();
            String query = "Select l.cod_locacao, c.nome, l.data,l.status,l.total from locacoes l inner join clientes c on  l.cod_cliente = c.cod_cliente;";

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

        public Filmes Consultar(int id)
        {
            Filmes i = new Filmes();
            return i;
        }
    }
}

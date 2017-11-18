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
    public class ItemDados
    {

        private MySqlConnection con;

        public void Inserir(Filmes item)
        {
            con = ManageConnection.GetInstance().GetConection();
            String query = "INSERT INTO filmes (nome, genero, status,preco) VALUES";
            query += "(?itemnome, ?itemgenero, ?itemstatus, ?itempreco)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemnome", item.descricao); //descricao
                cmd.Parameters.AddWithValue("?itemgenero", item.genero); //genero
                cmd.Parameters.AddWithValue("?itemstatus", item.status); //status
                cmd.Parameters.AddWithValue("?itempreco", item.preco); //preco
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void Atualizar(long cod_filme, String itemnome, String itemgenero, int itemstatus, double itempreco)
        {
            con = ManageConnection.GetInstance().GetConection();
            String query = "UPDATE filmes SET nome = ?itemnome, genero = ?itemgenero, status = ?itemstatus, preco = ?itempreco";
            query += " WHERE cod_filme = ?itemcod_filme";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemnome", itemnome);
                cmd.Parameters.AddWithValue("?itemgenero", itemgenero);
                cmd.Parameters.AddWithValue("?itemstatus", itemstatus);
                cmd.Parameters.AddWithValue("?itempreco", itempreco);
                cmd.Parameters.AddWithValue("?itemcod_filme", cod_filme);
                
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
            String query = "Select * from filmes ";
 
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

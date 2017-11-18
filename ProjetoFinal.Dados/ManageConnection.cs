using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Dados
{
    public class ManageConnection
    {
        private static ManageConnection instanceManageConection;
        private String connectionString;

        private ManageConnection()
        {

        }
        public static ManageConnection GetInstance()
        {
            if (instanceManageConection == null)
            {
                instanceManageConection = new ManageConnection();
            }

            return instanceManageConection;
        }

        public MySqlConnection GetConection()
        {
            string conn  = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            return new MySqlConnection(conn);
        }
    }
}

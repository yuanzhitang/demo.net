using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string query = "SELECT * FROM BO_LS";
            var a = conn.Query(query).ToList();
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Tech_lab
{
    public class DataBase
    {
        public static NpgsqlConnection GetConnection(string username, string password)
        {
            string connectionString = $"Host=localhost;Port=5432;Username={username};Password={password};Database=Lab_2_Havryliuk;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}

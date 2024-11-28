using Npgsql;
using PBO_B08.App.Core;
using PBO_B08.App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B08.App.Context
{
    internal class C_Login : DataWrapper
    {
        public static DataTable All()
        {
            string query = @"SELECT * FROM Dokter";
            DataTable userData = queryExecutor(query);
            return userData;
        }

        public M_Dokter Validate(string username, string password)
        {
            M_Dokter accountLogin = null;
            string query = @"SELECT * FROM Dokter WHERE Username = @username AND Password = @password LIMIT 1";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", password)
            };

            using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))
            {
                if (reader.Read())
                {
                    accountLogin = new M_Dokter(username, password);
                    accountLogin.Username = (string)reader["Username"];
                    accountLogin.Password = (string)reader["Password"];
                }
            }
            return accountLogin;
        }
    }
}

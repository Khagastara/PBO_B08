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

        public M_Akun Validate(string username, string password)
        {
            M_Akun accountLogin = null;
            try
            {
                string query = @"SELECT d.iddokter, d.namadokter, d.emaildokter, a.username, a.password 
                         FROM dokter d JOIN akun a ON d.iddokter = a.iddokter 
                         WHERE Username = @username AND Password = @password LIMIT 1";

                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", password)
                };

                using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))
                {
                    if (reader.Read())
                    {
                        accountLogin = new M_Akun(username, password);
                        accountLogin.username = (string)reader["username"];
                        accountLogin.password = (string)reader["password"];
                        accountLogin.idDokter = (int)reader["iddokter"];

                        UserSession.LoggedInDoctorId = accountLogin.idDokter;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return accountLogin;
        }
    }
}

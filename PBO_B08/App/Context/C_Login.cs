﻿using Npgsql;
using PBO_B08.App.Core;
using PBO_B08.App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B08.App.Context
{
    internal class C_Login : DataWrapper
    {
        public static DataTable All()
        {
            string query = @"SELECT * FROM akun";
            DataTable userData = queryExecutor(query);
            return userData;
        }

        public M_Akun Validate(string username, string password)
        {
            M_Akun accountLogin = null;
            string query = @"SELECT * FROM akun WHERE username = @username AND password = @password";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", password)
            };

            using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))

                if (reader.Read())
                {
                    accountLogin = new M_Akun(username, password);
                    accountLogin.Username = (string)reader["username"];
                    accountLogin.Password = (string)reader["password"];

                };
            return accountLogin;
        }
    }
}

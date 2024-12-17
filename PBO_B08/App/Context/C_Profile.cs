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
    internal class C_Profile : DataWrapper
    {
        public static void UpdateAccount(int doctorId, string newUsername, string newPassword)
        {
            string query = @"UPDATE akun 
                             SET username = @username, password = @password 
                             WHERE iddokter = @idDokter";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", newUsername),
                new NpgsqlParameter("@password", newPassword),
                new NpgsqlParameter("@idDokter", doctorId)
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateUserProfile(string name, string specialize, string gender, string email, string phonenumber)
        {
            string query = @"UPDATE Dokter
                             SET namaDokter = @namaDokter, spesialisasi = @spesialisasi, jenisKelamin = @jenisKelamin, emailDokter = @emailDokter, noTelepon = @noTelepon
                             WHERE idDokter = @idDokter";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namaDokter", name),
                new NpgsqlParameter("@spesialisasi", specialize),
                new NpgsqlParameter("@jenisKelamin", gender),
                new NpgsqlParameter("@emailDokter", email),
                new NpgsqlParameter("@noTelepon", phonenumber)
            };

            commandExecutor(query, parameters);
        }
    }
}
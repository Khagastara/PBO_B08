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

        public M_Akun Validate(string username, string password)
        {
            M_Akun accountLogin = null;
            try
            {
                string query = @"SELECT d.iddokter, d.namadokter, d.spesialisasi, d.jenisKelamin, d.emaildokter, d.noTelepon,
                                 a.username, a.password 
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
                        M_Dokter userLogin = new M_Dokter();
                        userLogin.namaDokter = (string)reader["namadokter"];
                        userLogin.spesialisasi = (string)reader["spesialisasi"];
                        userLogin.jenisKelamin = (string)reader["jenisKelamin"];
                        userLogin.emailDokter = (string)reader["emaildokter"];
                        userLogin.noTelepon = (string)reader["noTelepon"];

                        UserSession.LoggedInDoctor = userLogin.namaDokter;
                        UserSession.LoggedInSpecialize = userLogin.spesialisasi;
                        UserSession.LoggedInGender = userLogin.jenisKelamin;
                        UserSession.LoggedInEmail = userLogin.emailDokter;
                        UserSession.LoggedInPhone = userLogin.noTelepon;

                        accountLogin = new M_Akun(username, password);
                        accountLogin.idDokter = (int)reader["iddokter"];
                        accountLogin.username = (string)reader["username"];
                        accountLogin.password = (string)reader["password"];

                        UserSession.LoggedInDoctorId = accountLogin.idDokter;
                        UserSession.LoggedInUsername = accountLogin.username; 
                        UserSession.LoggedInPassword = accountLogin.password; 
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

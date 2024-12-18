using Npgsql;
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
    internal class C_Pasien : DataWrapper
    {
        private static string table = "pasien";

        public static DataTable All()
        {
            string query = @"SELECT * FROM pasien ORDER BY namaPasien ASC";

            DataTable dataPasien = queryExecutor(query);
            return dataPasien;
        }

        public static DataTable getPasienById(int idPasien)
        {
            string query = @"SELECT * FROM pasien
                             WHERE idPasien = @idPasien
                             ORDER BY namaPasien ASC";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idPasien", NpgsqlTypes.NpgsqlDbType.Integer){Value = idPasien}
            };

            DataTable dataPasien = queryExecutor(query, parameters);
            return dataPasien;
        }

        public static void addPasien(M_Pasien pasienBaru)
        {
            string query = $"INSERT INTO {table} (namaPasien, jenisKelamin, tanggalLahir, noTelepon, alamat) VALUES (@namaPasien, @jenisKelamin, @tanggalLahir, @noTelepon, @alamat)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namaPasien", pasienBaru.namaPasien),
                new NpgsqlParameter("@jenisKelamin", pasienBaru.jenisKelamin),
                new NpgsqlParameter("@tanggalLahir", pasienBaru.tanggalLahir),
                new NpgsqlParameter("@noTelepon", pasienBaru.noTelepon),
                new NpgsqlParameter("@alamat", pasienBaru.Alamat)
            };

            commandExecutor(query, parameters);
        }

        public static DataTable searchByName(string namaPasien)
        {
            string query = $"SELECT * FROM pasien WHERE namaPasien ILIKE @namaPasien";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namaPasien", $"%{namaPasien}%")
            };

            DataTable dataPasien = queryExecutor(query, parameters);
            return dataPasien;
        }

        public static void updatePasien(M_Pasien pasien)
        {
            string query = $@"
        UPDATE {table}
        SET 
            namaPasien = @namaPasien, 
            jenisKelamin = @jenisKelamin, 
            tanggalLahir = @tanggalLahir, 
            noTelepon = @noTelepon, 
            alamat = @alamat
        WHERE idPasien = @idPasien";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idPasien", pasien.idPasien),
                new NpgsqlParameter("@namaPasien", pasien.namaPasien),
                new NpgsqlParameter("@jenisKelamin", pasien.jenisKelamin),
                new NpgsqlParameter("@tanggalLahir", pasien.tanggalLahir),
                new NpgsqlParameter("@noTelepon", pasien.noTelepon),
                new NpgsqlParameter("@alamat", pasien.Alamat)
            };

            commandExecutor(query, parameters);
        }

        public static void deletePasien(int idPasien)
        {
            string query = $"DELETE FROM {table} WHERE idPasien = @idPasien";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idPasien", idPasien)
            };

            commandExecutor(query, parameters);
        }
    }
}

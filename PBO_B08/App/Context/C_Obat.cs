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
    internal class C_Obat : DataWrapper
    {
        private static string table = "obat";
        public static DataTable All()
        {
            string query = @"SELECT * FROM obat";

            DataTable dataObat = queryExecutor(query);
            return dataObat;
        }

        public static DataTable getObatById(int idObat)
        {
            string query = @"SELECT * FROM obat WHERE idObat = @idObat";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idObat", NpgsqlTypes.NpgsqlDbType.Integer)
                {
                    Value = idObat
                }
            };

            DataTable dataObat = queryExecutor(query);
            return dataObat;
        }

        public static void addObat(M_Obat obatBaru)
        {
            string query = $"INSERT INTO {table} (namaObat) VALUES (@namaObat)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namaObat", obatBaru.namaObat)
            };

            commandExecutor(query, parameters);
        }
    }
}

using Npgsql;
using PBO_B08.App.Core;
using PBO_B08.App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PBO_B08.App.Context
{
    internal class C_Obat : DataWrapper
    {
        private static string table = "obat";
        public static DataTable All()
        {
            string query = @"SELECT * FROM obat
                             ORDER BY namaObat ASC";

            DataTable dataObat = queryExecutor(query);
            return dataObat;
        }

        public static DataTable getObatByName(string namaObat)
        {
            string query = @"SELECT * FROM obat WHERE namaObat ILIKE @namaObat
                             ORDER BY namaObat ASC";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namaObat", $"%{namaObat}%")
            };

            DataTable dataObat = queryExecutor(query, parameters);
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

        public static bool IsObatExists(string namaObat)
        {
            string query = @"SELECT COUNT(*) FROM obat WHERE LOWER(namaObat) = LOWER(@namaObat)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namaObat", NpgsqlTypes.NpgsqlDbType.Varchar)
                {
                    Value = namaObat
                }
            };

            DataTable result = queryExecutor(query, parameters);
            return Convert.ToInt32(result.Rows[0][0]) > 0;
        }
    }
}

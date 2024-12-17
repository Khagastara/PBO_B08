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
using System.Windows.Documents;

namespace PBO_B08.App.Context
{
    internal class C_Homepage : DataWrapper
    {
        public static int TotalPasien()
        {
            string query = $"SELECT COUNT(*) FROM Pasien";

            object result = scalarExecutor(query);
            return Convert.ToInt32(result);
        }

        public static int TotalRekamMedis()
        {
            string query = "SELECT COUNT(*) FROM hasilPemeriksaan";
            object result = scalarExecutor(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }
    }
}

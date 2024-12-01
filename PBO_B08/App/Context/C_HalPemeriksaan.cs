using Npgsql;
using PBO_B08.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B08.App.Context
{
    internal class C_HalPemeriksaan : DataWrapper
    {
        public static DataTable All()
        {
            string query = @"SELECT pe.idRekam, pa.namaPasien, d.namaDokter, pe.tanggalPemeriksaan, hp.hasilPemeriksaan, hp.Diagnosis, o.namaObat
                             FROM Pemeriksaan pe
                             JOIN Pasien pa ON pa.idPasien = pe.idPasien
                             JOIN Dokter d ON d.idDokter = pe.idDokter
                             JOIN hasilPemeriksaan hp ON hp.idRekam = pe.idRekam
                             JOIN pemeriksaanObat po ON po.idRekam = pe.idRekam
                             JOIN obat o ON o.idObat = po.idObat";

            DataTable dataRekam = queryExecutor(query);
            return dataRekam;
        }
        
        public static DataTable getPemeriksaanById(int idRekam)
        {
            string query = @"SELECT pe.idRekam, pa.namaPasien, d.namaDokter, pe.tanggalPemeriksaan, hp.hasilPemeriksaan, hp.Diagnosis, o.namaObat
                             FROM Pemeriksaan pe
                             JOIN Pasien pa ON pa.idPasien = pe.idPasien
                             JOIN Dokter d ON d.idDokter = pe.idDokter
                             JOIN hasilPemeriksaan hp ON hp.idRekam = pe.idRekam
                             JOIN pemeriksaanObat po ON po.idRekam = pe.idRekam
                             JOIN obat o ON o.idObat = po.idObat
                             WHERE pe.idRekam = @idRekam";

            NpgsqlParameter[] Parameters =
            {
                new NpgsqlParameter("@idRekam", NpgsqlTypes.NpgsqlDbType.Integer)
                {
                    Value = idRekam
                }
            };

            DataTable dataRekam = queryExecutor(query);
            return dataRekam;
        }
    }
}

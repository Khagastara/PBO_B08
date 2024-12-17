using Npgsql;
using PBO_B08.App.Core;
using PBO_B08.App.Model;
using PBO_B08.Views;
using System;
using System.Collections;
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
            string query = @"SELECT  pa.namaPasien, d.namaDokter, pe.tanggalPemeriksaan, hp.hasilPemeriksaan, hp.Diagnosis, STRING_AGG(o.namaObat, ', ') AS Obat
                             FROM Pemeriksaan pe
                             JOIN Pasien pa ON pa.idPasien = pe.idPasien
                             JOIN Dokter d ON d.idDokter = pe.idDokter
                             JOIN hasilPemeriksaan hp ON hp.idRekam = pe.idRekam
                             JOIN obat o ON o.idObat = hp.idObat
                             GROUP BY pa.namaPasien, d.namaDokter, pe.tanggalPemeriksaan, hp.hasilPemeriksaan, hp.Diagnosis
                             ORDER BY pe.tanggalPemeriksaan DESC";

            DataTable dataRekam = queryExecutor(query);
            return dataRekam;
        }
        
        public static DataTable getPemeriksaanById(int idRekam)
        {
            string query = @"SELECT  pa.namaPasien, d.namaDokter, pe.tanggalPemeriksaan, hp.hasilPemeriksaan, hp.Diagnosis, STRING_AGG(o.namaObat, ', ') AS Obat
                             FROM Pemeriksaan pe
                             JOIN Pasien pa ON pa.idPasien = pe.idPasien
                             JOIN Dokter d ON d.idDokter = pe.idDokter
                             JOIN hasilPemeriksaan hp ON hp.idRekam = pe.idRekam
                             JOIN obat o ON o.idObat = hp.idObat
                             GROUP BY pa.namaPasien, d.namaDokter, pe.tanggalPemeriksaan, hp.hasilPemeriksaan, hp.Diagnosis
                             ORDER BY pe.tanggalPemeriksaan DESC
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

        public static DataTable listPasien()
        {
            string query = $"SELECT * FROM pasien";

            DataTable dataRekam = queryExecutor(query);
            return dataRekam;
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

        public static DataTable searchRekamByName(string namaPasien)
        {
            string query = @"
                SELECT pa.namaPasien, d.namaDokter, pe.tanggalPemeriksaan, hp.hasilPemeriksaan, hp.Diagnosis, 
                STRING_AGG(o.namaObat, ', ') AS Obat
                FROM Pemeriksaan pe
                JOIN Pasien pa ON pa.idPasien = pe.idPasien
                JOIN Dokter d ON d.idDokter = pe.idDokter
                JOIN hasilPemeriksaan hp ON hp.idRekam = pe.idRekam
                JOIN obat o ON o.idObat = hp.idObat
                WHERE pa.namaPasien ILIKE @namaPasien
                GROUP BY pa.namaPasien, d.namaDokter, pe.tanggalPemeriksaan, hp.hasilPemeriksaan, hp.Diagnosis
                ORDER BY pe.tanggalPemeriksaan DESC";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@namaPasien", $"%{namaPasien}%")
            };

            return queryExecutor(query, parameters);
        }

        public static bool DoctorExists(int doctorId)
        {
            string query = $"SELECT COUNT(*) FROM Dokter WHERE idDokter = @doctorId";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@doctorId", NpgsqlTypes.NpgsqlDbType.Integer) { Value = doctorId }
            };
            DataTable result = queryExecutor(query, parameters);

            return result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0;
        }

        public static DataTable getObatList()
        {
            string query = $"SELECT * FROM obat ORDER BY namaObat ASC";

            DataTable dataObat = queryExecutor(query);
            return dataObat;
        }

        public static int addPemeriksaan(M_Pemeriksaan pemeriksaan)
        {
            string query = @"INSERT INTO Pemeriksaan (idPasien, idDokter, tanggalPemeriksaan)
                             VALUES (@idPasien, @idDokter, @tanggalPemeriksaan)
                             RETURNING idRekam";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idPasien", pemeriksaan.idPasien),
                new NpgsqlParameter("@idDokter", pemeriksaan.idDokter),
                new NpgsqlParameter("@tanggalPemeriksaan", pemeriksaan.tanggalPemeriksaan)
            };

            DataTable result = queryExecutor(query, parameters);
            return result.Rows.Count > 0 ? Convert.ToInt32(result.Rows[0]["idRekam"]) : -1;
        }

        public static void addHasilPemeriksaan(M_HasilPemeriksaan hasilPemeriksaan)
        {
            string query = @"INSERT INTO hasilPemeriksaan (idRekam, hasilPemeriksaan, diagnosis, idObat)
                             VALUES (@idRekam, @hasilPemeriksaan, @diagnosis, @idObat)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idRekam", hasilPemeriksaan.idRekam),
                new NpgsqlParameter("@hasilPemeriksaan", hasilPemeriksaan.hasilPemeriksaan),
                new NpgsqlParameter("@diagnosis", hasilPemeriksaan.diagnosis),
                new NpgsqlParameter("@idObat", hasilPemeriksaan.idObat)
            };

            commandExecutor(query, parameters);
        }
    }
} 


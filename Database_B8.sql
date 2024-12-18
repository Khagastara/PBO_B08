CREATE TABLE Dokter(
	idDokter SERIAL PRIMARY KEY,
	namaDokter VARCHAR(50) NOT NULL,
	spesialisasi VARCHAR(50) NOT NULL,
	jenisKelamin VARCHAR(9) NOT NULL,
	emailDokter VARCHAR(50) NOT NULL,
	noTelepon VARCHAR(13) NOT NULL
);

INSERT INTO Dokter(namaDokter, spesialisasi, jenisKelamin, emailDokter, noTelepon)
VALUES ('Gusti Rayhananda Maulana Muhammad', 'Dokter Umum', 'Laki-laki','gusti@gmail.com', '085748435663'),
	   ('Dewi Kusumawati', 'Dokter Gigi', 'Perempuan', 'dewikusumawati@gmail.com', '08123618262'),
	   ('Ikhwan Saputra', 'Dokter Umum', 'Laki-laki', 'ikhwansaputra@gmail.com', '08317289102');

CREATE TABLE Akun(
	idDokter INT,
	username VARCHAR(50) NOT NULL,
	password VARCHAR(50) NOT NULL,
	
	CONSTRAINT fk_Dokter
	FOREIGN KEY (idDokter)
	REFERENCES Dokter (idDokter)
	ON DELETE CASCADE
);

INSERT INTO Akun(idDokter, username, password)
VALUES (1, 'gusti123', 'Sabendin0'),
	   (2, 'dewi01', 'dewi01'),
	   (3, 'saputra', 'ikhwan');

CREATE TABLE Pasien(
	idPasien SERIAL PRIMARY KEY,
	namaPasien VARCHAR(50) NOT NULL,
	jenisKelamin VARCHAR (9) NOT NULL,
	tanggalLahir DATE NOT NULL,
	noTelepon VARCHAR(13) NOT NULL,
	alamat VARCHAR(50) NOT NULL
);

-- contoh pasien
INSERT INTO Pasien(namaPasien, jenisKelamin, tanggalLahir, noTelepon, alamat)
VALUES ('Miko Ikhwani Arisandi Syarifulloh', 'Laki-laki', '2004-1-1', '081234567891', 'Jl. Jawa');

CREATE TABLE Pemeriksaan(
	idRekam SERIAL PRIMARY KEY,
	idDokter INT,
	idPasien INT,
	tanggalPemeriksaan DATE NOT NULL,
CONSTRAINT fk_Dokter
	FOREIGN KEY (idDokter)
	REFERENCES Dokter (idDokter)
	ON DELETE CASCADE,
CONSTRAINT fk_Pasien
	FOREIGN KEY (idPasien)
	REFERENCES Pasien (idPasien)
	ON DELETE CASCADE
);

CREATE TABLE Obat (
    idObat SERIAL PRIMARY KEY,
    namaObat VARCHAR(100) NOT NULL
);

INSERT INTO Obat (namaObat)
VALUES
    ('Paracetamol'),
    ('Amoxicillin'),
    ('Ibuprofen'),
    ('Cetirizine'),
    ('Metformin'),
    ('Loratadine'),
    ('Amlodipine'),
    ('Ciprofloxacin'),
    ('Omeprazole'),
    ('Doxycycline'),
    ('Salbutamol'),
    ('Simvastatin'),
    ('Furosemide'),
    ('Prednisolone'),
    ('Lisinopril');

CREATE TABLE hasilPemeriksaan(
	idHasil SERIAL PRIMARY KEY,
	idRekam INT,
	idObat INT,
    hasilPemeriksaan VARCHAR(255) NOT NULL,
    diagnosis VARCHAR(100) NOT NULL,
	
    CONSTRAINT fk_Pemeriksaan
    FOREIGN KEY (idRekam)
    REFERENCES Pemeriksaan (idRekam)
    ON DELETE CASCADE,
	CONSTRAINT fk_Obat
	FOREIGN KEY (idObat)
	REFERENCES Obat (idObat)
    ON DELETE CASCADE
);
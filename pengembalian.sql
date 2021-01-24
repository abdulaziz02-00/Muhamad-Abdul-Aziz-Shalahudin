-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Jan 2021 pada 22.45
-- Versi server: 10.4.17-MariaDB
-- Versi PHP: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bdperpus`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `pengembalian`
--

CREATE TABLE `pengembalian` (
  `Nomor_Kembali` varchar(6) NOT NULL,
  `Tanggal_Kembali` datetime NOT NULL,
  `Nomor_Buku` varchar(6) NOT NULL,
  `Judul` varchar(50) NOT NULL,
  `Total_Kembali` int(11) NOT NULL,
  `Denda` int(11) NOT NULL,
  `Nomor_Anggota` varchar(6) NOT NULL,
  `Nama_Anggota` varchar(50) NOT NULL,
  `Kode_Petugas` varchar(6) NOT NULL,
  `Nama_Petugas` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `pengembalian`
--

INSERT INTO `pengembalian` (`Nomor_Kembali`, `Tanggal_Kembali`, `Nomor_Buku`, `Judul`, `Total_Kembali`, `Denda`, `Nomor_Anggota`, `Nama_Anggota`, `Kode_Petugas`, `Nama_Petugas`) VALUES
('44441', '2021-01-31 11:46:40', '111112', 'Muhammad Al-Fatih', 2, 0, '000001', 'Maemunah', '222221', 'Eko'),
('444442', '2021-01-31 11:46:40', '111115', 'NDP HMI', 1, 5000, '000002', 'Subardjo', '222222', 'Salas'),
('444442', '2021-01-31 11:52:03', '111116', 'Islam Dokterin dan Peradaban', 1, 0, '000003', 'Sutrisno', '222223', 'Ahmad'),
('444444', '2021-01-31 11:52:03', '111114', 'Revolusi Pemuda', 1, 7000, '000004', 'Supriyatno', '222224', 'Adly');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

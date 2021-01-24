-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Jan 2021 pada 22.46
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
-- Struktur dari tabel `pengembaliandetail`
--

CREATE TABLE `pengembaliandetail` (
  `Nomor_Kembali` varchar(6) NOT NULL,
  `Judul` varchar(50) NOT NULL,
  `Nama_Anggota` varchar(50) NOT NULL,
  `Nama_Petugas` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `pengembaliandetail`
--

INSERT INTO `pengembaliandetail` (`Nomor_Kembali`, `Judul`, `Nama_Anggota`, `Nama_Petugas`) VALUES
('444441', 'Muhammad Al-Fatih', 'Maemunah', 'Eko'),
('444442', 'NDP HMI', 'Subardjo', 'Salas'),
('444442', 'Islam Dokterin dan Peradaban', 'Sutrisno', 'Ahmad'),
('444444', 'Revolusi Pemuda', 'Supriyatno', 'Adly');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

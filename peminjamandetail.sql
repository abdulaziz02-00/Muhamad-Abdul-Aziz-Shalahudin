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
-- Struktur dari tabel `peminjamandetail`
--

CREATE TABLE `peminjamandetail` (
  `Nomor_Pinjam` varchar(6) NOT NULL,
  `Judul` varchar(50) NOT NULL,
  `Nama_Anggota` varchar(50) NOT NULL,
  `Nama_Petugas` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `peminjamandetail`
--

INSERT INTO `peminjamandetail` (`Nomor_Pinjam`, `Judul`, `Nama_Anggota`, `Nama_Petugas`) VALUES
('333331', 'Muhammad Al-Fatih', 'Maemunah', 'Eko'),
('33332', 'NDP HMI', 'Subardjo', 'Salas'),
('333333', 'Islam Dokterin dan Peradaban', 'Sutrisno', 'Ahmad'),
('333334', 'Revolusi Pemuda', 'Supriyatno', 'Adly'),
('333331', 'Muhamad Al-Fatuh', 'Maemunah', 'Eko'),
('', '', '', ''),
('123', 'Muhamad Al-Fatih', 'Maemunah', 'Eko'),
('333331', 'Muhamad Al_Fatih', 'Maemunah', 'Eko');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

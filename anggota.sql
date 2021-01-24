-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Jan 2021 pada 22.44
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
-- Struktur dari tabel `anggota`
--

CREATE TABLE `anggota` (
  `Nomor_Anggota` varchar(6) NOT NULL,
  `Nama_Anggota` varchar(50) NOT NULL,
  `Alamat_Anggota` varchar(100) NOT NULL,
  `Telepon_Anggota` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `anggota`
--

INSERT INTO `anggota` (`Nomor_Anggota`, `Nama_Anggota`, `Alamat_Anggota`, `Telepon_Anggota`) VALUES
('000001', 'Maemunah', 'Tengah Tani, Cirebon', '082233334444'),
('000002', 'Subardjo', 'Panembahan, Cirebon', '082244445555'),
('000003', 'Sutrisno', 'Megu Cilik, Cirebon', '082255556666'),
('000004', 'Supriyatno', 'Sumber, Cirebon', '082266667777');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

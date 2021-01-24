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
-- Struktur dari tabel `buku`
--

CREATE TABLE `buku` (
  `Nomor_Buku` varchar(6) NOT NULL,
  `Judul` varchar(50) NOT NULL,
  `Kategori` varchar(30) NOT NULL,
  `Pengarang` varchar(50) NOT NULL,
  `Penerbit` varchar(50) NOT NULL,
  `Tahun` year(4) NOT NULL,
  `Stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `buku`
--

INSERT INTO `buku` (`Nomor_Buku`, `Judul`, `Kategori`, `Pengarang`, `Penerbit`, `Tahun`, `Stok`) VALUES
('111112', 'Muhammad Al-Fatih', 'Pengetahuan', 'Felix Siauw', 'Al-Fatih Press', 2013, 10),
('111113', '7 Keajaiban Rezeki', 'Pengetahuan', 'Ippho D. Santoso', 'Elex Media Komputindo', 2010, 15),
('111113', 'Argumentasi dan Narasi', 'Pengetahuan', 'Gorys Keraf', 'Gramedia', 2010, 20),
('111114', 'Revolusi Pemuda', 'Pengetahuan', 'Bennedict Anderson', 'Sinar Harapan', 2001, 25),
('111115', 'NDP HMI', 'Pengetahuan', 'Azhari Akmal Taringan', 'Simbiosa Rekatama Media', 2018, 50),
('111116', 'Islam Dokterin dan Peradaban', 'Pengetahuan', 'Nurcholish Madjid', 'Paramadina', 2002, 100);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

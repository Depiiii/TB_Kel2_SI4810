-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 25 Des 2024 pada 18.10
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.1.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `perpus`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `buku`
--

CREATE TABLE `buku` (
  `id_buku` int(11) NOT NULL,
  `nama_buku` varchar(100) NOT NULL,
  `pengarang` varchar(100) NOT NULL,
  `kategori` enum('fiksi','NonFiksi') NOT NULL,
  `foto` varchar(255) NOT NULL,
  `penerbit` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `buku`
--

INSERT INTO `buku` (`id_buku`, `nama_buku`, `pengarang`, `kategori`, `foto`, `penerbit`) VALUES
(42, 'judul', 'pengarang2', 'fiksi', 'D:\\codingan\\WindowsFormsLibraryApps\\WindowsFormsLibraryApps\\bin\\Debug\\Resources\\Images\\c5a64ef6-c0c9-446d-ab46-ed50f58d2b68.jpg', 'penerbit'),
(43, 'test', 'pengarang', 'NonFiksi', 'D:\\codingan\\WindowsFormsLibraryApps\\WindowsFormsLibraryApps\\bin\\Debug\\Resources\\Images\\14beb751-9083-48a7-a493-641b28938d9c.jpg', 'penerbit');

-- --------------------------------------------------------

--
-- Struktur dari tabel `peminjaman_buku`
--

CREATE TABLE `peminjaman_buku` (
  `id_peminjaman_buku` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `id_buku` int(11) NOT NULL,
  `tanggal_pinjam` date NOT NULL,
  `tanggal_kembali` date NOT NULL,
  `status` enum('Dipinjam','Kembali') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `peminjaman_buku`
--

INSERT INTO `peminjaman_buku` (`id_peminjaman_buku`, `id_user`, `id_buku`, `tanggal_pinjam`, `tanggal_kembali`, `status`) VALUES
(34, 18, 42, '2024-12-25', '2025-01-01', 'Kembali'),
(35, 18, 43, '2024-12-25', '2025-01-01', 'Kembali'),
(36, 1, 42, '2024-12-26', '2025-01-02', 'Kembali');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pengembalian_buku`
--

CREATE TABLE `pengembalian_buku` (
  `id_pengembalian_buku` int(11) NOT NULL,
  `id_peminjaman_buku` int(11) NOT NULL,
  `tanggal_pengembalian` date NOT NULL,
  `denda` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `pengembalian_buku`
--

INSERT INTO `pengembalian_buku` (`id_pengembalian_buku`, `id_peminjaman_buku`, `tanggal_pengembalian`, `denda`) VALUES
(20, 34, '2024-12-25', 0),
(21, 35, '2024-12-25', 0),
(22, 36, '2024-12-26', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `id_user` int(11) NOT NULL,
  `nama_user` varchar(100) NOT NULL,
  `gender` enum('perempuan','laki-laki') NOT NULL,
  `email` varchar(166) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` enum('pengunjung','admin') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`id_user`, `nama_user`, `gender`, `email`, `username`, `password`, `role`) VALUES
(1, 'depiii', 'perempuan', 'dvfttr1105@gmail.com', 'dpi', '123', 'pengunjung'),
(14, 'admin', 'perempuan', 'admin@gmail.com', 'admin', '123', 'admin'),
(18, 'user', 'laki-laki', 'dvftr51105@gmail.com', 'devi', '123', 'pengunjung');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `buku`
--
ALTER TABLE `buku`
  ADD PRIMARY KEY (`id_buku`);

--
-- Indeks untuk tabel `peminjaman_buku`
--
ALTER TABLE `peminjaman_buku`
  ADD PRIMARY KEY (`id_peminjaman_buku`),
  ADD KEY `id_siswa` (`id_user`),
  ADD KEY `id_buku` (`id_buku`);

--
-- Indeks untuk tabel `pengembalian_buku`
--
ALTER TABLE `pengembalian_buku`
  ADD PRIMARY KEY (`id_pengembalian_buku`),
  ADD KEY `id_peminjaman_buku` (`id_peminjaman_buku`),
  ADD KEY `denda` (`denda`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `buku`
--
ALTER TABLE `buku`
  MODIFY `id_buku` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;

--
-- AUTO_INCREMENT untuk tabel `peminjaman_buku`
--
ALTER TABLE `peminjaman_buku`
  MODIFY `id_peminjaman_buku` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT untuk tabel `pengembalian_buku`
--
ALTER TABLE `pengembalian_buku`
  MODIFY `id_pengembalian_buku` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT untuk tabel `user`
--
ALTER TABLE `user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `peminjaman_buku`
--
ALTER TABLE `peminjaman_buku`
  ADD CONSTRAINT `peminjaman_buku_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `user` (`id_user`),
  ADD CONSTRAINT `peminjaman_buku_ibfk_2` FOREIGN KEY (`id_buku`) REFERENCES `buku` (`id_buku`);

--
-- Ketidakleluasaan untuk tabel `pengembalian_buku`
--
ALTER TABLE `pengembalian_buku`
  ADD CONSTRAINT `pengembalian_buku_ibfk_1` FOREIGN KEY (`id_peminjaman_buku`) REFERENCES `peminjaman_buku` (`id_peminjaman_buku`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

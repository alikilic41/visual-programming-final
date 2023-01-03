-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 03 Oca 2023, 11:02:11
-- Sunucu sürümü: 8.0.28
-- PHP Sürümü: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `aleefastfood`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `admin`
--

CREATE TABLE `admin` (
  `adminid` int NOT NULL,
  `adminadi` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `adminpwd` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `admin`
--

INSERT INTO `admin` (`adminid`, `adminadi`, `adminpwd`) VALUES
(1, 'aliklc75', '4321');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

CREATE TABLE `kullanicilar` (
  `kullid` int NOT NULL,
  `kulladi` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `kullpwd` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `kulladres` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`kullid`, `kulladi`, `kullpwd`, `kulladres`) VALUES
(6, 'Ali', '123', 'Kütahya/Merkez Yıldırım Beyazıt Mahallesi'),
(21, 'nihat', '123', 'Kütahya/Merkez Gaybiefendi Mahallesi'),
(22, 'ismail', '123i', 'Kütahya/Merkez Alipaşa Mahallesi'),
(24, 'MuratSarı', '123', 'Kütahya/Merkez Vefa Mahallesi'),
(25, 'harun', '123456', NULL),
(27, 'emir', '2407', NULL);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `urunler`
--

CREATE TABLE `urunler` (
  `urunid` int NOT NULL,
  `urunadi` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `urunadedi` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `urunfiyati` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `urunler`
--

INSERT INTO `urunler` (`urunid`, `urunadi`, `urunadedi`, `urunfiyati`) VALUES
(1, 'Hamburger', '50', '45TL'),
(2, 'Patso', '50', '25TL'),
(3, 'Tavuk Dürüm', '50', '34TL'),
(4, 'İskender', '50', '55TL'),
(5, 'Ayran', '50', '5TL'),
(6, 'Pepsi', '50', '10TL'),
(7, 'Fanta', '50', '10TL');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`adminid`);

--
-- Tablo için indeksler `kullanicilar`
--
ALTER TABLE `kullanicilar`
  ADD PRIMARY KEY (`kullid`);

--
-- Tablo için indeksler `urunler`
--
ALTER TABLE `urunler`
  ADD PRIMARY KEY (`urunid`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `admin`
--
ALTER TABLE `admin`
  MODIFY `adminid` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `kullanicilar`
--
ALTER TABLE `kullanicilar`
  MODIFY `kullid` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- Tablo için AUTO_INCREMENT değeri `urunler`
--
ALTER TABLE `urunler`
  MODIFY `urunid` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

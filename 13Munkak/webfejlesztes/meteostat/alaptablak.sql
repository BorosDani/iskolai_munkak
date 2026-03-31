-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

-- --------------------------------------------------------

CREATE TABLE met_adat (
  aid int(11) NOT NULL,
  apid int(11) DEFAULT NULL,
  date date DEFAULT NULL,
  hour int(11) DEFAULT NULL,
  temp double DEFAULT NULL COMMENT 'The air temperature in °C',
  prcp double DEFAULT NULL COMMENT 'The one hour precipitation total in mm',
  wdir int(11) DEFAULT NULL COMMENT 'The wind direction in degrees (°)',
  wspd double DEFAULT NULL COMMENT 'The average wind speed in km/h',
  coco int(11) DEFAULT NULL COMMENT 'The weather condition code'
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

-- --------------------------------------------------------

CREATE TABLE met_cond (
  cid int(11) NOT NULL,
  ccond_en varchar(32) NOT NULL,
  ckond_hu varchar(32) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

INSERT INTO met_cond (cid, ccond_en, ckond_hu) VALUES
(1, 'Clear', 'derült'),
(2, 'Fair', 'szép'),
(3, 'Cloudy', 'felhős'),
(4, 'Overcast', 'borult'),
(5, 'Fog', 'köd'),
(6, 'Freezing Fog', 'fagyos köd'),
(7, 'Light Rain', 'gyenge eső'),
(8, 'Rain', 'eső'),
(9, 'Heavy Rain', 'intenzív eső'),
(10, 'Freezing Rain', 'ónos eső'),
(11, 'Heavy Freezing Rain', 'intenzív ónos eső'),
(12, 'Sleet', 'havas eső'),
(13, 'Heavy Sleet', 'intenzív havas eső'),
(14, 'Light Snowfall', 'gyenge hóesés'),
(15, 'Snowfall', 'hóesés'),
(16, 'Heavy Snowfall', 'intenzív hóesés'),
(17, 'Rain Shower', 'zápor'),
(18, 'Heavy Rain Shower', 'intenzív zápor'),
(19, 'Sleet Shower', 'havas zápor'),
(20, 'Heavy Sleet Shower', 'intenzív havas zápor'),
(21, 'Snow Shower', 'hózápor'),
(22, 'Heavy Snow Shower', 'intenzív hózápor'),
(23, 'Lightning', 'villámlás'),
(24, 'Hail', 'jégeső'),
(25, 'Thunderstorm', 'zivatar'),
(26, 'Heavy Thunderstorm', 'heves zivatar'),
(27, 'Storm', 'vihar');

-- --------------------------------------------------------

CREATE TABLE met_meropont (
  pid int(11) NOT NULL,
  pcode int(11) NOT NULL,
  phely varchar(16) NOT NULL,
  pgps varchar(32) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

INSERT INTO met_meropont (pid, pcode, phely, pgps) VALUES
(1, 12805, 'Sopron', ''),
(2, 12942, 'Pécs', ''),
(3, 12830, 'Veszprém', ''),
(4, 12843, 'Budapest', ''),
(5, 12772, 'Miskolc', ''),
(6, 12882, 'Debrecen', ''),
(7, 12982, 'Szeged', '');

ALTER TABLE met_adat
  ADD PRIMARY KEY (aid);

ALTER TABLE met_cond
  ADD PRIMARY KEY (cid);

ALTER TABLE met_meropont
  ADD PRIMARY KEY (pid);

ALTER TABLE met_adat
  MODIFY aid int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE met_cond
  MODIFY cid int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

ALTER TABLE met_meropont
  MODIFY pid int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

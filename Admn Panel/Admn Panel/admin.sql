-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 19, 2024 at 05:52 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `logindatabase`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` varchar(20) NOT NULL,
  `fullname` text NOT NULL,
  `address` varchar(20) NOT NULL,
  `password` varchar(10) NOT NULL,
  `confirmpassword` varchar(10) NOT NULL,
  `hiredate` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `fullname`, `address`, `password`, `confirmpassword`, `hiredate`) VALUES
('emp120', '0', 'sdehbft', '0', '0', '0000-00-00'),
('EMP001', 'Vishwanthi Saubaghya', 'Wadduwa', 'myhome123', 'myhome123', '0000-00-00'),
('EMP002', 'Dasun Bagya', 'Homaga', 'abcd12', 'abcd12', '0000-00-00'),
('EMP003', 'Thilini Rathnayaka', 'Dodangoda', 'thili22', 'thili22', '0000-00-00'),
('Cashier001', 'Kaveesha Diwyanjalee', 'Swanagala', 'kavi123', 'kavi123', '0000-00-00'),
('EMP006', 'Wasana', 'Panadura', 'abcd', 'abcd', '0000-00-00'),
('emp011', 'Sandun', 'Kalutara', 'zxcv', 'zxcv', '0000-00-00'),
('EMP011', 'Shakthi', 'Wavniya', 'vvvv', 'cccc', '0000-00-00'),
('EMP010', 'Mani', 'Kekirawa', 'acb123', 'abc123', '0000-00-00');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

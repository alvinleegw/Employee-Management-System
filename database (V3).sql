-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 01, 2022 at 06:25 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ems`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `adminid` int(1) NOT NULL,
  `username` varchar(5) NOT NULL,
  `password` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`adminid`, `username`, `password`) VALUES
(1, 'admin', '21232F297A57A5A743894A0E4A801FC3');

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `attendanceid` int(1) NOT NULL,
  `clockin` varchar(5) DEFAULT NULL,
  `clockout` varchar(5) DEFAULT NULL,
  `workinghours` decimal(4,2) DEFAULT NULL,
  `counter` int(1) DEFAULT 0,
  `date` varchar(10) DEFAULT NULL,
  `month` varchar(2) DEFAULT NULL,
  `year` varchar(4) NOT NULL,
  `employeeid` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`attendanceid`, `clockin`, `clockout`, `workinghours`, `counter`, `date`, `month`, `year`, `employeeid`) VALUES
(11, '11:29', '11:29', '10.00', 2, '11/30/2022', '11', '2022', 'IT001'),
(12, '11:29', '11:29', '20.00', 2, '12/30/2022', '12', '2023', 'IT001'),
(13, '09:52', '09:52', '30.50', 2, '12/27/2022', '12', '2022', 'IT001'),
(14, '09:54', '09:54', '0.00', 2, '12/27/2022', '12', '2022', 'ME001'),
(15, '07:31', '07:31', '0.00', 2, '12/1/2022', '12', '2022', 'IT001'),
(16, '07:41', '07:42', '0.02', 2, '12/2/2022', '12', '2022', 'IT001'),
(17, '07:30', '17:30', '10.00', 2, '11/1/2022', '11', '2022', 'IT001'),
(18, '12:42', '12:42', '0.00', 2, '12/5/2022', '12', '2022', 'IT001');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `employeeid` varchar(5) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(32) NOT NULL,
  `name` varchar(50) NOT NULL,
  `position` varchar(30) NOT NULL,
  `email` varchar(50) NOT NULL,
  `department` varchar(25) NOT NULL,
  `hourlyrate` int(2) NOT NULL,
  `adminid` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`employeeid`, `username`, `password`, `name`, `position`, `email`, `department`, `hourlyrate`, `adminid`) VALUES
('IT001', 'alvinleegw', 'E3966108CD0BD2E11817487A1AA9538B', 'ALVIN LEE GUO WEI', 'INDUSTRIAL TRAINEE', 'alvinleegw@hotmail.com', 'IT', 15, 1),
('ME001', 'yeekeong', 'B491E0C88EED89813356EE35F220FC39', 'TEH YEE KEONG', 'INDUSTRIAL TRAINEE', 'yeekeong@gmail.com', 'Engineering', 20, 1);

-- --------------------------------------------------------

--
-- Table structure for table `payslip`
--

CREATE TABLE `payslip` (
  `payslipno` int(8) NOT NULL,
  `payslipid` varchar(16) DEFAULT NULL,
  `totalworkinghours` decimal(5,2) NOT NULL,
  `totalworkingdays` int(2) NOT NULL,
  `salary` decimal(12,2) NOT NULL,
  `dateissued` varchar(10) NOT NULL,
  `month` varchar(2) NOT NULL,
  `year` varchar(4) NOT NULL,
  `employeeid` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `payslip`
--

INSERT INTO `payslip` (`payslipno`, `payslipid`, `totalworkinghours`, `totalworkingdays`, `salary`, `dateissued`, `month`, `year`, `employeeid`) VALUES
(15, 'PS20221100000015', '10.00', 1, '150.00', '11/30/2022', '11', '2022', 'IT001'),
(17, 'PS20221200000017', '30.52', 4, '457.80', '12/31/2022', '12', '2022', 'IT001');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`adminid`);

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`attendanceid`),
  ADD KEY `employeeid` (`employeeid`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`employeeid`),
  ADD KEY `adminid` (`adminid`);

--
-- Indexes for table `payslip`
--
ALTER TABLE `payslip`
  ADD PRIMARY KEY (`payslipno`),
  ADD UNIQUE KEY `payslipid` (`payslipid`),
  ADD KEY `employeeid` (`employeeid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `attendanceid` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `payslip`
--
ALTER TABLE `payslip`
  MODIFY `payslipno` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`employeeid`) REFERENCES `employee` (`employeeid`);

--
-- Constraints for table `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`adminid`) REFERENCES `admin` (`adminid`);

--
-- Constraints for table `payslip`
--
ALTER TABLE `payslip`
  ADD CONSTRAINT `payslip_ibfk_1` FOREIGN KEY (`employeeid`) REFERENCES `employee` (`employeeid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

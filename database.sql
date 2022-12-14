DROP DATABASE IF EXISTS EMS;
CREATE DATABASE IF NOT EXISTS EMS;
USE EMS;

-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 13, 2022 at 11:52 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`adminid`, `username`, `password`) VALUES
(1, 'admin', '21232F297A57A5A743894A0E4A801FC3');

-- --------------------------------------------------------

--
-- Table structure for table `archive`
--

CREATE TABLE `archive` (
  `archiveid` varchar(5) NOT NULL,
  `portrait` mediumblob NOT NULL,
  `name` varchar(37) NOT NULL,
  `ic` varchar(12) NOT NULL,
  `dateofbirth` varchar(10) NOT NULL,
  `age` int(3) NOT NULL,
  `mobileno` varchar(12) NOT NULL,
  `email` varchar(30) NOT NULL,
  `addressline1` varchar(30) NOT NULL,
  `addressline2` varchar(30) NOT NULL,
  `addressline3` varchar(30) DEFAULT NULL,
  `postcode` varchar(5) NOT NULL,
  `district` varchar(25) NOT NULL,
  `state` varchar(15) NOT NULL,
  `datejoined` varchar(10) NOT NULL,
  `dateleft` varchar(10) NOT NULL,
  `position` varchar(30) NOT NULL,
  `department` varchar(30) NOT NULL,
  `hourlyrate` int(4) NOT NULL,
  `adminid` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `attendanceid` int(1) NOT NULL,
  `clockin` varchar(5) DEFAULT NULL,
  `clockout` varchar(5) DEFAULT NULL,
  `workinghours` decimal(3,2) DEFAULT NULL,
  `counter` int(1) DEFAULT 0,
  `date` varchar(10) DEFAULT NULL,
  `month` varchar(2) DEFAULT NULL,
  `year` varchar(4) NOT NULL,
  `employeeid` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `departmentinfo`
--

CREATE TABLE `departmentinfo` (
  `departmentcode` varchar(2) NOT NULL,
  `departmentname` varchar(30) NOT NULL,
  `counter` int(3) NOT NULL DEFAULT 1,
  `adminid` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `employeeid` varchar(5) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(32) NOT NULL,
  `portrait` mediumblob NOT NULL,
  `name` varchar(37) NOT NULL,
  `ic` varchar(12) NOT NULL,
  `dateofbirth` varchar(10) NOT NULL,
  `age` int(3) NOT NULL,
  `mobileno` varchar(12) NOT NULL,
  `email` varchar(30) NOT NULL,
  `addressline1` varchar(30) NOT NULL,
  `addressline2` varchar(30) NOT NULL,
  `addressline3` varchar(30) DEFAULT NULL,
  `postcode` varchar(5) NOT NULL,
  `district` varchar(25) NOT NULL,
  `state` varchar(15) NOT NULL,
  `datejoined` varchar(10) NOT NULL,
  `position` varchar(30) NOT NULL,
  `department` varchar(30) NOT NULL,
  `hourlyrate` int(4) NOT NULL,
  `adminid` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `payslip`
--

CREATE TABLE `payslip` (
  `payslipno` int(8) NOT NULL,
  `payslipid` varchar(16) DEFAULT NULL,
  `totalworkinghours` decimal(5,2) NOT NULL,
  `totalworkingdays` int(2) NOT NULL,
  `salary` decimal(8,2) NOT NULL,
  `dateissued` varchar(10) NOT NULL,
  `month` varchar(2) NOT NULL,
  `year` varchar(4) NOT NULL,
  `employeeid` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `positioninfo`
--

CREATE TABLE `positioninfo` (
  `positionname` varchar(30) NOT NULL,
  `adminid` int(1) NOT NULL DEFAULT 1,
  `departmentcode` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`adminid`);

--
-- Indexes for table `archive`
--
ALTER TABLE `archive`
  ADD KEY `adminid` (`adminid`);

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`attendanceid`),
  ADD KEY `employeeid` (`employeeid`);

--
-- Indexes for table `departmentinfo`
--
ALTER TABLE `departmentinfo`
  ADD PRIMARY KEY (`departmentcode`),
  ADD KEY `adminid` (`adminid`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`employeeid`),
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `email` (`email`),
  ADD UNIQUE KEY `ic` (`ic`),
  ADD UNIQUE KEY `mobileno` (`mobileno`),
  ADD KEY `adminid` (`adminid`);

--
-- Indexes for table `payslip`
--
ALTER TABLE `payslip`
  ADD PRIMARY KEY (`payslipno`),
  ADD UNIQUE KEY `payslipid` (`payslipid`),
  ADD KEY `employeeid` (`employeeid`);

--
-- Indexes for table `positioninfo`
--
ALTER TABLE `positioninfo`
  ADD PRIMARY KEY (`positionname`),
  ADD KEY `adminid` (`adminid`),
  ADD KEY `departmentname` (`departmentcode`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `attendanceid` int(1) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `payslip`
--
ALTER TABLE `payslip`
  MODIFY `payslipno` int(8) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `archive`
--
ALTER TABLE `archive`
  ADD CONSTRAINT `archive_ibfk_1` FOREIGN KEY (`adminid`) REFERENCES `admin` (`adminid`);

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`employeeid`) REFERENCES `employee` (`employeeid`) ON DELETE CASCADE;

--
-- Constraints for table `departmentinfo`
--
ALTER TABLE `departmentinfo`
  ADD CONSTRAINT `departmentinfo_ibfk_1` FOREIGN KEY (`adminid`) REFERENCES `admin` (`adminid`);

--
-- Constraints for table `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`adminid`) REFERENCES `admin` (`adminid`) ON DELETE CASCADE;

--
-- Constraints for table `payslip`
--
ALTER TABLE `payslip`
  ADD CONSTRAINT `payslip_ibfk_1` FOREIGN KEY (`employeeid`) REFERENCES `employee` (`employeeid`) ON DELETE CASCADE;

--
-- Constraints for table `positioninfo`
--
ALTER TABLE `positioninfo`
  ADD CONSTRAINT `positioninfo_ibfk_1` FOREIGN KEY (`adminid`) REFERENCES `admin` (`adminid`),
  ADD CONSTRAINT `positioninfo_ibfk_2` FOREIGN KEY (`departmentcode`) REFERENCES `departmentinfo` (`departmentcode`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

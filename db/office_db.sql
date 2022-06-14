-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 14, 2022 at 06:15 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.0.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `office_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `Customer_ID` varchar(20) NOT NULL,
  `Customer_Name` varchar(50) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Email` varchar(15) NOT NULL,
  `Phone` varchar(15) NOT NULL,
  `Customer_Image` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `Employee_ID` varchar(20) NOT NULL,
  `Employee_Name` varchar(20) NOT NULL,
  `Employee_Phone` int(10) NOT NULL,
  `Employee_Email` varchar(30) NOT NULL,
  `Employee_Address` varchar(50) NOT NULL,
  `Emp_Img` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `import_details`
--

CREATE TABLE `import_details` (
  `Import_No` int(11) NOT NULL,
  `Order_ID` varchar(20) NOT NULL,
  `Product_ID` varchar(20) NOT NULL,
  `Product_Name` varchar(30) NOT NULL,
  `Original_Price` double NOT NULL,
  `Amount` int(5) NOT NULL,
  `Total_Price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `order_imports`
--

CREATE TABLE `order_imports` (
  `Order_ID` varchar(20) NOT NULL,
  `Supplier_Name` varchar(20) NOT NULL,
  `Import_Date` date NOT NULL,
  `Total` double NOT NULL,
  `Checked` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `Product_ID` varchar(20) NOT NULL,
  `Product_Name` varchar(30) NOT NULL,
  `Product_Type_Name` varchar(20) NOT NULL,
  `Product_Brand` varchar(20) NOT NULL,
  `Size` varchar(10) NOT NULL,
  `Quantity` int(5) NOT NULL DEFAULT 0,
  `Original_Price` double NOT NULL,
  `Selling_Price` double NOT NULL,
  `Production_Date` varchar(30) NOT NULL,
  `Expiration_Date` varchar(30) NOT NULL,
  `Product_Img` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `product_types`
--

CREATE TABLE `product_types` (
  `Product_Type_ID` int(11) NOT NULL,
  `Product_Type_Name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `sale`
--

CREATE TABLE `sale` (
  `Sale_ID` varchar(20) NOT NULL,
  `Customer_Name` varchar(30) NOT NULL,
  `Total` double NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `sale_details`
--

CREATE TABLE `sale_details` (
  `Sale_No` int(11) NOT NULL,
  `Sale_ID` varchar(20) NOT NULL,
  `Product_ID` varchar(30) NOT NULL,
  `Product_Name` varchar(30) NOT NULL,
  `Price` double NOT NULL,
  `Amount` int(5) NOT NULL,
  `Product_Total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `Supplier_ID` varchar(10) NOT NULL,
  `Supplier_Name` varchar(30) NOT NULL,
  `Supplier_Address` varchar(100) NOT NULL,
  `Supplier_Email` varchar(30) NOT NULL,
  `Supplier_Tel` varchar(15) NOT NULL,
  `Supplier_Img` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`Customer_ID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`Employee_ID`);

--
-- Indexes for table `import_details`
--
ALTER TABLE `import_details`
  ADD PRIMARY KEY (`Import_No`);

--
-- Indexes for table `order_imports`
--
ALTER TABLE `order_imports`
  ADD PRIMARY KEY (`Order_ID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`Product_ID`);

--
-- Indexes for table `product_types`
--
ALTER TABLE `product_types`
  ADD PRIMARY KEY (`Product_Type_ID`);

--
-- Indexes for table `sale`
--
ALTER TABLE `sale`
  ADD PRIMARY KEY (`Sale_ID`);

--
-- Indexes for table `sale_details`
--
ALTER TABLE `sale_details`
  ADD PRIMARY KEY (`Sale_No`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`Supplier_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `import_details`
--
ALTER TABLE `import_details`
  MODIFY `Import_No` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `product_types`
--
ALTER TABLE `product_types`
  MODIFY `Product_Type_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `sale_details`
--
ALTER TABLE `sale_details`
  MODIFY `Sale_No` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

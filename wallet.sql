-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Lip 08, 2023 at 12:54 PM
-- Wersja serwera: 10.4.28-MariaDB
-- Wersja PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `wallet`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `category`
--

CREATE TABLE `category` (
  `ID` int(11) NOT NULL COMMENT 'Row ID',
  `UserID` int(11) DEFAULT NULL COMMENT 'The category that belongs to the user',
  `Type` varchar(32) NOT NULL COMMENT 'short name',
  `Positiv` tinyint(1) DEFAULT NULL COMMENT 'Whether the category is positive or negative,\r\nIncome => 1, Expenses => 0',
  `Comment` longtext DEFAULT NULL COMMENT 'Row comment'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`ID`, `UserID`, `Type`, `Positiv`, `Comment`) VALUES
(3, 10, 'podroze', NULL, NULL),
(4, 11, 'PODRÓŻE', NULL, NULL),
(5, 11, 'Wydatki', NULL, NULL);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `goal`
--

CREATE TABLE `goal` (
  `ID` int(11) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `UserGoal` varchar(32) NOT NULL,
  `description` mediumtext DEFAULT NULL,
  `Comment` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `Username` varchar(32) NOT NULL,
  `Password` longtext NOT NULL,
  `Date` timestamp NOT NULL DEFAULT current_timestamp(),
  `Comment` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `Username`, `Password`, `Date`, `Comment`) VALUES
(7, 'Eryk', 'MTIzNDU=', '2023-01-14 14:28:27', ''),
(8, '1', 'NJrhSyTSPMpQ+4PYT7YDn4gqNkU=', '2023-05-27 12:08:29', ''),
(9, '2', 'vVRJybuQ55w+PWfrT5hmbl3xGNw=', '2023-05-27 13:39:08', ''),
(10, '5', 'GGJ3TZWxHkpkTtqHGdnCff9IXpg=', '2023-05-27 14:08:33', ''),
(11, 'AST', '/F9Cy0ClM1jx4q20Dcd1AFrfTtI=', '2023-07-08 10:48:19', '');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `usersdata`
--

CREATE TABLE `usersdata` (
  `ID` int(11) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `CategoryID` int(11) DEFAULT NULL,
  `GoalID` int(11) DEFAULT NULL,
  `Amount` double NOT NULL,
  `CreationTime` timestamp NOT NULL DEFAULT current_timestamp(),
  `LastModyfieTime` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `Comment` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `usersdata`
--

INSERT INTO `usersdata` (`ID`, `UserID`, `CategoryID`, `GoalID`, `Amount`, `CreationTime`, `LastModyfieTime`, `Comment`) VALUES
(2, 9, -15, NULL, 1000, '2023-05-27 13:48:52', '2023-05-27 13:48:52', 'hwdp'),
(3, 9, -15, NULL, 656, '2023-05-27 13:49:04', '2023-05-27 13:49:04', 'xd'),
(4, 9, 1, NULL, -15, '2023-05-27 13:49:30', '2023-05-27 13:49:30', '15'),
(5, 9, -15, NULL, 151515, '2023-05-27 13:49:39', '2023-05-27 13:49:39', '151515'),
(6, 9, 2, NULL, -15, '2023-05-27 13:55:57', '2023-05-27 13:55:57', 'Jebanie'),
(7, 9, -15, NULL, -200, '2023-05-27 13:56:30', '2023-05-27 13:56:30', 'cos'),
(8, 10, -15, NULL, 4000, '2023-05-27 14:08:51', '2023-05-27 14:08:51', 'pensja'),
(9, 10, 3, NULL, -400, '2023-05-27 14:09:31', '2023-05-27 14:09:31', 'paliwo'),
(10, 11, 4, NULL, -0, '2023-07-08 10:49:25', '2023-07-08 10:49:25', 'Jedzenie'),
(11, 11, 5, NULL, -250, '2023-07-08 10:52:53', '2023-07-08 10:52:53', 'KFC');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indeksy dla tabeli `goal`
--
ALTER TABLE `goal`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `UserID` (`UserID`);

--
-- Indeksy dla tabeli `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`);

--
-- Indeksy dla tabeli `usersdata`
--
ALTER TABLE `usersdata`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `CategoryID` (`CategoryID`,`GoalID`),
  ADD KEY `GoalID` (`GoalID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Row ID', AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `goal`
--
ALTER TABLE `goal`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `usersdata`
--
ALTER TABLE `usersdata`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

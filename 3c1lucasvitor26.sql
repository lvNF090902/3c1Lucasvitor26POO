-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 20-Nov-2021 às 19:42
-- Versão do servidor: 5.7.31
-- versão do PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `3c1lucasvitor26`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadastrarprodutos`
--

DROP TABLE IF EXISTS `cadastrarprodutos`;
CREATE TABLE IF NOT EXISTS `cadastrarprodutos` (
  `Nome` varchar(45) NOT NULL,
  `Preco` double NOT NULL,
  `Codg_barras` int(11) NOT NULL,
  `Quantidade` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cad_login`
--

DROP TABLE IF EXISTS `cad_login`;
CREATE TABLE IF NOT EXISTS `cad_login` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `senha` varchar(45) NOT NULL,
  `login` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

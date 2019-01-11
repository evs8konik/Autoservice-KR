-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Январь 03 2019 г., 20:05
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `autoservis`
--

-- --------------------------------------------------------

--
-- Структура таблицы `auto`
--

CREATE TABLE IF NOT EXISTS `auto` (
  `auto_id` int(11) NOT NULL AUTO_INCREMENT,
  `marka` varchar(255) NOT NULL,
  `probeg` int(11) NOT NULL,
  `color` varchar(255) NOT NULL,
  `client_id` int(11) NOT NULL,
  PRIMARY KEY (`auto_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Дамп данных таблицы `auto`
--

INSERT INTO `auto` (`auto_id`, `marka`, `probeg`, `color`, `client_id`) VALUES
(1, 'БМВ', 32445, 'Красный', 1),
(2, 'Mitsubishi', 4656, 'Черный', 1),
(3, 'Рено', 5466, 'Белый', 2),
(4, 'Форд', 4566, 'Синий', 2),
(5, 'Лада', 43545, 'Серебристый', 3),
(6, 'Шкода', 5465, 'Зеленый', 4);

-- --------------------------------------------------------

--
-- Структура таблицы `clients`
--

CREATE TABLE IF NOT EXISTS `clients` (
  `client_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(20) NOT NULL,
  `fam` varchar(20) NOT NULL,
  `otch` varchar(20) NOT NULL,
  `seria` int(4) NOT NULL,
  `nomer` int(6) NOT NULL,
  PRIMARY KEY (`client_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Дамп данных таблицы `clients`
--

INSERT INTO `clients` (`client_id`, `name`, `fam`, `otch`, `seria`, `nomer`) VALUES
(1, 'Сергей', 'Иванов', 'Васильевич', 7906, 345465),
(2, 'Иван', 'Петров', 'Сергеевич', 6787, 564545),
(3, 'Анастасия', 'Макарова', 'Валерьевна', 6784, 568745),
(4, 'Марина', 'Андреева', 'Петровна', 7945, 346798);

-- --------------------------------------------------------

--
-- Структура таблицы `dealind`
--

CREATE TABLE IF NOT EXISTS `dealind` (
  `dealind_id` int(11) NOT NULL,
  `goods` int(11) NOT NULL,
  `client_id` int(11) NOT NULL,
  `date_buy` date NOT NULL,
  PRIMARY KEY (`dealind_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `goods`
--

CREATE TABLE IF NOT EXISTS `goods` (
  `goods_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `price` int(11) NOT NULL,
  `status` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`goods_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Структура таблицы `register`
--

CREATE TABLE IF NOT EXISTS `register` (
  `register_id` int(11) NOT NULL AUTO_INCREMENT,
  `client_id` int(11) NOT NULL,
  `register_date` datetime NOT NULL,
  PRIMARY KEY (`register_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Структура таблицы `remont`
--

CREATE TABLE IF NOT EXISTS `remont` (
  `remont_id` int(11) NOT NULL AUTO_INCREMENT,
  `price` int(11) NOT NULL,
  `auto_id` int(11) NOT NULL,
  `breaking` varchar(255) NOT NULL,
  `date_in` date NOT NULL,
  `date_out` date NOT NULL,
  PRIMARY KEY (`remont_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=13 ;

--
-- Дамп данных таблицы `remont`
--

INSERT INTO `remont` (`remont_id`, `price`, `auto_id`, `breaking`, `date_in`, `date_out`) VALUES
(6, 1500, 1, 'Поломка фары', '2018-04-02', '2018-04-26'),
(7, 2345, 1, 'Смена покрышки', '2018-04-02', '2018-04-30'),
(8, 5645, 2, 'Замена масла', '2018-04-15', '2018-04-18'),
(9, 4565, 3, 'Замена дисков', '2018-04-17', '2018-04-30'),
(10, 4566, 4, 'Выпрямление двери', '2018-04-04', '2018-04-24'),
(11, 4566, 5, 'Выпрямление капота', '2018-04-14', '2018-04-18'),
(12, 5677, 6, 'Ремонт двигателя', '2018-04-15', '2018-04-26');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

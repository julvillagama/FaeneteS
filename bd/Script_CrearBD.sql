
-- Base de datos: `faenetesDB`

-- Crea la Base de datos
CREATE DATABASE IF NOT EXISTS `faenetesDB` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `faenetesDB`;

-- Tabla `academia`
CREATE TABLE IF NOT EXISTS `academia` (
`_id` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `preparador` varchar(50) DEFAULT NULL,
  `opositor` varchar(100) DEFAULT NULL,
  `material` varchar(30) DEFAULT NULL,
   PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Tabla `actos`
CREATE TABLE IF NOT EXISTS `actos` (
`_id` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `acto` varchar(100) DEFAULT NULL,
  `lugar` varchar(100) DEFAULT NULL,
  `empresaCatering` varchar(50) DEFAULT NULL,
  `nombreMenu` varchar(50) DEFAULT NULL,
  `precioPersona` float DEFAULT NULL,
  `observaciones` varchar(200) DEFAULT NULL,
   PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Tabla `configuracion`
CREATE TABLE IF NOT EXISTS `configuracion` (
`_id` int(11) NOT NULL AUTO_INCREMENT,
  `registro` varchar(100) DEFAULT NULL,
  `trabajador` varchar(50) DEFAULT NULL,
  `via` varchar(30) DEFAULT NULL,
  `preparador` varchar(50) DEFAULT NULL,
   PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Tabla `consultas`
CREATE TABLE IF NOT EXISTS `consultas` (
`_id` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `consulta` varchar(100) DEFAULT NULL,
  `via` varchar(30) DEFAULT NULL,
  `respuesta` varchar(30) DEFAULT NULL,
   PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Tabla `correo`
CREATE TABLE IF NOT EXISTS `correo` (
`_id` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `darEntrada` tinyint(1) DEFAULT NULL,
  `darSalida` tinyint(1) DEFAULT NULL,
  `certificado` tinyint(1) DEFAULT NULL,
  `nombreRemite` varchar(50) DEFAULT NULL,
  `contenido` varchar(50) DEFAULT NULL,
  `destino` varchar(50) DEFAULT NULL,
  `personaSeguimiento` varchar(50) DEFAULT NULL,
  `estadoGestion` varchar(50) DEFAULT NULL,
  `finalizado` tinyint(1) DEFAULT NULL,
   PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Tabla `llamadas`
CREATE TABLE IF NOT EXISTS `llamadas` (
`_id` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `consulta` varchar(100) DEFAULT NULL,
   PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Tabla `quejas`
CREATE TABLE IF NOT EXISTS `quejas` (
`_id` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `queja` varchar(500) DEFAULT NULL,
  `registro` varchar(50) DEFAULT NULL,
  `resolucion` varchar(500) DEFAULT NULL,
   PRIMARY KEY (`_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
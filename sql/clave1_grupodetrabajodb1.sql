-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: clave1_grupodetrabajodb1
-- ------------------------------------------------------
-- Server version	8.0.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cirugia`
--

DROP TABLE IF EXISTS `cirugia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cirugia` (
  `idcirugia` int NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(100) NOT NULL,
  `Descripcion` longtext,
  `Motivo` varchar(255) DEFAULT NULL,
  `Materiales` longtext,
  `idExpediente` int NOT NULL,
  `idMascota` int NOT NULL,
  PRIMARY KEY (`idcirugia`),
  KEY `idExpediente_cirugia` (`idExpediente`),
  KEY `idMascota_cirugia` (`idMascota`),
  CONSTRAINT `idExpediente_cirugia` FOREIGN KEY (`idExpediente`) REFERENCES `expedientes` (`idExpedientes`),
  CONSTRAINT `idMascota_cirugia` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cirugia`
--

LOCK TABLES `cirugia` WRITE;
/*!40000 ALTER TABLE `cirugia` DISABLE KEYS */;
/*!40000 ALTER TABLE `cirugia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `citas`
--

DROP TABLE IF EXISTS `citas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `citas` (
  `idCita` int NOT NULL AUTO_INCREMENT,
  `FechaHora` datetime NOT NULL,
  `Motivo` varchar(255) NOT NULL,
  `Estado` enum('Programada','Cancelada','Reprogramada') NOT NULL,
  `idUsuarios` int NOT NULL,
  `idMascota` int NOT NULL,
  PRIMARY KEY (`idCita`),
  KEY `idUsuario_Citas_idx` (`idUsuarios`),
  KEY `idMascota_Citas` (`idMascota`),
  CONSTRAINT `idMascota_Citas` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`),
  CONSTRAINT `idUsuario_Citas` FOREIGN KEY (`idUsuarios`) REFERENCES `usuarios` (`idUsuarios`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `citas`
--

LOCK TABLES `citas` WRITE;
/*!40000 ALTER TABLE `citas` DISABLE KEYS */;
/*!40000 ALTER TABLE `citas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consultas`
--

DROP TABLE IF EXISTS `consultas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consultas` (
  `idConsulta` int NOT NULL AUTO_INCREMENT,
  `FechaHora` datetime NOT NULL,
  `Peso` decimal(5,2) NOT NULL,
  `Motivo` varchar(255) DEFAULT NULL,
  `Sintomas` varchar(255) DEFAULT NULL,
  `ExamenFisico` varchar(1000) DEFAULT NULL,
  `Diagnostico` varchar(1000) DEFAULT NULL,
  `Tratamiento` varchar(1000) DEFAULT NULL,
  `Medicamentos` varchar(100) DEFAULT NULL,
  `Notas` varchar(1000) DEFAULT NULL,
  `idMascota` int NOT NULL,
  `idExpediente` int NOT NULL,
  PRIMARY KEY (`idConsulta`),
  KEY `idExpediente_idx` (`idExpediente`),
  KEY `idMascota_Consulta_idx` (`idMascota`),
  CONSTRAINT `idExpediente` FOREIGN KEY (`idExpediente`) REFERENCES `expedientes` (`idExpedientes`),
  CONSTRAINT `idMascota_Consulta` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultas`
--

LOCK TABLES `consultas` WRITE;
/*!40000 ALTER TABLE `consultas` DISABLE KEYS */;
/*!40000 ALTER TABLE `consultas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `examen`
--

DROP TABLE IF EXISTS `examen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `examen` (
  `idexamen` int NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(100) NOT NULL,
  `Descripcion` longtext,
  `Motivo` varchar(255) DEFAULT NULL,
  `Materiales` mediumtext,
  `idExpediente` int NOT NULL,
  `idMascota` int NOT NULL,
  PRIMARY KEY (`idexamen`),
  KEY `idExpedientes` (`idExpediente`),
  KEY `fk_idMascota_nuevo` (`idMascota`),
  CONSTRAINT `fk_idExpedientes` FOREIGN KEY (`idExpediente`) REFERENCES `expedientes` (`idExpedientes`),
  CONSTRAINT `fk_idMascota_nuevo` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `examen`
--

LOCK TABLES `examen` WRITE;
/*!40000 ALTER TABLE `examen` DISABLE KEYS */;
/*!40000 ALTER TABLE `examen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `expedientes`
--

DROP TABLE IF EXISTS `expedientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `expedientes` (
  `idExpedientes` int NOT NULL AUTO_INCREMENT,
  `idMascota` int NOT NULL,
  `idUsuarios` int NOT NULL,
  `idCita` int NOT NULL,
  `idConsulta` int NOT NULL,
  `idVacuna` int NOT NULL,
  `idExamen` int NOT NULL,
  `idCirugia` int NOT NULL,
  PRIMARY KEY (`idExpedientes`),
  KEY `idMascota_idx` (`idMascota`),
  KEY `idCita_idx` (`idCita`),
  KEY `idUsuarios_idx` (`idUsuarios`),
  KEY `idConsulta_idx` (`idConsulta`),
  KEY `idExamen_idx` (`idExamen`),
  KEY `idCirugia_idx` (`idCirugia`),
  KEY `idVacuna_idx` (`idVacuna`),
  CONSTRAINT `fk_expedientes_idCita` FOREIGN KEY (`idCita`) REFERENCES `citas` (`idCita`),
  CONSTRAINT `fk_expedientes_idConsulta` FOREIGN KEY (`idConsulta`) REFERENCES `consultas` (`idConsulta`),
  CONSTRAINT `fk_expedientes_idUsuarios` FOREIGN KEY (`idUsuarios`) REFERENCES `usuarios` (`idUsuarios`),
  CONSTRAINT `fk_idMascota` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`),
  CONSTRAINT `idCirugia` FOREIGN KEY (`idCirugia`) REFERENCES `cirugia` (`idcirugia`),
  CONSTRAINT `idExamen` FOREIGN KEY (`idExamen`) REFERENCES `examen` (`idexamen`),
  CONSTRAINT `idVacuna` FOREIGN KEY (`idVacuna`) REFERENCES `vacuna` (`idVacuna`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `expedientes`
--

LOCK TABLES `expedientes` WRITE;
/*!40000 ALTER TABLE `expedientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `expedientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mascotas`
--

DROP TABLE IF EXISTS `mascotas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mascotas` (
  `idMascota` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Edad` int NOT NULL,
  `Especie` varchar(50) NOT NULL,
  `Raza` varchar(50) NOT NULL,
  `Sexo` varchar(45) NOT NULL,
  `idExpedientes` int NOT NULL,
  `idUsuarios` int NOT NULL,
  PRIMARY KEY (`idMascota`),
  KEY `idExpedientes_idx` (`idExpedientes`),
  KEY `idUsuarios_idx` (`idUsuarios`),
  CONSTRAINT `idExpedientes` FOREIGN KEY (`idExpedientes`) REFERENCES `expedientes` (`idExpedientes`),
  CONSTRAINT `idUsuarios` FOREIGN KEY (`idUsuarios`) REFERENCES `usuarios` (`idUsuarios`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mascotas`
--

LOCK TABLES `mascotas` WRITE;
/*!40000 ALTER TABLE `mascotas` DISABLE KEYS */;
/*!40000 ALTER TABLE `mascotas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagos`
--

DROP TABLE IF EXISTS `pagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pagos` (
  `idPago` int NOT NULL AUTO_INCREMENT,
  `Estado` varchar(45) NOT NULL,
  `PrecioServicios` decimal(10,2) NOT NULL,
  `PrecioProductos` decimal(10,2) NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  `TipoPago` enum('Efectivo','Bitcoin','Tarjeta') NOT NULL,
  `CantidadEfectivo` decimal(10,2) DEFAULT NULL,
  `InformacionTarjeta` varchar(100) DEFAULT NULL,
  `DUI` varchar(10) DEFAULT NULL,
  `idUsuarios` int NOT NULL,
  `IdExpediente` int NOT NULL,
  PRIMARY KEY (`idPago`),
  KEY `idUsuarios_ipagos` (`idUsuarios`),
  KEY `idExpedientes_Pagos_idx` (`IdExpediente`),
  CONSTRAINT `idExpedientes_Pagos` FOREIGN KEY (`IdExpediente`) REFERENCES `expedientes` (`idExpedientes`),
  CONSTRAINT `idUsuarios_pagos` FOREIGN KEY (`idUsuarios`) REFERENCES `usuarios` (`idUsuarios`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagos`
--

LOCK TABLES `pagos` WRITE;
/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
/*!40000 ALTER TABLE `pagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `idProductos` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Precio` decimal(10,2) NOT NULL,
  `Descripcion` varchar(255) DEFAULT NULL,
  `Cantidad` int NOT NULL,
  PRIMARY KEY (`idProductos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicios`
--

DROP TABLE IF EXISTS `servicios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `servicios` (
  `idServicios` int NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(255) NOT NULL,
  `Precio` decimal(10,2) NOT NULL,
  `Descripcion` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idServicios`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicios`
--

LOCK TABLES `servicios` WRITE;
/*!40000 ALTER TABLE `servicios` DISABLE KEYS */;
/*!40000 ALTER TABLE `servicios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `idUsuarios` int NOT NULL AUTO_INCREMENT,
  `NombreUsuario` varchar(100) NOT NULL,
  `Telefono` varchar(15) NOT NULL,
  `correo` varchar(100) NOT NULL,
  `Direccion` varchar(255) NOT NULL,
  `Rol` enum('Administrador','Veterinario','Dueno') NOT NULL,
  PRIMARY KEY (`idUsuarios`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vacuna`
--

DROP TABLE IF EXISTS `vacuna`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vacuna` (
  `idVacuna` int NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(100) NOT NULL,
  `Descripcion` longtext,
  `Motivo` varchar(255) DEFAULT NULL,
  `idMascota` int NOT NULL,
  `idExpedientes` int NOT NULL,
  PRIMARY KEY (`idVacuna`),
  KEY `idMascota_idx` (`idMascota`),
  KEY `fk_idExpediente` (`idExpedientes`),
  CONSTRAINT `fk_idExpediente` FOREIGN KEY (`idExpedientes`) REFERENCES `expedientes` (`idExpedientes`),
  CONSTRAINT `idMascota` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vacuna`
--

LOCK TABLES `vacuna` WRITE;
/*!40000 ALTER TABLE `vacuna` DISABLE KEYS */;
/*!40000 ALTER TABLE `vacuna` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-10-24 21:11:02

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
  `idCirugia` int NOT NULL AUTO_INCREMENT,
  `idMascota` int NOT NULL,
  `idCita` int NOT NULL,
  `FechaHora` datetime NOT NULL,
  `Tipo` enum('Castracion','Extraccion de objeto','Absceso','Lavado gastrico','Cesarea') NOT NULL,
  `Descripcion` longtext NOT NULL,
  `Motivo` varchar(255) NOT NULL,
  `Materiales` longtext NOT NULL,
  PRIMARY KEY (`idCirugia`),
  KEY `fk_idMascotaCirugia_idx` (`idMascota`),
  KEY `idCItaCirugia_idx` (`idCita`),
  CONSTRAINT `idCItaCirugia` FOREIGN KEY (`idCita`) REFERENCES `citas` (`idCita`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `idMascotaCirugia` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cirugia`
--

LOCK TABLES `cirugia` WRITE;
/*!40000 ALTER TABLE `cirugia` DISABLE KEYS */;
INSERT INTO `cirugia` VALUES (1,2,91,'2024-11-13 20:32:38','Extraccion de objeto','','Extracion de un peluche de hule','pinza, anesteceia local, guantes,hilo'),(2,4,93,'2024-11-13 20:41:07','Absceso','','Cirugia de Abceso','guants,esteriles,anestecia,alcohol'),(3,19,15,'2024-11-13 20:55:00','Extraccion de objeto','','Extraccion de pequenas piezas de vidrio','guantes esteriles,algodon, bisturi, anestecia total'),(4,3,92,'2024-11-13 20:57:31','Lavado gastrico','','Intoxicacion','guantes esteriles,algodon,anestecia local'),(5,1,105,'2024-11-13 21:56:46','Castracion','','castracion','hilo quirurgico,anestecia,gel,guantes,bisturi'),(6,6,110,'2024-11-13 21:57:25','Castracion','','castracion','bisturi,anestecia,gel,hilo'),(7,4,108,'2024-11-13 21:59:05','Lavado gastrico','','Intoxicacion','guantes esteriles,pinzas'),(8,3,107,'2024-11-13 22:00:02','Absceso','','Abceso','guantes esteriles'),(9,5,94,'2024-11-13 22:00:46','Cesarea','','cesaria por obstrucion','tijeras,guantes esteriles,bisturi'),(10,8,112,'2024-11-13 22:01:29','Lavado gastrico','','Intoxicacion por rata envenenada','laxante felino,guantes esteriles');
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
  `idMascota` int NOT NULL,
  `Motivo` varchar(255) NOT NULL,
  `Estado` enum('Programada','Cancelada','Finalizada') NOT NULL,
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  PRIMARY KEY (`idCita`),
  KEY `idMascota_Citas` (`idMascota`),
  CONSTRAINT `idMascota_Citas` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=149 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `citas`
--

LOCK TABLES `citas` WRITE;
/*!40000 ALTER TABLE `citas` DISABLE KEYS */;
INSERT INTO `citas` VALUES (1,1,'Consulta de revisión','Programada','2024-11-15','09:00:00'),(2,5,'Vacunación','Programada','2024-11-20','11:30:00'),(3,10,'Revisión dental','Programada','2024-11-25','08:45:00'),(4,12,'Chequeo de rutina','Cancelada','2024-12-01','13:15:00'),(5,16,'Desparasitación','Programada','2024-12-05','10:30:00'),(6,3,'Control de peso','Finalizada','2024-12-10','15:00:00'),(7,18,'Consulta de comportamiento','Programada','2024-12-12','08:00:00'),(8,22,'Examen general','Finalizada','2024-12-15','12:45:00'),(9,23,'Control postoperatorio','Finalizada','2024-12-18','14:00:00'),(10,17,'Consulta por alergias','Programada','2024-12-20','16:00:00'),(11,7,'Revisión de heridas','Finalizada','2024-12-22','11:15:00'),(12,9,'Chequeo de vacunas','Finalizada','2024-12-25','10:00:00'),(13,14,'Consulta de control','Cancelada','2025-01-05','14:30:00'),(14,15,'Examen de salud anual','Finalizada','2025-01-10','13:00:00'),(15,19,'Consulta de emergencia','Finalizada','2025-01-15','09:30:00'),(16,21,'Revisión dental','Finalizada','2025-01-18','15:30:00'),(17,25,'Chequeo general','Finalizada','2025-01-20','10:45:00'),(18,8,'Control de vacunación','Cancelada','2025-01-22','08:30:00'),(19,24,'Revisión general','Finalizada','2025-01-25','14:15:00'),(20,20,'Consulta de seguimiento','Programada','2025-01-30','09:00:00'),(66,1,'Consulta general','Programada','2024-11-14','08:00:00'),(67,2,'Revisión de vacuna','Programada','2024-11-14','09:00:00'),(68,3,'Chequeo de salud','Finalizada','2024-11-14','10:00:00'),(69,4,'Revisión dental','Programada','2024-11-14','11:00:00'),(70,5,'Examen físico','Programada','2024-11-14','12:00:00'),(71,6,'Revisión general','Programada','2024-11-14','13:00:00'),(72,7,'Consulta dermatológica','Finalizada','2024-11-14','14:00:00'),(73,8,'Revisión de vacunas','Finalizada','2024-11-14','15:00:00'),(74,9,'Control de peso','Finalizada','2024-11-14','16:00:00'),(75,10,'Chequeo post-cirugía','Finalizada','2024-11-15','08:00:00'),(76,11,'Revisión general','Programada','2024-11-15','09:00:00'),(77,12,'Consulta nutricional','Programada','2024-11-15','10:00:00'),(78,14,'Vacuna de refuerzo','Programada','2024-11-15','12:00:00'),(79,15,'Revisión de piel','Programada','2024-11-15','13:00:00'),(80,16,'Revisión oftalmológica','Programada','2024-11-15','14:00:00'),(81,17,'Examen de rutina','Finalizada','2024-11-15','15:00:00'),(82,18,'Revisión de peso y salud general','Finalizada','2024-11-15','16:00:00'),(83,19,'Consulta ortopédica','Programada','2024-11-16','08:00:00'),(84,20,'Chequeo general','Programada','2024-11-16','09:00:00'),(85,21,'Examen de salud','Finalizada','2024-11-16','10:00:00'),(86,22,'Revisión de piel','Programada','2024-11-16','11:00:00'),(87,23,'Consulta odontológica','Programada','2024-11-16','12:00:00'),(88,24,'Chequeo general','Finalizada','2024-11-16','13:00:00'),(89,25,'Revisión y vacunas','Programada','2024-11-16','14:00:00'),(90,1,'Cirugía de castración','Programada','2024-11-17','08:00:00'),(91,2,'Extracción de objeto','Finalizada','2024-11-17','09:30:00'),(92,3,'Lavado gástrico','Finalizada','2024-11-17','11:00:00'),(93,4,'Cirugía de absceso','Finalizada','2024-11-18','08:30:00'),(94,5,'Cesárea','Finalizada','2024-11-18','10:00:00'),(95,1,'Examen de rutina','Finalizada','2024-11-19','08:00:00'),(96,2,'Examen de sangre','Finalizada','2024-11-19','09:00:00'),(97,3,'Examen dental','Programada','2024-11-19','10:00:00'),(98,4,'Examen cardiológico','Finalizada','2024-11-20','08:30:00'),(99,5,'Examen ortopédico','Programada','2024-11-20','09:30:00'),(100,1,'Vacuna contra la rabia','Finalizada','2024-11-21','08:00:00'),(101,2,'Vacuna triple felina','Finalizada','2024-11-21','09:00:00'),(102,3,'Vacuna parvovirus','Finalizada','2024-11-21','10:00:00'),(103,4,'Vacuna contra el moquillo','Finalizada','2024-11-22','08:00:00'),(104,5,'Vacuna de refuerzo anual','Finalizada','2024-11-22','09:00:00'),(105,1,'Castracion','Finalizada','2024-11-25','08:00:00'),(106,2,'Extraccion de objeto','Programada','2024-11-25','10:00:00'),(107,3,'Absceso','Finalizada','2024-11-25','12:00:00'),(108,4,'Lavado gastrico','Finalizada','2024-11-26','09:00:00'),(109,5,'Cesarea','Programada','2024-11-26','11:00:00'),(110,6,'Castracion','Finalizada','2024-11-27','08:00:00'),(111,7,'Absceso','Cancelada','2024-11-27','10:00:00'),(112,8,'Lavado gastrico','Finalizada','2024-11-28','08:00:00'),(113,9,'Cesarea','Cancelada','2024-11-28','10:00:00'),(114,10,'Extraccion de objeto','Programada','2024-11-28','13:00:00'),(115,11,'Castracion','Programada','2024-11-29','09:00:00'),(116,12,'Absceso','Programada','2024-11-29','11:00:00'),(117,1,'Perro Moquillo','Programada','2024-11-30','08:00:00'),(118,2,'Perro Parvovirus','Programada','2024-11-30','09:00:00'),(119,3,'Perro Hepatitis','Programada','2024-11-30','10:00:00'),(120,4,'Perro Leptospirosis','Programada','2024-11-30','11:00:00'),(121,5,'Gato Leucemia','Programada','2024-11-30','12:00:00'),(122,6,'Gato Calicivirus','Finalizada','2024-12-01','08:00:00'),(123,7,'Gato Herpesvirus','Programada','2024-12-01','09:00:00'),(124,8,'Gato Panleucopenia','Programada','2024-12-01','10:00:00'),(125,9,'Rabia','Programada','2024-12-01','11:00:00'),(126,10,'Perro Moquillo','Programada','2024-12-01','12:00:00'),(127,11,'Perro Parvovirus','Programada','2024-12-02','08:00:00'),(128,12,'Gato Leucemia','Finalizada','2024-12-02','09:00:00'),(129,1,'Sangre','Finalizada','2024-12-03','08:00:00'),(130,2,'Sida felino','Finalizada','2024-12-03','09:00:00'),(131,3,'Leucemia felino','Programada','2024-12-03','10:00:00'),(132,4,'Radiografia','Programada','2024-12-03','11:00:00'),(133,5,'Ultrasonido','Finalizada','2024-12-03','12:00:00'),(134,6,'Sangre','Programada','2024-12-04','08:00:00'),(135,7,'Radiografia','Finalizada','2024-12-04','09:00:00'),(136,8,'Ultrasonido','Programada','2024-12-04','10:00:00'),(137,9,'Sangre','Programada','2024-12-04','11:00:00'),(138,10,'Radiografia','Programada','2024-12-04','12:00:00'),(139,11,'Ultrasonido','Programada','2024-12-05','08:00:00'),(140,12,'Sangre','Programada','2024-12-05','09:00:00'),(141,25,'Control Semanal de embarazo','Programada','2024-11-14','08:47:25'),(142,24,'Control de Vacuna','Programada','2024-11-22','10:47:53'),(143,23,'Control de herida','Programada','2024-11-14','14:48:25'),(144,22,'Control General','Programada','2024-11-14','09:48:42'),(145,21,'Cesarea por parto','Programada','2024-11-14','08:49:07'),(146,19,'Cirugia','Programada','2024-11-14','09:49:33'),(147,11,'Vacuna','Programada','2024-11-22','09:50:05'),(148,17,'cirugia','Programada','2024-11-24','10:50:21');
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
  `idMascota` int NOT NULL,
  `idCita` int NOT NULL,
  `FechaHora` datetime NOT NULL,
  `Peso` decimal(5,2) NOT NULL,
  `Motivo` varchar(255) DEFAULT NULL,
  `Sintomas` varchar(255) DEFAULT NULL,
  `ExamenFisico` varchar(1000) DEFAULT NULL,
  `Diagnostico` varchar(1000) DEFAULT NULL,
  `Tratamiento` varchar(1000) DEFAULT NULL,
  `Medicamentos` varchar(100) DEFAULT NULL,
  `Notas` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`idConsulta`),
  KEY `idMascotaConsulta_idx` (`idMascota`),
  KEY `idcitaconsulta_idx` (`idCita`),
  CONSTRAINT `idcitaconsulta` FOREIGN KEY (`idCita`) REFERENCES `citas` (`idCita`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `idMascotaConsulta` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultas`
--

LOCK TABLES `consultas` WRITE;
/*!40000 ALTER TABLE `consultas` DISABLE KEYS */;
INSERT INTO `consultas` VALUES (1,9,74,'2024-11-13 19:46:23',4.00,'Control de peso','','Peso Ideal','','','','El paciente se encuentra en su peso idea'),(2,21,16,'2024-11-13 19:48:54',5.00,'Revisión dental','Dolor en la boca','se encontro anomalias en la boca','caries en los incisivos','Lavado bucal','Pasta dentral perruna',''),(3,21,85,'2024-11-13 19:49:38',6.00,'Examen de salud','','','','','',''),(4,10,75,'2024-11-13 19:50:37',6.00,'Chequeo post-cirugía','','No se encontro anomalias','Cicatrizacion Correcta','','',''),(5,24,88,'2024-11-13 19:52:37',3.00,'Chequeo general','Ninguno','Normal','','Ninguno','Ninguno','Se encuentra en un buen estado fisico'),(6,2,101,'2024-11-13 20:26:28',5.00,'Vacuna triple felina','','','','','',''),(7,4,103,'2024-11-13 20:27:09',6.00,'Vacuna contra el moquillo','','','','','',''),(8,8,73,'2024-11-13 20:29:34',4.00,'Revisión de vacunas','','','','','',''),(9,5,104,'2024-11-13 20:31:49',4.00,'Vacuna de refuerzo anual','','','','','',''),(10,2,91,'2024-11-13 20:32:38',5.00,'Extracción de objeto','','','','','',''),(11,4,98,'2024-11-13 20:39:40',4.00,'Examen cardiológico','','','','','',''),(12,17,81,'2024-11-13 20:40:16',5.00,'Examen de rutina','','','','','',''),(13,4,93,'2024-11-13 20:41:07',5.00,'Cirugía de absceso','','','','','',''),(14,3,102,'2024-11-13 20:49:15',7.00,'Vacuna parvovirus','','','','','',''),(15,7,72,'2024-11-13 20:50:55',6.00,'Consulta dermatológica','Caida de cabello, picazon','El paciente tiene gran parte de la piel llena de hongos','sarna','Banos continuonos','Vitaminas y minerales',''),(16,18,82,'2024-11-13 20:52:37',6.00,'Revisión de peso y salud general','','Buena estado','','','',''),(17,19,15,'2024-11-13 20:55:00',6.00,'Consulta de emergencia','Sanagrado, desmayo','Critico','Trauma severo','Se refiere tomas de sangre y a operacion','',''),(18,23,9,'2024-11-13 20:55:18',5.00,'Control postoperatorio','','Normal','','','',''),(19,3,92,'2024-11-13 20:57:31',7.00,'Lavado gástrico','Pulso bajo','Desmayado','Intoxicacion por comer','Lavado gastrico','',''),(20,2,96,'2024-11-13 20:58:18',5.00,'Examen de sangre','','','','','',''),(21,9,12,'2024-11-13 21:20:11',5.00,'Chequeo de vacunas','','','','','',''),(22,1,95,'2024-11-13 21:21:09',7.00,'Examen de rutina','','','','','',''),(23,1,100,'2024-11-13 21:22:18',7.00,'Vacuna contra la rabia','','','','','',''),(24,3,68,'2024-11-13 21:24:38',7.00,'Chequeo de salud','','Buen estado','','','',''),(25,1,129,'2024-11-13 21:41:06',8.00,'Sangre','','','','','',''),(26,2,130,'2024-11-13 21:41:58',4.00,'Sida felino','','','','','',''),(27,12,128,'2024-11-13 21:43:07',8.00,'Gato Leucemia','','','','','',''),(28,6,122,'2024-11-13 21:44:28',5.00,'Gato Calicivirus','','','','','',''),(29,5,133,'2024-11-13 21:45:59',9.00,'Ultrasonido','','','','','',''),(30,7,135,'2024-11-13 21:55:40',8.00,'Radiografia','','','','','',''),(31,1,105,'2024-11-13 21:56:46',8.00,'Castracion','','','','','',''),(32,6,110,'2024-11-13 21:57:25',5.00,'Castracion','','','','','',''),(33,4,108,'2024-11-13 21:59:05',4.00,'Lavado gastrico','','','','','',''),(34,3,107,'2024-11-13 22:00:02',8.00,'Absceso','','','','','',''),(35,5,94,'2024-11-13 22:00:46',8.00,'Cesárea','','','','','',''),(36,8,112,'2024-11-13 22:01:29',4.00,'Lavado gastrico','','','','','','');
/*!40000 ALTER TABLE `consultas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `examen`
--

DROP TABLE IF EXISTS `examen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `examen` (
  `idExamen` int NOT NULL AUTO_INCREMENT,
  `idMascota` int NOT NULL,
  `idCita` int NOT NULL,
  `FechaHora` datetime NOT NULL,
  `Tipo` enum('Sangre','Sida felino','Leucemia felino','Radiografia','Ultrasonido') NOT NULL,
  `Descripcion` longtext NOT NULL,
  `Motivo` varchar(255) NOT NULL,
  `Materiales` mediumtext NOT NULL,
  PRIMARY KEY (`idExamen`),
  KEY `idMascotaExamen_idx` (`idMascota`),
  KEY `idCita_idx` (`idCita`),
  CONSTRAINT `idCita` FOREIGN KEY (`idCita`) REFERENCES `citas` (`idCita`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `idMascotaExamen` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `examen`
--

LOCK TABLES `examen` WRITE;
/*!40000 ALTER TABLE `examen` DISABLE KEYS */;
INSERT INTO `examen` VALUES (1,21,85,'2024-11-13 19:49:38','Sangre','','Examen Preventido','Alcohol, guantes,algodon'),(2,4,98,'2024-11-13 20:39:40','Radiografia','','Examen del Corazon','Bata'),(3,17,81,'2024-11-13 20:40:16','Sangre','','examen rutinario','alcohol,algodon,guantes esteriles'),(4,18,82,'2024-11-13 20:52:37','Sangre','','Chequedo Anual','guantes esteriles,algodon'),(5,19,15,'2024-11-13 20:55:00','Radiografia','','radiografia por posibles huesos rotos','camilla,sabanas'),(6,2,96,'2024-11-13 20:58:18','Sangre','','Posible SIDA felino','guantes esteriles,algodon'),(7,1,95,'2024-11-13 21:21:09','Sangre','','Examen de rutina','alcohol,guantes esteriles'),(8,1,129,'2024-11-13 21:41:06','Sangre','','Chequeo por sintomas de anemia','guantes esteriles,alcohol,aguja'),(9,2,130,'2024-11-13 21:41:58','Sida felino','','Sospecha de sida felino','alcohol,jeringa,algodon'),(10,5,133,'2024-11-13 21:45:59','Ultrasonido','','Ultrasonido, control embarazo','Gel,guantes'),(11,7,135,'2024-11-13 21:55:40','Radiografia','','Radiografia por Costilla Fracturada','anestecia');
/*!40000 ALTER TABLE `examen` ENABLE KEYS */;
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
  `FechaNacimiento` date NOT NULL,
  `Especie` varchar(50) NOT NULL,
  `Raza` varchar(50) NOT NULL,
  `Sexo` varchar(45) NOT NULL,
  `idUsuario` int NOT NULL,
  PRIMARY KEY (`idMascota`),
  KEY `idUsuarios_idx` (`idUsuario`),
  CONSTRAINT `idUsuarios` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`idUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mascotas`
--

LOCK TABLES `mascotas` WRITE;
/*!40000 ALTER TABLE `mascotas` DISABLE KEYS */;
INSERT INTO `mascotas` VALUES (1,'Firulais','2020-06-15','Perro','Labrador','Macho',5),(2,'Pelusa','2019-08-10','Gato','Siames','Hembra',6),(3,'Chispa','2021-01-22','Perro','Bulldog','Macho',9),(4,'Michi','2018-11-05','Gato','Persa','Macho',12),(5,'Lola','2020-03-03','Perro','Golden Retriever','Hembra',16),(6,'Nieve','2019-07-09','Gato','Maine Coon','Macho',13),(7,'Canela','2017-12-13','Perro','Poodle','Hembra',18),(8,'Manchas','2021-09-18','Gato','Bengala','Macho',22),(9,'Toby','2020-04-21','Perro','Beagle','Macho',20),(10,'Bonnie','2019-10-25','Gato','Americano pelo corto','Macho',6),(11,'Rayas','2019-02-11','Gato','Criollo','Macho',18),(12,'Bobby','2022-04-19','Perro','Rottweiler','Macho',5),(14,'Simba','2020-12-01','Gato','Maine Coon','Macho',12),(15,'Nina','2018-07-13','Perro','Yorkshire Terrier','Hembra',22),(16,'Chiqui','2021-11-17','Perro','Dachshund','Hembra',13),(17,'Bigotes','2023-02-21','Gato','Persa','Macho',20),(18,'Peluchin','2017-05-03','Perro','Caniche','Macho',9),(19,'Linda','2020-08-16','Perro','Border Collie','Hembra',16),(20,'Blanca','2022-10-09','Gato','Angora','Hembra',18),(21,'Dulce','2019-01-30','Perro','Bichón Frisé','Hembra',20),(22,'Chico','2020-06-05','Perro','Cocker Spaniel','Macho',22),(23,'Mona','2019-12-18','Gato','British Shorthair','Hembra',12),(24,'Leo','2021-07-25','Gato','Sphynx','Macho',9),(25,'Fiona','2022-09-14','Perro','Bull Terrier','Hembra',5);
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
  `idUsuario` int NOT NULL,
  `Fecha` date NOT NULL,
  `Estado` enum('Pendiente','Pagado') NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  `TipoPago` enum('Efectivo','Bitcoin','Tarjeta','Sin pagar') NOT NULL,
  `TipoServicio` enum('Cita','Producto') NOT NULL,
  PRIMARY KEY (`idPago`),
  KEY `idUsuarios_ipagos` (`idUsuario`),
  CONSTRAINT `idUsuarios_pagos` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`idUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagos`
--

LOCK TABLES `pagos` WRITE;
/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
INSERT INTO `pagos` VALUES (1,20,'2024-11-13','Pendiente',8.00,'Sin pagar','Cita'),(2,20,'2024-11-13','Pendiente',8.00,'Sin pagar','Cita'),(3,20,'2024-11-13','Pendiente',23.00,'Sin pagar','Cita'),(4,6,'2024-11-13','Pagado',8.00,'Efectivo','Cita'),(5,9,'2024-11-13','Pendiente',8.00,'Sin pagar','Cita'),(6,6,'2024-11-13','Pagado',13.00,'Efectivo','Cita'),(7,12,'2024-11-13','Pendiente',13.00,'Sin pagar','Cita'),(8,22,'2024-11-13','Pendiente',13.00,'Sin pagar','Cita'),(9,16,'2024-11-13','Pendiente',13.00,'Sin pagar','Cita'),(10,6,'2024-11-13','Pendiente',38.00,'Sin pagar','Cita'),(11,12,'2024-11-13','Pendiente',23.00,'Sin pagar','Cita'),(12,20,'2024-11-13','Pendiente',23.00,'Sin pagar','Cita'),(13,12,'2024-11-13','Pendiente',38.00,'Sin pagar','Cita'),(14,9,'2024-11-13','Pendiente',13.00,'Sin pagar','Cita'),(15,18,'2024-11-13','Pendiente',8.00,'Sin pagar','Cita'),(16,9,'2024-11-13','Pendiente',28.00,'Sin pagar','Cita'),(17,16,'2024-11-13','Pagado',53.00,'Efectivo','Cita'),(18,12,'2024-11-13','Pagado',8.00,'Tarjeta','Cita'),(19,9,'2024-11-13','Pagado',38.00,'Tarjeta','Cita'),(20,6,'2024-11-13','Pagado',23.00,'Bitcoin','Cita'),(21,6,'2024-11-13','Pendiente',27.00,'Sin pagar','Producto'),(22,6,'2024-11-13','Pendiente',62.00,'Sin pagar','Producto'),(23,6,'2024-11-13','Pendiente',0.00,'Sin pagar','Producto'),(24,20,'2024-11-13','Pendiente',13.00,'Sin pagar','Cita'),(25,5,'2024-11-13','Pendiente',23.00,'Sin pagar','Cita'),(26,5,'2024-11-13','Pendiente',13.00,'Sin pagar','Cita'),(27,9,'2024-11-13','Pendiente',13.00,'Sin pagar','Cita'),(28,5,'2024-11-13','Pendiente',23.00,'Sin pagar','Cita'),(29,6,'2024-11-13','Pendiente',23.00,'Sin pagar','Cita'),(30,5,'2024-11-13','Pendiente',13.00,'Sin pagar','Cita'),(31,13,'2024-11-13','Pendiente',13.00,'Sin pagar','Cita'),(32,16,'2024-11-13','Pagado',23.00,'Bitcoin','Cita'),(33,18,'2024-11-13','Pendiente',23.00,'Sin pagar','Cita'),(34,5,'2024-11-13','Pendiente',38.00,'Sin pagar','Cita'),(35,13,'2024-11-13','Pendiente',38.00,'Sin pagar','Cita'),(36,12,'2024-11-13','Pendiente',38.00,'Sin pagar','Cita'),(37,9,'2024-11-13','Pendiente',38.00,'Sin pagar','Cita'),(38,16,'2024-11-13','Pendiente',38.00,'Sin pagar','Cita'),(39,22,'2024-11-13','Pendiente',38.00,'Sin pagar','Cita');
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'Alimiau',1.00,'1 lb Comida para gato',19),(2,'CatChips',12.00,'1 lb Comida para gato',17),(3,'Gati',5.00,'1 kg Comida para gato',19),(4,'Rufo',2.00,'1 kg Comida para perro',14),(5,'Pedigree',10.00,'2 kg Comida para perro',16),(6,'Nutripet',4.00,'2.3 kg Comida para cachorro',13),(7,'PetGround',5.00,'c/u Cesped para gato',11),(8,'HappyCat',5.00,'5 lb Arena para gato sin aroma',18),(9,'Yes!pH',10.00,' 250 ml Champú para perros y gato',18);
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
  `idUsuario` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Telefono` varchar(15) NOT NULL,
  `Correo` varchar(100) NOT NULL,
  `Direccion` varchar(255) NOT NULL,
  `Rol` enum('Administrador','Veterinario','Dueño') NOT NULL,
  `Usuario` varchar(50) NOT NULL,
  `Contrasena` varchar(255) NOT NULL,
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `Usuario_UNIQUE` (`Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Maria Mejia','72345678','MB23011@ues.edu.sv','Cuscatlan, El Salvador','Administrador','MB23011','mb23011'),(2,'Cristian Vasquez','72345678','VH23017@ues.edu.sv','Ilopango, El Salvador','Administrador','VH23017 ','vh23017 '),(3,'Esmeralda Castellanos','72345678','PC23045@ues.edu.sv','San Marcos, El Salvador','Administrador','PC23045  ','pc23045'),(4,'Roberto Alfaro','72345678','RA23035@ues.edu.sv','Chanmico, El Salvador','Administrador','RA23035','ra23035'),(5,'Carlos Hernández','72345678','carlos.hernandez@email.com','San Salvador, El Salvador','Dueño','carlos123','contrasenaCarlos'),(6,'María López','72567890','maria.lopez@email.com','Santa Ana, El Salvador','Dueño','maria123','contrasenaMaria'),(7,'José González','73456789','jose.gonzalez@email.com','San Miguel, El Salvador','Veterinario','josevet','contrasenaJose'),(8,'Ana Martínez','74567891','ana.martinez@email.com','La Libertad, El Salvador','Veterinario','anavet','contrasenaAna'),(9,'Luis Rodríguez','75567892','luis.rodriguez@email.com','Sonsonate, El Salvador','Dueño','luis123','contrasenaLuis'),(10,'Elena Rivera','76567893','elena.rivera@email.com','Ahuachapán, El Salvador','Veterinario','elenavet','contrasenaElena'),(11,'Luis Escobar','75342186','luis.escobar@ues.edu.sv','Ciudad Universitaria, El Salvador','Administrador','LuisEsco','Escobar12'),(12,'Juan Pérez','72891234','juan.perez@email.com','Usulután, El Salvador','Dueño','juanP','contrasenaJuan'),(13,'Laura Sánchez','72233456','laura.sanchez@email.com','Zacatecoluca, El Salvador','Dueño','lauraS','contrasenaLaura'),(14,'Pedro Martínez','73344567','pedro.martinez@email.com','La Union, El Salvador','Veterinario','pedrovet','contrasenaPedro'),(15,'Sandra Gómez','74355678','sandra.gomez@email.com','Chalatenango, El Salvador','Veterinario','sandravet','contrasenaSandra'),(16,'Carlos Ramírez','75366789','carlos.ramirez@email.com','San Vicente, El Salvador','Dueño','carlosR','contrasenaCarlos'),(17,'Patricia Díaz','76377890','patricia.diaz@email.com','Sonsonate, El Salvador','Veterinario','patriciavet','contrasenaPatricia'),(18,'Ricardo Rodríguez','77388901','ricardo.rodriguez@email.com','Cojutepeque, El Salvador','Dueño','ricardoR','contrasenaRicardo'),(19,'Isabel Flores','78399012','isabel.flores@email.com','Santa Tecla, El Salvador','Veterinario','isabelvet','contrasenaIsabel'),(20,'Jorge Hernández','79310123','jorge.hernandez@email.com','Soyapango, El Salvador','Dueño','jorgeH','contrasenaJorge'),(21,'Marta Rodríguez','80321234','marta.rodriguez@email.com','La Libertad, El Salvador','Veterinario','martarvet','contrasenaMarta'),(22,'Víctor Silva','81332345','victor.silva@email.com','Ilobasco, El Salvador','Dueño','victorS','contrasenaVictor'),(23,'Nancy Pérez','82343456','nancy.perez@email.com','Ahuachapán, El Salvador','Veterinario','nancyvet','contrasenaNancy'),(24,'Gloria Figueroa','82345678','gloria.figueroa@gmail.com','San Vicente, El Salvador','Dueño','gloriaF','contraseñaGloria'),(25,'Rafael Méndez','83456789','rafael.mendez@gmail.com','La Paz, El Salvador','Dueño','rafaelM','contraseñaRafael'),(26,'Reina Cruz','84567890','reina.cruz@email.com','Chalchuapa, El Salvador','Dueño','reinaC','contraseñaReina'),(27,'Mario Argueta','85678901','mario.argueta@gmail.com','Santa Rosa de Lima, El Salvador','Dueño','marioA','contraseñaMario'),(28,'Margarita Chávez','86789012','margarita.chavez@gmail.com','Cojutepeque, El Salvador','Dueño','margaritaC','contraseñaMargarita'),(29,'Manuel Flores','87890123','manuel.florez@gmail.com','Apopa, El Salvador','Dueño','manuelF','contraseñaManuel'),(30,'Carmen Aguilar','88901234','carmen.aguilar@gmail.com','Santa Tecla, El Salvador','Dueño','carmenA','contraseñaCarmen'),(31,'Luis Cabrera','89912345','luis.cabrera@gmail.com','Soyapango, El Salvador','Dueño','luisC','contraseñaLuisC'),(32,'Juana Martínez','80923456','juana.martinez@gmail.com','San Miguel, El Salvador','Dueño','juanaM','contraseñaJuana');
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
  `idMascota` int NOT NULL,
  `idCita` int DEFAULT NULL,
  `FechaHora` datetime NOT NULL,
  `Tipo` enum('Perro Moquillo','Perro Parvovirus','Perro Hepatitis','Perro Leptospirosis','Gato Leucemia','Gato Calicivirus','Gato Herpesvirus','Gato Panleucopenia','Rabia') NOT NULL,
  `Descripcion` longtext,
  `Motivo` varchar(255) NOT NULL,
  `Materiales` mediumtext NOT NULL,
  PRIMARY KEY (`idVacuna`),
  KEY `idMascotaVacuna_idx` (`idMascota`),
  KEY `idCitaVacuna_idx` (`idCita`),
  CONSTRAINT `idCitaVacuna` FOREIGN KEY (`idCita`) REFERENCES `citas` (`idCita`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `idMascotaVacuna` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vacuna`
--

LOCK TABLES `vacuna` WRITE;
/*!40000 ALTER TABLE `vacuna` DISABLE KEYS */;
INSERT INTO `vacuna` VALUES (1,2,101,'2024-11-13 20:26:28','Perro Moquillo','El paciente es inquieto','Vacuna de Control anual','alcohol,algodon'),(2,4,103,'2024-11-13 20:27:09','Perro Moquillo','Inicio de control','Vacuna Contra el moquillo','Algodon,guantes esteriles,alcohol'),(3,8,73,'2024-11-13 20:29:34','Rabia','','En el historial faltaba la vacuna contra la rabia','alcohol,guantes'),(4,5,104,'2024-11-13 20:31:49','Rabia','','Refuerzo de vacuna de la rabia','alcohol'),(5,3,102,'2024-11-13 20:49:15','Perro Parvovirus','','Inicio de control contra el parvvovirus','algodon,guantes esteriles'),(6,18,82,'2024-11-13 20:52:37','Rabia','','Aplicacion Anual','guantes esteriles,algodon'),(7,9,12,'2024-11-13 21:20:11','Rabia','','Chequeo anual contra la rabia','guantes esteriles'),(8,1,100,'2024-11-13 21:22:18','Gato Leucemia','','Vacuna contra la rabia','alcohol,guantes esteriles'),(9,3,68,'2024-11-13 21:24:38','Perro Moquillo','','Control de vacuna del moquillo','alcohol,guantes, jeringa'),(10,12,128,'2024-11-13 21:43:07','Gato Leucemia','','Control de Leumia','Guantes esteriles,gatete,sonda'),(11,6,122,'2024-11-13 21:44:28','Gato Calicivirus','','Control de Calicivirus','alcohol,jeringa,guantes esteriles');
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

-- Dump completed on 2024-11-13 22:03:25

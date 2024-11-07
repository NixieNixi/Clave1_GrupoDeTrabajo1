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
  `Tipo` enum('Castracion','Extraccion de objeto','Absceso','Lavado gastrico','Cesarea') NOT NULL,
  `Descripcion` longtext NOT NULL,
  `Motivo` varchar(255) NOT NULL,
  `Materiales` longtext NOT NULL,
  PRIMARY KEY (`idCirugia`),
  KEY `fk_idMascotaCirugia_idx` (`idMascota`),
  CONSTRAINT `idMascotaCirugia` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cirugia`
--

LOCK TABLES `cirugia` WRITE;
/*!40000 ALTER TABLE `cirugia` DISABLE KEYS */;
INSERT INTO `cirugia` VALUES (1,1,'Castracion','Esteriliazcion Misi','Motivo valido','Material1');
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
  CONSTRAINT `idMascota_Citas` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `citas`
--

LOCK TABLES `citas` WRITE;
/*!40000 ALTER TABLE `citas` DISABLE KEYS */;
INSERT INTO `citas` VALUES (1,1,'Examen','Programada','2024-11-12','10:30:00'),(2,1,'vacuna','Programada','2023-11-21','10:00:00'),(3,4,'Parto','Programada','2023-12-24','13:00:00'),(4,2,'Vacuna','Programada','2024-11-14','00:00:00'),(5,11,'Castracion','Programada','2024-11-22','21:29:37'),(6,8,'adsasdas','Programada','2024-11-25','08:30:06'),(7,10,'Esterilización','Programada','2024-12-10','09:00:16'),(8,10,'Control','Programada','2025-01-08','14:30:56'),(9,9,'Control','Programada','2024-11-18','11:44:29'),(10,12,'Desparacitacion','Programada','2025-02-17','11:00:02'),(11,7,'Vacuna de la rabia','Programada','2024-11-19','15:00:17'),(12,7,'Coso epico','Programada','2024-11-27','12:51:54'),(13,6,'Motivos tiene','Programada','2024-11-14','14:20:15'),(14,1,'Control de salud','Cancelada','2025-03-04','15:12:48'),(15,2,'porbablementoe','Programada','2024-11-20','11:32:15'),(16,2,'Motivo epico','Programada','2024-11-07','14:44:38'),(17,1,'Hueso quebrado','Programada','2024-11-07','13:46:41'),(18,4,'Control de salud','Cancelada','2024-11-09','14:47:22');
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
  CONSTRAINT `idMascotaConsulta` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultas`
--

LOCK TABLES `consultas` WRITE;
/*!40000 ALTER TABLE `consultas` DISABLE KEYS */;
INSERT INTO `consultas` VALUES (1,1,'2024-01-30 15:00:00',2.00,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2,1,'2024-09-12 10:00:00',2.00,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(4,1,'2024-02-12 07:00:00',2.00,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
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
  `Tipo` enum('Sangre','Sida felino','Leucemia felino','Radiografia','Ultrasonido') NOT NULL,
  `Descripcion` longtext NOT NULL,
  `Motivo` varchar(255) NOT NULL,
  `Materiales` mediumtext NOT NULL,
  PRIMARY KEY (`idExamen`),
  KEY `idMascotaExamen_idx` (`idMascota`),
  CONSTRAINT `idMascotaExamen` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `examen`
--

LOCK TABLES `examen` WRITE;
/*!40000 ALTER TABLE `examen` DISABLE KEYS */;
INSERT INTO `examen` VALUES (1,1,'Sangre','Examen de sangre','Estudio','Material3');
/*!40000 ALTER TABLE `examen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `expedientes`
--

DROP TABLE IF EXISTS `expedientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `expedientes` (
  `idExpediente` int NOT NULL AUTO_INCREMENT,
  `idMascota` int NOT NULL,
  `idConsulta` int NOT NULL,
  `idExamen` int DEFAULT NULL,
  `idVacuna` int DEFAULT NULL,
  `idCirugia` int DEFAULT NULL,
  PRIMARY KEY (`idExpediente`),
  KEY `idCirugia_idx` (`idCirugia`),
  KEY `idVacuna_idx` (`idVacuna`),
  KEY `idExamen_idx` (`idExamen`),
  KEY `idMascota_idx` (`idMascota`),
  KEY `idConsulta_idx` (`idConsulta`),
  CONSTRAINT `idCirugia` FOREIGN KEY (`idCirugia`) REFERENCES `cirugia` (`idCirugia`),
  CONSTRAINT `idConsulta` FOREIGN KEY (`idConsulta`) REFERENCES `consultas` (`idConsulta`),
  CONSTRAINT `idExamen` FOREIGN KEY (`idExamen`) REFERENCES `examen` (`idExamen`),
  CONSTRAINT `idMascota` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`),
  CONSTRAINT `idVacuna` FOREIGN KEY (`idVacuna`) REFERENCES `vacuna` (`idVacuna`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `expedientes`
--

LOCK TABLES `expedientes` WRITE;
/*!40000 ALTER TABLE `expedientes` DISABLE KEYS */;
INSERT INTO `expedientes` VALUES (1,1,1,NULL,NULL,1),(2,1,2,NULL,1,NULL),(3,1,4,1,NULL,NULL);
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
  `FechaNacimiento` date NOT NULL,
  `Especie` varchar(50) NOT NULL,
  `Raza` varchar(50) NOT NULL,
  `Sexo` varchar(45) NOT NULL,
  `idUsuario` int NOT NULL,
  PRIMARY KEY (`idMascota`),
  KEY `idUsuarios_idx` (`idUsuario`),
  CONSTRAINT `idUsuarios` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mascotas`
--

LOCK TABLES `mascotas` WRITE;
/*!40000 ALTER TABLE `mascotas` DISABLE KEYS */;
INSERT INTO `mascotas` VALUES (1,'Misi','2022-02-10','Gato','Curl Americano','F',7),(2,'Misty','2022-04-26','Gato','American Wirehair','F',7),(3,'Raúl','2020-03-25','Gato','Sin raza','M',8),(4,'Bonnie','2021-03-15','Gato','Americano Pelo Corto','M',5),(5,'Canelo','2015-06-14','Perro','Nureongi','M',5),(6,'Tanathos','2021-10-07','Gato','Chartreux','M',6),(7,'Pandora','2023-08-07','Gato','Fold','F',6),(8,'Luis','2021-06-12','Iguana','runoceconte','M',8),(9,'Marlen','2023-09-20','Pez','Payaso','M',8),(10,'Gaxi','2024-10-30','Gato','American Wirehair','F',7),(11,'Naranja','2024-02-15','Gato','American Wirehair','M',7),(12,'Max','2024-01-24','Perro','Salchicha','M',7),(13,'Dogger','2014-04-14','Perro','Continental','M',7);
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
  `idUsuarios` int NOT NULL,
  `Fecha` date NOT NULL,
  `Estado` enum('Pendiente','Pagado') NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  `TipoPago` enum('Efectivo','Bitcoin','Tarjeta','Sin pagar') NOT NULL,
  `TipoServicio` enum('Cita','Producto') NOT NULL,
  PRIMARY KEY (`idPago`),
  KEY `idUsuarios_ipagos` (`idUsuarios`),
  CONSTRAINT `idUsuarios_pagos` FOREIGN KEY (`idUsuarios`) REFERENCES `usuarios` (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `idUsuario` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Telefono` varchar(15) NOT NULL,
  `Correo` varchar(100) NOT NULL,
  `Direccion` varchar(255) NOT NULL,
  `Rol` enum('Administrador','Veterinario','Dueño') NOT NULL,
  `Usuario` varchar(50) NOT NULL,
  `Contrasena` varchar(255) NOT NULL,
  PRIMARY KEY (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Dr. Gabriela Bautista','77548926','gabriela.bautista@gmail.com','Cojutepeque, Cuscatlan','Veterinario','GaBau','MeBa'),(2,'Dr. Roberto Alfaro','98765432','robert.alfa@gmail.com','San Juan Opico, La libertad','Veterinario','Rob','Alfa'),(3,'Dr. Cristian Vasquez','45678912','cristian.vasquez@gmail.com','Ilopango, San Salvador','Veterinario','Cris','Vas'),(4,'Dr. Esmeralda Castellanos','96385274','esmeralda.castellanos@gmail.com','San Marcos, San Salvador','Veterinario','Esme','Cas'),(5,'Maria Mejia','74185296','maria.mejia@gmail.com','Sta Cruz Michapa, Cuscatlan','Dueño','NixieNixi','wangxian'),(6,'Rafael Ramos','85296374','rafael.ramos@gmail.com','Santa Ana, Santa Ana','Dueño','Raff','RarMustis'),(7,'Mauricio Hernandez','12305678','mauricio.hernan@gmail.com','San Miguel Tepezontes,La Paz','Dueño','Mau2','Canela1'),(8,'Odeth Perez','75342189','odeth.perez@gmail.com','Sierra Morena,San Salvador','Dueño','Ruby','Ruby1'),(9,'Luis Escobar','12345678','luis.escobar@ues.edu.sv','San Salvador,San Salvador','Administrador','LuisEsco','Escobar12'),(10,'Nombre','12345678','correo@gmail.com','Mi casa','Dueño','usar','contraseña123'),(11,'Julio','12345678','correo@correo.com','Casa de Julio','Dueño','Panquesito','123edfg'),(12,'José','12345678','jose@correo.com','casa de jose','Dueño','js123','23eddf3'),(13,'Marcos','12345678','correo.mc@gmail.com','Madriguera de ninguna parte','Dueño','mc123','123asd');
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
  `Tipo` enum('Perro Moquillo','Perro Parvovirus','Perro Hepatitis','Perro Leptospirosis','Gato Leucemia','Gato Calicivirus','Gato Herpesvirus','Gato Panleucopenia','Rabia') NOT NULL,
  `Descripcion` longtext,
  `Motivo` varchar(255) NOT NULL,
  `Materiales` mediumtext NOT NULL,
  PRIMARY KEY (`idVacuna`),
  KEY `idMascotaVacuna_idx` (`idMascota`),
  CONSTRAINT `idMascotaVacuna` FOREIGN KEY (`idMascota`) REFERENCES `mascotas` (`idMascota`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vacuna`
--

LOCK TABLES `vacuna` WRITE;
/*!40000 ALTER TABLE `vacuna` DISABLE KEYS */;
INSERT INTO `vacuna` VALUES (1,1,'Rabia',NULL,'Prevencion','Material1, Material2'),(4,9,'Rabia','vacuna rabia','si','vacuna');
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

-- Dump completed on 2024-11-07 17:33:38

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cirugia`
--

LOCK TABLES `cirugia` WRITE;
/*!40000 ALTER TABLE `cirugia` DISABLE KEYS */;
INSERT INTO `cirugia` VALUES (4,5,5,'2024-11-12 21:44:53','Absceso','asdasd','asdads','adsad'),(5,4,4,'2024-11-12 22:42:43','Lavado gastrico','sdasd','asdasd','sdasd');
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultas`
--

LOCK TABLES `consultas` WRITE;
/*!40000 ALTER TABLE `consultas` DISABLE KEYS */;
INSERT INTO `consultas` VALUES (4,1,1,'2024-11-10 22:21:04',2.00,'Consulta general','','','','','',''),(5,5,5,'2024-11-12 21:44:53',12.00,'Problemas digestivos','','','','','',''),(6,4,4,'2024-11-12 22:42:43',2.00,'Chequeo Gestante','gato','epco','medio gris con un toque de gris','comer','si','le falta sopa');
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `examen`
--

LOCK TABLES `examen` WRITE;
/*!40000 ALTER TABLE `examen` DISABLE KEYS */;
INSERT INTO `examen` VALUES (4,5,5,'2024-11-12 21:44:53','Sida felino','sdasd','asdasd','dsads'),(5,4,4,'2024-11-12 22:42:43','Sangre','asdasd','asdasd','sdasd');
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
  `FechaNacimiento` date NOT NULL,
  `Especie` varchar(50) NOT NULL,
  `Raza` varchar(50) NOT NULL,
  `Sexo` varchar(45) NOT NULL,
  `idUsuario` int NOT NULL,
  PRIMARY KEY (`idMascota`),
  KEY `idUsuarios_idx` (`idUsuario`),
  CONSTRAINT `idUsuarios` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`idUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
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
  `idUsuario` int NOT NULL,
  `Fecha` date NOT NULL,
  `Estado` enum('Pendiente','Pagado') NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  `TipoPago` enum('Efectivo','Bitcoin','Tarjeta','Sin pagar') NOT NULL,
  `TipoServicio` enum('Cita','Producto') NOT NULL,
  PRIMARY KEY (`idPago`),
  KEY `idUsuarios_ipagos` (`idUsuario`),
  CONSTRAINT `idUsuarios_pagos` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`idUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'Alimiau',1.00,'1 lb Comida para gato',16),(2,'CatChips',12.00,'1 lb Comida para gato',16),(3,'Gati',5.00,'1 kg Comida para gato',13),(4,'Rufo',2.00,'1 kg Comida para perro',19),(5,'Pedigree',10.00,'2 kg Comida para perro',17),(6,'Nutripet',4.00,'2.3 kg Comida para cachorro',15),(7,'PetGround',5.00,'c/u Cesped para gato',19),(8,'HappyCat',5.00,'5 lb Arena para gato sin aroma',18),(9,'Yes!pH',10.00,' 250 ml Champú para perros y gato',18);
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
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Maria Mejia','72345678','MB23011@ues.edu.sv','Cuscatlan, El Salvador','Administrador','MB23011','mb23011'),(2,'Cristian Vasquez','72345678','VH23017@ues.edu.sv','Ilopango, El Salvador','Administrador','VH23017 ','vh23017 '),(3,'Esmeralda Castellanos','72345678','PC23045@ues.edu.sv','San Marcos, El Salvador','Administrador','PC23045  ','pc23045'),(4,'Roberto Alfaro','72345678','RA23035@ues.edu.sv','Chanmico, El Salvador','Administrador','RA23035','ra23035'),(5,'Carlos Hernández','72345678','carlos.hernandez@email.com','San Salvador, El Salvador','Dueño','carlos123','contrasenaCarlos'),(6,'María López','72567890','maria.lopez@email.com','Santa Ana, El Salvador','Dueño','maria123','contrasenaMaria'),(7,'José González','73456789','jose.gonzalez@email.com','San Miguel, El Salvador','Veterinario','josevet','contrasenaJose'),(8,'Ana Martínez','74567891','ana.martinez@email.com','La Libertad, El Salvador','Veterinario','anavet','contrasenaAna'),(9,'Luis Rodríguez','75567892','luis.rodriguez@email.com','Sonsonate, El Salvador','Dueño','luis123','contrasenaLuis'),(10,'Elena Rivera','76567893','elena.rivera@email.com','Ahuachapán, El Salvador','Veterinario','elenavet','contrasenaElena'),(11,'Luis Escobar','75342186','luis.escobar@ues.edu.sv','Ciudad Universitaria, El Salvador','Administrador','LuisEsco','Escobar12'),(12,'Juan Pérez','72891234','juan.perez@email.com','Usulután, El Salvador','Dueño','juanP','contrasenaJuan'),(13,'Laura Sánchez','72233456','laura.sanchez@email.com','Zacatecoluca, El Salvador','Dueño','lauraS','contrasenaLaura'),(14,'Pedro Martínez','73344567','pedro.martinez@email.com','La Union, El Salvador','Veterinario','pedrovet','contrasenaPedro'),(15,'Sandra Gómez','74355678','sandra.gomez@email.com','Chalatenango, El Salvador','Veterinario','sandravet','contrasenaSandra'),(16,'Carlos Ramírez','75366789','carlos.ramirez@email.com','San Vicente, El Salvador','Dueño','carlosR','contrasenaCarlos'),(17,'Patricia Díaz','76377890','patricia.diaz@email.com','Sonsonate, El Salvador','Veterinario','patriciavet','contrasenaPatricia'),(18,'Ricardo Rodríguez','77388901','ricardo.rodriguez@email.com','Cojutepeque, El Salvador','Dueño','ricardoR','contrasenaRicardo'),(19,'Isabel Flores','78399012','isabel.flores@email.com','Santa Tecla, El Salvador','Veterinario','isabelvet','contrasenaIsabel'),(20,'Jorge Hernández','79310123','jorge.hernandez@email.com','Soyapango, El Salvador','Dueño','jorgeH','contrasenaJorge'),(21,'Marta Rodríguez','80321234','marta.rodriguez@email.com','La Libertad, El Salvador','Veterinario','martarvet','contrasenaMarta'),(22,'Víctor Silva','81332345','victor.silva@email.com','Ilobasco, El Salvador','Dueño','victorS','contrasenaVictor'),(23,'Nancy Pérez','82343456','nancy.perez@email.com','Ahuachapán, El Salvador','Veterinario','nancyvet','contrasenaNancy');
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vacuna`
--

LOCK TABLES `vacuna` WRITE;
/*!40000 ALTER TABLE `vacuna` DISABLE KEYS */;
INSERT INTO `vacuna` VALUES (4,5,5,'2024-11-12 21:44:53','Perro Hepatitis','asdads','sdasd','asdasd'),(5,4,4,'2024-11-12 22:42:43','Rabia','asd','asd','asd');
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

-- Dump completed on 2024-11-13  1:01:15

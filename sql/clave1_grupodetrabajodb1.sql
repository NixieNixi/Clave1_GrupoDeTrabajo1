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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `citas`
--

LOCK TABLES `citas` WRITE;
/*!40000 ALTER TABLE `citas` DISABLE KEYS */;
INSERT INTO `citas` VALUES (1,1,'Consulta de revisión','Programada','2024-11-15','09:00:00'),(2,5,'Vacunación','Programada','2024-11-20','11:30:00'),(3,10,'Revisión dental','Programada','2024-11-25','08:45:00'),(4,12,'Chequeo de rutina','Cancelada','2024-12-01','13:15:00'),(5,16,'Desparasitación','Programada','2024-12-05','10:30:00'),(6,3,'Control de peso','Finalizada','2024-12-10','15:00:00'),(7,18,'Consulta de comportamiento','Programada','2024-12-12','08:00:00'),(8,22,'Examen general','Finalizada','2024-12-15','12:45:00'),(9,23,'Control postoperatorio','Programada','2024-12-18','14:00:00'),(10,17,'Consulta por alergias','Programada','2024-12-20','16:00:00'),(11,7,'Revisión de heridas','Finalizada','2024-12-22','11:15:00'),(12,9,'Chequeo de vacunas','Programada','2024-12-25','10:00:00'),(13,14,'Consulta de control','Cancelada','2025-01-05','14:30:00'),(14,15,'Examen de salud anual','Finalizada','2025-01-10','13:00:00'),(15,19,'Consulta de emergencia','Programada','2025-01-15','09:30:00'),(16,21,'Revisión dental','Programada','2025-01-18','15:30:00'),(17,25,'Chequeo general','Finalizada','2025-01-20','10:45:00'),(18,8,'Control de vacunación','Cancelada','2025-01-22','08:30:00'),(19,24,'Revisión general','Finalizada','2025-01-25','14:15:00'),(20,20,'Consulta de seguimiento','Programada','2025-01-30','09:00:00');
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

-- Dump completed on 2024-11-13 17:33:31

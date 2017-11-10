-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: db_scheduler_system
-- ------------------------------------------------------
-- Server version	5.6.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_medicine`
--

DROP TABLE IF EXISTS `tbl_medicine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_medicine` (
  `medicine_id` bigint(20) NOT NULL,
  `medicine_name` varchar(255) DEFAULT NULL,
  `medicine_type` varchar(45) DEFAULT NULL,
  `medicine_batch_delivered` varchar(255) DEFAULT NULL,
  `medicine_stocks` varchar(45) DEFAULT NULL,
  `medicine_date_delivered` datetime DEFAULT NULL,
  `medicine_date_recieved` datetime DEFAULT NULL,
  `medicine_date_expiry` datetime DEFAULT NULL,
  PRIMARY KEY (`medicine_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_medicine`
--

LOCK TABLES `tbl_medicine` WRITE;
/*!40000 ALTER TABLE `tbl_medicine` DISABLE KEYS */;
INSERT INTO `tbl_medicine` VALUES (0,'bioflu= 100','tablet','2017123512','2017123510','2017-10-13 00:00:00','2017-10-13 14:10:06','2017-10-14 00:00:00');
/*!40000 ALTER TABLE `tbl_medicine` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_medicine_transaction`
--

DROP TABLE IF EXISTS `tbl_medicine_transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_medicine_transaction` (
  `medicine_transaction_id` bigint(20) NOT NULL,
  `medicine_id` bigint(20) DEFAULT NULL,
  `medicine_transaction_type` varchar(255) DEFAULT NULL,
  `medicine_transaction_quantity` int(11) DEFAULT NULL,
  `medicine_transaction_date` date DEFAULT NULL,
  PRIMARY KEY (`medicine_transaction_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_medicine_transaction`
--

LOCK TABLES `tbl_medicine_transaction` WRITE;
/*!40000 ALTER TABLE `tbl_medicine_transaction` DISABLE KEYS */;
INSERT INTO `tbl_medicine_transaction` VALUES (0,0,'tablet',2,'2017-10-13');
/*!40000 ALTER TABLE `tbl_medicine_transaction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_nurse`
--

DROP TABLE IF EXISTS `tbl_nurse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_nurse` (
  `nurse_id` bigint(20) NOT NULL,
  `nurse_fullname` varchar(255) DEFAULT NULL,
  `nurse_address` varchar(255) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`nurse_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_nurse`
--

LOCK TABLES `tbl_nurse` WRITE;
/*!40000 ALTER TABLE `tbl_nurse` DISABLE KEYS */;
INSERT INTO `tbl_nurse` VALUES (0,'undefined','undefined',0),(1,'Nurse Khristine Claveria','Navotas City',0),(2,'Nurse Joy Ruiz','Tondo Manila',0),(3,'Nurse Ivy Rose Ruiz','Tondo Manila',0);
/*!40000 ALTER TABLE `tbl_nurse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_patient`
--

DROP TABLE IF EXISTS `tbl_patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_patient` (
  `patient_id` bigint(20) NOT NULL,
  `room_id` bigint(20) DEFAULT NULL,
  `patient_fullname` varchar(255) DEFAULT NULL,
  `patient_address` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`patient_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_patient`
--

LOCK TABLES `tbl_patient` WRITE;
/*!40000 ALTER TABLE `tbl_patient` DISABLE KEYS */;
INSERT INTO `tbl_patient` VALUES (0,0,'undefined','undefined'),(1,2,'Nikko Zamora','Navotas City'),(2,1,'Raineer Emeperado','Navotas City'),(3,4,'Ralph Oliveros','Navotas City'),(4,2,'asd','asd');
/*!40000 ALTER TABLE `tbl_patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_room`
--

DROP TABLE IF EXISTS `tbl_room`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_room` (
  `room_id` bigint(20) NOT NULL,
  `room_code` varchar(255) DEFAULT NULL,
  `room_name` varchar(255) DEFAULT NULL,
  `room_description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`room_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_room`
--

LOCK TABLES `tbl_room` WRITE;
/*!40000 ALTER TABLE `tbl_room` DISABLE KEYS */;
INSERT INTO `tbl_room` VALUES (0,'0','undefined','undefined'),(1,'404','Emergency Room','Emergency'),(2,'101','Normal Room','Normal'),(3,'102','Canteen','Food'),(4,'103','X-ray Laboratory','Laboratory 1'),(5,'104','Theraphy Room','Theraphy');
/*!40000 ALTER TABLE `tbl_room` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_schedule`
--

DROP TABLE IF EXISTS `tbl_schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_schedule` (
  `schedule_id` bigint(20) NOT NULL,
  `nurse_id` bigint(20) DEFAULT NULL,
  `room_id` bigint(20) DEFAULT NULL,
  `patient_id` bigint(20) DEFAULT NULL,
  `schedule_title` varchar(255) DEFAULT NULL,
  `schedule_description` varchar(255) DEFAULT NULL,
  `schedule_time` time DEFAULT NULL,
  `schedule_date` datetime DEFAULT NULL,
  `schedule_status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`schedule_id`),
  KEY `room_id` (`room_id`),
  KEY `patient_id` (`patient_id`),
  KEY `nurse_id_idx` (`nurse_id`),
  CONSTRAINT `nurse_id` FOREIGN KEY (`nurse_id`) REFERENCES `tbl_nurse` (`nurse_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `patient_id` FOREIGN KEY (`patient_id`) REFERENCES `tbl_patient` (`patient_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `room_id` FOREIGN KEY (`room_id`) REFERENCES `tbl_room` (`room_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_schedule`
--

LOCK TABLES `tbl_schedule` WRITE;
/*!40000 ALTER TABLE `tbl_schedule` DISABLE KEYS */;
INSERT INTO `tbl_schedule` VALUES (0,0,0,0,'undefined','undefined','00:00:00','2017-01-01 00:00:00','free'),(1,1,1,1,'dead or alive','nothing to say','00:00:00','2017-01-02 00:00:00','busy'),(2,2,2,2,'cezz gow','nothing to say','00:00:00','2017-01-03 00:00:00','tentative'),(3,2,3,3,'chiil friends','nothing to say','00:00:00','2017-01-04 00:00:00','free'),(4,3,1,3,'fuck day','fuck yeah','00:00:00','2017-01-05 00:00:00','free'),(5,3,1,0,'chill again','nothing','12:07:43','2017-10-17 00:00:00','free'),(6,3,1,0,'chill again','nothing','12:07:43','2017-10-18 00:00:00','free'),(7,3,1,0,'chill again','nothing','12:07:43','2017-10-19 00:00:00','free'),(8,1,0,0,'hello','sd','04:12:07','2017-01-19 00:00:00','tentative'),(9,1,0,0,'hello','sd','04:12:07','2017-01-21 00:00:00','tentative'),(10,3,0,0,'dsfdsf','df','07:15:18','2017-05-20 00:00:00','tentative'),(11,1,2,0,'tamond day','notihng','08:52:53','2017-10-19 00:00:00','free'),(12,1,2,0,'tamond day','notihng','08:52:53','2017-10-17 00:00:00','free'),(13,1,2,0,'tamond day','notihng','08:52:53','2017-11-19 00:00:00','free'),(14,1,2,0,'tamond day','notihng','08:52:53','2017-11-17 00:00:00','free'),(15,2,1,0,'noel','notihng','09:02:28','2017-10-10 00:00:00','tentative'),(16,2,1,0,'noel','notihng','09:02:28','2017-10-11 00:00:00','tentative'),(17,2,1,0,'noel','notihng','09:02:28','2017-10-12 00:00:00','tentative'),(18,2,1,0,'noel','notihng','09:02:28','2017-10-17 00:00:00','tentative'),(19,2,1,0,'noel','notihng','09:02:28','2017-10-18 00:00:00','tentative'),(20,0,0,0,'asd','asd','10:42:12','2017-10-12 00:00:00','busy'),(21,0,0,0,'asd','asd','10:42:12','2017-10-13 00:00:00','busy');
/*!40000 ALTER TABLE `tbl_schedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_supplies`
--

DROP TABLE IF EXISTS `tbl_supplies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_supplies` (
  `supplies_id` int(11) NOT NULL,
  `supplies_name` varchar(255) DEFAULT NULL,
  `supplies_batch_delivered` varchar(255) DEFAULT NULL,
  `supplies_expiry` date DEFAULT NULL,
  `supplies_date_purchase` date DEFAULT NULL,
  `supplies_stocks` bigint(20) DEFAULT NULL,
  `supplies_status` varchar(255) DEFAULT NULL,
  `supplies_remarks` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`supplies_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_supplies`
--

LOCK TABLES `tbl_supplies` WRITE;
/*!40000 ALTER TABLE `tbl_supplies` DISABLE KEYS */;
INSERT INTO `tbl_supplies` VALUES (0,'Dustfan','20170911','2017-09-25','2017-09-11',35,'AA','AA'),(1,'Shoes','20170917','2017-09-25','2017-09-17',8,'Good','AAA'),(2,'Shoes XL','20170917','2017-09-25','2017-09-17',7,'Bad','A');
/*!40000 ALTER TABLE `tbl_supplies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_supplies_transaction`
--

DROP TABLE IF EXISTS `tbl_supplies_transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_supplies_transaction` (
  `supplies_transaction_id` int(11) NOT NULL,
  `supplies_id` varchar(255) DEFAULT NULL,
  `supplies_transaction_quantity` varchar(255) DEFAULT NULL,
  `supplies_transaction_date` date DEFAULT NULL,
  PRIMARY KEY (`supplies_transaction_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_supplies_transaction`
--

LOCK TABLES `tbl_supplies_transaction` WRITE;
/*!40000 ALTER TABLE `tbl_supplies_transaction` DISABLE KEYS */;
INSERT INTO `tbl_supplies_transaction` VALUES (0,'0','5','2017-09-19'),(1,'1','2','2017-09-19'),(2,'2','3','2017-09-19'),(3,'0','5','2017-09-19');
/*!40000 ALTER TABLE `tbl_supplies_transaction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_user`
--

DROP TABLE IF EXISTS `tbl_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_user` (
  `user_id` bigint(20) NOT NULL,
  `user_position` varchar(200) DEFAULT NULL,
  `user_username` varchar(200) DEFAULT NULL,
  `user_password` varchar(200) DEFAULT NULL,
  `user_recovery_password` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_user`
--

LOCK TABLES `tbl_user` WRITE;
/*!40000 ALTER TABLE `tbl_user` DISABLE KEYS */;
INSERT INTO `tbl_user` VALUES (0,'0','undefined','undefined','undefined');
/*!40000 ALTER TABLE `tbl_user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'db_scheduler_system'
--

--
-- Dumping routines for database 'db_scheduler_system'
--
/*!50003 DROP PROCEDURE IF EXISTS `CreateAccount` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateAccount`(
																user_id BIGINT(20),
                                                                user_position VARCHAR(200),
																user_username1 VARCHAR(200),
                                                                user_password VARCHAR(200),
                                                                user_recovery_password VARCHAR(200)
																)
BEGIN
INSERT INTO `db_scheduler_system`.`tbl_user` (`user_id`, `user_position`, `user_username`,`user_password`,`user_recovery_password`) 
VALUES (user_id,user_position, user_username1,user_password,user_recovery_password);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CreateMedicine` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateMedicine`(
																medicine_id BIGINT(20),
																medicine_name VARCHAR(255),
                                                                medicine_type VARCHAR(45),
                                                                medicine_batch_delivered VARCHAR(255),
                                                                medicine_stocks VARCHAR(45),
                                                                medicine_date_delivered DATE,
                                                                medicine_date_recieved VARCHAR(255),
                                                                medicine_date_expiry DATE
                                                                
																)
BEGIN
INSERT INTO `db_scheduler_system`.`tbl_medicine` (`medicine_id`,`medicine_name`,`medicine_type`,`medicine_batch_delivered`,`medicine_stocks`,`medicine_date_delivered`,`medicine_date_recieved`,`medicine_date_expiry`) 
VALUES (medicine_id,medicine_name,medicine_type,medicine_batch_delivered,medicine_stocks,medicine_date_delivered,medicine_date_recieved,medicine_date_expiry);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CreateMedicineTransaction` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateMedicineTransaction`(
																medicine_transaction_id BIGINT(20),
                                                                medicine_id BIGINT(20),
																medicine_transaction_type VARCHAR(255),
                                                                medicine_transaction_quantity INT,
                                                                medicine_transaction_date VARCHAR(255)
																)
BEGIN
INSERT INTO `db_scheduler_system`.`tbl_medicine_transaction` (`medicine_transaction_id`, `medicine_id`, `medicine_transaction_type`,`medicine_transaction_quantity`,`medicine_transaction_date`) 
VALUES (medicine_transaction_id,medicine_id, medicine_transaction_type,medicine_transaction_quantity,medicine_transaction_date);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CreateNurseAccount` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateNurseAccount`(
																nurse_id BIGINT(20),
																nurse_fullname VARCHAR(255),
                                                                nurse_address VARCHAR(255),
                                                                user_id INT(11)
                                                                )
BEGIN
INSERT INTO `db_scheduler_system`.`tbl_nurse` (`nurse_id`, `nurse_fullname`,`nurse_address`,`user_id`) 
VALUES (nurse_id,nurse_fullname,nurse_address,user_id);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CreatePatient` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreatePatient`(
																patient_id BIGINT(20),
                                                                room_id BIGINT(20),
																patient_fullname VARCHAR(255),
                                                                patient_address VARCHAR(255)
																)
BEGIN
INSERT INTO `db_scheduler_system`.`tbl_patient` (`patient_id`, `room_id`, `patient_fullname`,`patient_address`) 
VALUES (patient_id,room_id, patient_fullname,patient_address);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CreateRoom` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateRoom`(
																room_id BIGINT(20),
																room_number VARCHAR(255),
                                                                room_name VARCHAR(255),
                                                                room_description VARCHAR(255)
																)
BEGIN
INSERT INTO `db_scheduler_system`.`tbl_room` (`room_id`, `room_number`,`room_name`,`room_description`) 
VALUES (room_id,room_number,room_name,room_description);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CreateSchedule` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateSchedule`(
																schedule_id BIGINT(20),
																nurse_id BIGINT(20), 
                                                                room_id BIGINT(20), 
                                                                patient_id BIGINT(20),
                                                                schedule_title VARCHAR(255),
                                                                schedule_description VARCHAR(255),
                                                                schedule_time TIME, 
                                                                schedule_date DATE, 
                                                                schedule_status VARCHAR(255)
															)
BEGIN

INSERT INTO `db_scheduler_system`.`tbl_schedule` (`schedule_id`, `nurse_id`, `room_id`, `patient_id`, `schedule_title`, `schedule_description`, `schedule_time`, `schedule_date`, `schedule_status`)
VALUES (schedule_id, nurse_id, room_id, patient_id, schedule_title, schedule_description, schedule_time, schedule_date, schedule_status);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CreateSupplies` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateSupplies`(
																supplies_id BIGINT(20),
																supplies_name VARCHAR(255),
                                                                supplies_batch_delivered VARCHAR(255),
                                                                supplies_expiry VARCHAR(45),
                                                                supplies_date_purchase VARCHAR(255),
                                                                supplies_stocks BIGINT(20),
                                                                supplies_status VARCHAR(255),
                                                                supplies_remarks VARCHAR(255)
																)
BEGIN
INSERT INTO `db_scheduler_system`.`tbl_supplies` (`supplies_id`,`supplies_name`,`supplies_batch_delivered`,`supplies_expiry`,`supplies_date_purchase`,`supplies_stocks`,`supplies_status`,`supplies_remarks`) 
VALUES (supplies_id,supplies_name,supplies_batch_delivered,supplies_expiry,supplies_date_purchase,supplies_stocks,supplies_status,supplies_remarks);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CreateSuppliesTransaction` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateSuppliesTransaction`(
																supplies_transaction_id BIGINT(20),
                                                                supplies_id BIGINT(20),
                                                                supplies_transaction_quantity INT,
                                                                supplies_transaction_date VARCHAR(255)
																)
BEGIN
INSERT INTO `db_scheduler_system`.`tbl_supplies_transaction` (`supplies_transaction_id`, `supplies_id`,`supplies_transaction_quantity`,`supplies_transaction_date`) 
VALUES (supplies_transaction_id,supplies_id,supplies_transaction_quantity,supplies_transaction_date);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-10-17 21:12:49

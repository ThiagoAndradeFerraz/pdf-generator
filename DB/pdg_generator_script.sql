-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema pdf_generator
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema pdf_generator
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `pdf_generator` DEFAULT CHARACTER SET utf8 ;
USE `pdf_generator` ;

-- -----------------------------------------------------
-- Table `pdf_generator`.`contract_templates`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pdf_generator`.`contract_templates` (
  `template_id` INT NOT NULL AUTO_INCREMENT,
  `description` VARCHAR(15) NOT NULL,
  `template_path` VARCHAR(50) NULL,
  PRIMARY KEY (`template_id`),
  UNIQUE INDEX `description_UNIQUE` (`description` ASC) VISIBLE)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `pdf_generator`.`contract_templates`
-- -----------------------------------------------------
START TRANSACTION;
USE `pdf_generator`;
INSERT INTO `pdf_generator`.`contract_templates` (`template_id`, `description`, `template_path`) VALUES (DEFAULT, 'Car sale', 'car_sale.html');
INSERT INTO `pdf_generator`.`contract_templates` (`template_id`, `description`, `template_path`) VALUES (DEFAULT, 'Truck sale', 'truck_sale.html');
INSERT INTO `pdf_generator`.`contract_templates` (`template_id`, `description`, `template_path`) VALUES (DEFAULT, 'MotorCycle sale', 'motor_sale.html');

COMMIT;


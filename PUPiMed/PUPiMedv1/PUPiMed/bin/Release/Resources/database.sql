-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema dbmedicalclinic
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `dbmedicalclinic` ;

-- -----------------------------------------------------
-- Schema dbmedicalclinic
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `dbmedicalclinic` DEFAULT CHARACTER SET utf8 ;
USE `dbmedicalclinic` ;

-- -----------------------------------------------------
-- Table `dbmedicalclinic`.`tblAddress`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbmedicalclinic`.`tblAddress` ;

CREATE TABLE IF NOT EXISTS `dbmedicalclinic`.`tblAddress` (
  `strAddrCode` CHAR(20) NOT NULL DEFAULT 'ADDR-000' COMMENT '',
  `strAddrNum` CHAR(50) NOT NULL COMMENT '',
  `strAddrStreet` CHAR(50) NOT NULL COMMENT '',
  `strAddrTown` CHAR(50) NOT NULL COMMENT '',
  `strAddrCity` CHAR(50) NOT NULL COMMENT '',
  PRIMARY KEY (`strAddrCode`)  COMMENT '',
  UNIQUE INDEX `fk_unique` (`strAddrNum` ASC, `strAddrStreet` ASC, `strAddrTown` ASC, `strAddrCity` ASC)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dbmedicalclinic`.`tbldistributor`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbmedicalclinic`.`tbldistributor` ;

CREATE TABLE IF NOT EXISTS `dbmedicalclinic`.`tbldistributor` (
  `strDistCode` CHAR(20) NOT NULL COMMENT '',
  `strDistName` CHAR(100) NOT NULL COMMENT '',
  `strDistAddress` CHAR(20) NOT NULL COMMENT '',
  `strDistContactNo` CHAR(50) NOT NULL COMMENT '',
  `strDistEmail` CHAR(200) NOT NULL COMMENT '',
  PRIMARY KEY (`strDistCode`)  COMMENT '',
  INDEX `fkAddr_idx` (`strDistAddress` ASC)  COMMENT '',
  CONSTRAINT `fkAddr`
    FOREIGN KEY (`strDistAddress`)
    REFERENCES `dbmedicalclinic`.`tblAddress` (`strAddrCode`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbmedicalclinic`.`tblreceiving`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbmedicalclinic`.`tblreceiving` ;

CREATE TABLE IF NOT EXISTS `dbmedicalclinic`.`tblreceiving` (
  `strReceCode` CHAR(20) NOT NULL COMMENT '',
  `strReceDistCode` CHAR(20) NOT NULL COMMENT '',
  `datReceDate` DATE NOT NULL COMMENT '',
  PRIMARY KEY (`strReceCode`)  COMMENT '',
  UNIQUE INDEX `strAcquCode_UNIQUE` (`strReceCode` ASC)  COMMENT '',
  INDEX `fk_tblAcquisition_tblDistributor1_idx` (`strReceDistCode` ASC)  COMMENT '',
  CONSTRAINT `fk_tblAcquisition_tblDistributor1`
    FOREIGN KEY (`strReceDistCode`)
    REFERENCES `dbmedicalclinic`.`tbldistributor` (`strDistCode`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbmedicalclinic`.`tblmanufacturer`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbmedicalclinic`.`tblmanufacturer` ;

CREATE TABLE IF NOT EXISTS `dbmedicalclinic`.`tblmanufacturer` (
  `strManuCode` CHAR(20) NOT NULL COMMENT '',
  `strManuName` CHAR(100) NOT NULL COMMENT '',
  PRIMARY KEY (`strManuCode`)  COMMENT '')
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbmedicalclinic`.`tblitem`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbmedicalclinic`.`tblitem` ;

CREATE TABLE IF NOT EXISTS `dbmedicalclinic`.`tblitem` (
  `strItemCode` CHAR(20) NOT NULL COMMENT '',
  `strItemName` CHAR(50) NOT NULL COMMENT '',
  `strItemGeneric` CHAR(100) NOT NULL COMMENT '',
  `strItemManuCode` CHAR(20) NOT NULL COMMENT '',
  `intItemMin` INT(11) NOT NULL COMMENT '',
  `intItemMax` INT(11) NOT NULL COMMENT '',
  `intItemType` INT(11) NOT NULL COMMENT '',
  `boolItemDeleted` TINYINT(1) NULL DEFAULT '0' COMMENT '',
  `dtmItemDeleted` TIMESTAMP NULL DEFAULT NULL COMMENT '',
  `strItemDeleted` CHAR(50) NULL DEFAULT NULL COMMENT '',
  PRIMARY KEY (`strItemCode`)  COMMENT '',
  UNIQUE INDEX `strMediCode_UNIQUE` (`strItemCode` ASC)  COMMENT '',
  INDEX `fk_tblItem_tblManufacturer1_idx` (`strItemManuCode` ASC)  COMMENT '',
  CONSTRAINT `fk_tblItem_tblManufacturer1`
    FOREIGN KEY (`strItemManuCode`)
    REFERENCES `dbmedicalclinic`.`tblmanufacturer` (`strManuCode`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbmedicalclinic`.`tblReceDetail`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbmedicalclinic`.`tblReceDetail` ;

CREATE TABLE IF NOT EXISTS `dbmedicalclinic`.`tblReceDetail` (
  `strReceCode` CHAR(20) NOT NULL COMMENT '',
  `strReceItemCode` CHAR(20) NOT NULL COMMENT '',
  `intReceQty` INT NOT NULL COMMENT '',
  PRIMARY KEY (`strReceCode`, `strReceItemCode`)  COMMENT '',
  INDEX `fk_tblAcquDetail_tblAcquisition1_idx` (`strReceCode` ASC)  COMMENT '',
  INDEX `fk_tblAcquSupplyDetail_tblSupplies100_idx` (`strReceItemCode` ASC)  COMMENT '',
  CONSTRAINT `fk_tblAcquDetail_tblAcquisition1`
    FOREIGN KEY (`strReceCode`)
    REFERENCES `dbmedicalclinic`.`tblreceiving` (`strReceCode`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tblAcquSupplyDetail_tblSupplies100`
    FOREIGN KEY (`strReceItemCode`)
    REFERENCES `dbmedicalclinic`.`tblitem` (`strItemCode`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbmedicalclinic`.`tblbranch`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbmedicalclinic`.`tblbranch` ;

CREATE TABLE IF NOT EXISTS `dbmedicalclinic`.`tblbranch` (
  `strBranCode` CHAR(20) NOT NULL COMMENT '',
  `strBranDesc` CHAR(50) NOT NULL COMMENT '',
  PRIMARY KEY (`strBranCode`)  COMMENT '',
  UNIQUE INDEX `strCampCode_UNIQUE` (`strBranCode` ASC)  COMMENT '')
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbmedicalclinic`.`tblBranchDistribution`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbmedicalclinic`.`tblBranchDistribution` ;

CREATE TABLE IF NOT EXISTS `dbmedicalclinic`.`tblBranchDistribution` (
  `strBraDCode` CHAR(20) NOT NULL COMMENT '',
  `dtmBraDDate` DATETIME NOT NULL COMMENT '',
  PRIMARY KEY (`strBraDCode`)  COMMENT '',
  UNIQUE INDEX `strBraDistCode_UNIQUE` (`strBraDCode` ASC)  COMMENT '')
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbmedicalclinic`.`tblBranCampusDetail`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbmedicalclinic`.`tblBranCampusDetail` ;

CREATE TABLE IF NOT EXISTS `dbmedicalclinic`.`tblBranCampusDetail` (
  `strBraDCode` CHAR(20) NOT NULL COMMENT '',
  `strBraDBranCode` CHAR(20) NOT NULL COMMENT '',
  PRIMARY KEY (`strBraDCode`, `strBraDBranCode`)  COMMENT '',
  INDEX `fk_tblBranchDistributionCampusDetail_tblBranch1_idx` (`strBraDBranCode` ASC)  COMMENT '',
  CONSTRAINT `fk_tblBranchDistributionCampusDetail_tblBranch1`
    FOREIGN KEY (`strBraDBranCode`)
    REFERENCES `dbmedicalclinic`.`tblbranch` (`strBranCode`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tblBranchDistributionDetail_tblBranchDistribution1`
    FOREIGN KEY (`strBraDCode`)
    REFERENCES `dbmedicalclinic`.`tblBranchDistribution` (`strBraDCode`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbmedicalclinic`.`tblBranItemDetail`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbmedicalclinic`.`tblBranItemDetail` ;

CREATE TABLE IF NOT EXISTS `dbmedicalclinic`.`tblBranItemDetail` (
  `strBDIDBradCode` CHAR(20) NOT NULL COMMENT '',
  `strBDIDItemCode` CHAR(20) NOT NULL COMMENT '',
  `intBDIDQty` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`strBDIDBradCode`, `strBDIDItemCode`)  COMMENT '',
  INDEX `fk_tblBraDistItemDetail_tblBranchDistribution1_idx` (`strBDIDBradCode` ASC)  COMMENT '',
  INDEX `fk_tblBraDistItemDetail_tblSupplies11_idx` (`strBDIDItemCode` ASC)  COMMENT '',
  CONSTRAINT `fk_tblBraDistItemDetail_tblBranchDistribution11`
    FOREIGN KEY (`strBDIDBradCode`)
    REFERENCES `dbmedicalclinic`.`tblBranchDistribution` (`strBraDCode`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tblBraDistItemDetail_tblSupplies11`
    FOREIGN KEY (`strBDIDItemCode`)
    REFERENCES `dbmedicalclinic`.`tblitem` (`strItemCode`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbmedicalclinic`.`tblpatient`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbmedicalclinic`.`tblpatient` ;

CREATE TABLE IF NOT EXISTS `dbmedicalclinic`.`tblpatient` (
  `strPatiCode` CHAR(20) NOT NULL COMMENT '',
  `intPatiType` TINYINT(4) NOT NULL COMMENT '',
  `strPatiLastName` CHAR(50) NOT NULL COMMENT '',
  `strPatiFirstName` CHAR(50) NOT NULL COMMENT '',
  `strPatiMiddleName` CHAR(50) NOT NULL COMMENT '',
  `datPatiDOB` DATE NOT NULL COMMENT '',
  `intPatiGender` TINYINT(4) NOT NULL COMMENT '',
  `fltPatiHeight` FLOAT NULL DEFAULT NULL COMMENT '',
  `fltPatiWeight` FLOAT NULL DEFAULT NULL COMMENT '',
  `intPatiBloodType` TINYINT(4) NULL DEFAULT NULL COMMENT '',
  `strPatiContact` CHAR(20) NULL DEFAULT NULL COMMENT '',
  PRIMARY KEY (`strPatiCode`)  COMMENT '',
  UNIQUE INDEX `idxName` (`strPatiLastName` ASC, `strPatiFirstName` ASC, `strPatiMiddleName` ASC)  COMMENT '')
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbmedicalclinic`.`tbllogs`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbmedicalclinic`.`tbllogs` ;

CREATE TABLE IF NOT EXISTS `dbmedicalclinic`.`tbllogs` (
  `strLogsCode` CHAR(20) NOT NULL COMMENT '',
  `datLogsDatetime` DATETIME NOT NULL COMMENT '',
  `strLogsPatiCode` CHAR(20) NOT NULL COMMENT '',
  `strLogsComplaints` TEXT NOT NULL COMMENT '',
  `strLogsTreatment` TEXT NOT NULL COMMENT '',
  PRIMARY KEY (`strLogsCode`)  COMMENT '',
  UNIQUE INDEX `strDTRCode_UNIQUE` (`strLogsCode` ASC)  COMMENT '',
  INDEX `fk_tblDTR_tblPatient1_idx` (`strLogsPatiCode` ASC)  COMMENT '',
  CONSTRAINT `fk_tblDTR_tblPatient1`
    FOREIGN KEY (`strLogsPatiCode`)
    REFERENCES `dbmedicalclinic`.`tblpatient` (`strPatiCode`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `dbmedicalclinic`.`tbllogsdetail`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbmedicalclinic`.`tbllogsdetail` ;

CREATE TABLE IF NOT EXISTS `dbmedicalclinic`.`tbllogsdetail` (
  `strLogDLogsCode` CHAR(20) NOT NULL COMMENT '',
  `strLogDItemCode` CHAR(20) NOT NULL COMMENT '',
  `intLogDQty` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`strLogDLogsCode`, `strLogDItemCode`)  COMMENT '',
  INDEX `fk_tblDTRMedicineDetail_tblDTR1_idx` (`strLogDLogsCode` ASC)  COMMENT '',
  INDEX `fk_tblDTRMedicineDetail_tblMedicine1_idx` (`strLogDItemCode` ASC)  COMMENT '',
  CONSTRAINT `fk_tblDTRMedicineDetail_tblDTR1`
    FOREIGN KEY (`strLogDLogsCode`)
    REFERENCES `dbmedicalclinic`.`tbllogs` (`strLogsCode`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tblDTRMedicineDetail_tblMedicine1`
    FOREIGN KEY (`strLogDItemCode`)
    REFERENCES `dbmedicalclinic`.`tblitem` (`strItemCode`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

SET SQL_MODE = '';
GRANT USAGE ON *.* TO admin;
 DROP USER admin;
SET SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';
CREATE USER 'admin' IDENTIFIED BY 'admin';

GRANT SELECT, INSERT, TRIGGER ON TABLE `dbmedicalclinic`.* TO 'admin';
GRANT SELECT, INSERT, TRIGGER, UPDATE, DELETE ON TABLE `dbmedicalclinic`.* TO 'admin';

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `dbmedicalclinic`.`tblAddress`
-- -----------------------------------------------------
START TRANSACTION;
USE `dbmedicalclinic`;
INSERT INTO `dbmedicalclinic`.`tblAddress` (`strAddrCode`, `strAddrNum`, `strAddrStreet`, `strAddrTown`, `strAddrCity`) VALUES ('ADDR-000', '0', 'Default Street', 'Default Town', 'Default City');

COMMIT;


-- -----------------------------------------------------
-- Data for table `dbmedicalclinic`.`tbldistributor`
-- -----------------------------------------------------
START TRANSACTION;
USE `dbmedicalclinic`;
INSERT INTO `dbmedicalclinic`.`tbldistributor` (`strDistCode`, `strDistName`, `strDistAddress`, `strDistContactNo`, `strDistEmail`) VALUES ('SUPP-000', 'Default Supplier', 'ADDR-000', 'Default Contact', 'Default Email');

COMMIT;


-- -----------------------------------------------------
-- Data for table `dbmedicalclinic`.`tblreceiving`
-- -----------------------------------------------------
START TRANSACTION;
USE `dbmedicalclinic`;
INSERT INTO `dbmedicalclinic`.`tblreceiving` (`strReceCode`, `strReceDistCode`, `datReceDate`) VALUES ('RECEIV-000', 'SUPP-000', '0000-00-00');

COMMIT;


-- -----------------------------------------------------
-- Data for table `dbmedicalclinic`.`tblmanufacturer`
-- -----------------------------------------------------
START TRANSACTION;
USE `dbmedicalclinic`;
INSERT INTO `dbmedicalclinic`.`tblmanufacturer` (`strManuCode`, `strManuName`) VALUES ('MAN-000-PUP', 'Default Manufacturer');

COMMIT;


-- -----------------------------------------------------
-- Data for table `dbmedicalclinic`.`tblbranch`
-- -----------------------------------------------------
START TRANSACTION;
USE `dbmedicalclinic`;
INSERT INTO `dbmedicalclinic`.`tblbranch` (`strBranCode`, `strBranDesc`) VALUES ('PUP-000', 'Main');

COMMIT;


-- -----------------------------------------------------
-- Data for table `dbmedicalclinic`.`tblBranchDistribution`
-- -----------------------------------------------------
START TRANSACTION;
USE `dbmedicalclinic`;
INSERT INTO `dbmedicalclinic`.`tblBranchDistribution` (`strBraDCode`, `dtmBraDDate`) VALUES ('DIST-000', '0000-00-00-00-00-00');

COMMIT;


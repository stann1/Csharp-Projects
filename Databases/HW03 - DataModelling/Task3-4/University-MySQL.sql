SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `university` DEFAULT CHARACTER SET utf8 ;
USE `university` ;

-- -----------------------------------------------------
-- Table `university`.`faculties`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `university`.`faculties` (
  `idFaculty` INT(11) NOT NULL AUTO_INCREMENT ,
  `Name` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`idFaculty`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `university`.`departments`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `university`.`departments` (
  `idDepartment` INT(11) NOT NULL AUTO_INCREMENT ,
  `Name` VARCHAR(45) NOT NULL ,
  `idFaculty` INT(11) NULL DEFAULT NULL ,
  PRIMARY KEY (`idDepartment`) ,
  INDEX `FK_Faculties_Departments_idx` (`idFaculty` ASC) ,
  CONSTRAINT `FK_Faculties_Departments`
    FOREIGN KEY (`idFaculty` )
    REFERENCES `university`.`faculties` (`idFaculty` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `university`.`professors`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `university`.`professors` (
  `idProfessor` INT(11) NOT NULL AUTO_INCREMENT ,
  `Name` VARCHAR(45) NOT NULL ,
  `idDepartment` INT(11) NULL DEFAULT NULL ,
  PRIMARY KEY (`idProfessor`) ,
  INDEX `FK_Departments_Professors_idx` (`idDepartment` ASC) ,
  CONSTRAINT `FK_Departments_Professors`
    FOREIGN KEY (`idDepartment` )
    REFERENCES `university`.`departments` (`idDepartment` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `university`.`courses`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `university`.`courses` (
  `idCourse` INT(11) NOT NULL AUTO_INCREMENT ,
  `Name` VARCHAR(45) NOT NULL ,
  `idDepartment` INT(11) NULL DEFAULT NULL ,
  `idProfessor` INT(11) NULL DEFAULT NULL ,
  PRIMARY KEY (`idCourse`) ,
  INDEX `FK_fafa_idx` (`idDepartment` ASC) ,
  INDEX `FK_Professors_Courses_idx` (`idProfessor` ASC) ,
  CONSTRAINT `FK_Departments_Courses`
    FOREIGN KEY (`idDepartment` )
    REFERENCES `university`.`departments` (`idDepartment` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Professors_Courses`
    FOREIGN KEY (`idProfessor` )
    REFERENCES `university`.`professors` (`idProfessor` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `university`.`students`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `university`.`students` (
  `idStudent` INT(11) NOT NULL AUTO_INCREMENT ,
  `Name` VARCHAR(45) NOT NULL ,
  `idCourse` INT(11) NULL DEFAULT NULL ,
  `idFaculty` INT(11) NULL DEFAULT NULL ,
  PRIMARY KEY (`idStudent`) ,
  INDEX `FK_Faculties_Students_idx` (`idFaculty` ASC) ,
  INDEX `FK_Courses_Students_idx` (`idCourse` ASC) ,
  CONSTRAINT `FK_Faculties_Students`
    FOREIGN KEY (`idFaculty` )
    REFERENCES `university`.`faculties` (`idFaculty` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Courses_Students`
    FOREIGN KEY (`idCourse` )
    REFERENCES `university`.`courses` (`idCourse` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `university`.`titles`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `university`.`titles` (
  `idTitle` INT(11) NOT NULL AUTO_INCREMENT ,
  `Name` VARCHAR(45) NOT NULL ,
  `idProfessor` INT(11) NULL DEFAULT NULL ,
  PRIMARY KEY (`idTitle`) ,
  INDEX `FK_Professors_Titles_idx` (`idProfessor` ASC) ,
  CONSTRAINT `FK_Professors_Titles`
    FOREIGN KEY (`idProfessor` )
    REFERENCES `university`.`professors` (`idProfessor` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

USE `university` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

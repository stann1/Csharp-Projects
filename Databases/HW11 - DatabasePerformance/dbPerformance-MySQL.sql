CREATE SCHEMA IF NOT EXISTS ForumDb

USE ForumDb

-- creating a table
CREATE  TABLE IF NOT EXISTS ForumDb.`Logs` (
  `idLogs` INT(11) NOT NULL AUTO_INCREMENT ,
  `LogDate` DATETIME NOT NULL ,
  `LogText` NVARCHAR(200) NOT NULL ,
  PRIMARY KEY (`idLogs`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

-- creating the procedure for filling
DELIMITER //
CREATE PROCEDURE AddOneMilionLogs()
BEGIN
	DECLARE counter INT DEFAULT 0;
	DECLARE minDate datetime;
	DECLARE maxDate datetime;
	SET minDate = '1980-01-01 00:00:00';
	SET maxDate = '2014-01-01 00:00:00';	
	WHILE counter < 1000000 DO
		INSERT INTO Logs(LogDate, LogText)
		VALUES(TIMESTAMPADD(SECOND, FLOOR(RAND() * TIMESTAMPDIFF(SECOND, minDate, maxDate)), minDate),
		CONCAT('Text', CAST(counter as CHAR)));
		SET counter = counter + 1;
	END WHILE;
END //
DELIMITER ;

-- executing the procedure
CALL AddOneMilionLogs();

-- create partition table
CREATE TABLE IF NOT EXISTS ForumDb.`PartLogs`(
	idPartLogs int NOT NULL AUTO_INCREMENT,
	LogDate DATETIME NOT NULL ,
	LogText NVARCHAR(200) NOT NULL ,
	CONSTRAINT PK_Logs_LogId PRIMARY KEY(idPartLogs, LogDate)
) PARTITION BY RANGE(YEAR(LogDate))(
	PARTITION p0 VALUES LESS THAN (1990),
    PARTITION p2 VALUES LESS THAN (2000),
	PARTITION p3 VALUES LESS THAN (2010),
	PARTITION p4 VALUES LESS THAN MAXVALUE
);

DROP PROCEDURE IF EXISTS AddOneMilionLogs

-- creating the procedure for filling (easier to paste the same code, because passing Table name as parameter does not work for me)
DELIMITER //
CREATE PROCEDURE AddOneMilionLogs()
BEGIN
	DECLARE counter INT DEFAULT 0;
	DECLARE minDate datetime;
	DECLARE maxDate datetime;
	SET minDate = '1980-01-01 00:00:00';
	SET maxDate = '2014-01-01 00:00:00';	
	WHILE counter < 1000000 DO
		INSERT INTO PartLogs(LogDate, LogText)
		VALUES(TIMESTAMPADD(SECOND, FLOOR(RAND() * TIMESTAMPDIFF(SECOND, minDate, maxDate)), minDate),
		CONCAT('Text', CAST(counter as CHAR)));
		SET counter = counter + 1;
	END WHILE;
END //
DELIMITER ;

CALL AddOneMilionLogs();


-- now compare the query results of both tables:
RESET QUERY CACHE -- clears the cache

SELECT * FROM Logs
WHERE YEAR(LogDate) BETWEEN 2002 AND 2009;

SELECT * FROM PartLogs PARTITION(p3)
WHERE YEAR(LogDate) BETWEEN 2002 AND 2009;	
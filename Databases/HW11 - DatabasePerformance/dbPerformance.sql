CREATE TABLE Logs (
	LogId int NOT NULL IDENTITY,
	[Date] datetime NULL,
	[Text] nvarchar(200) NULL,
	CONSTRAINT PK_Logs PRIMARY KEY (LogId)
)
GO

CREATE PROC usp_AddOneMillionLogs
AS
	DECLARE @counter int = 1
	WHILE(@counter < 1000000)
	BEGIN
		DECLARE @Text nvarchar(200) = 
			'Text ' + CONVERT(nvarchar(200), @counter) + ': ' +	CONVERT(nvarchar(200), newid())
		DECLARE @Date datetime = 
			DATEADD(month, CONVERT(varbinary, newid()) % (50 * 12), getdate())
		INSERT INTO Logs([Date], [Text])
		VALUES (@Date, @Text)
		SET @counter = @counter + 1
	END
GO

EXEC usp_AddOneMillionLogs

--task 1------------------------------------------------------------------
CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT * FROM Logs
WHERE YEAR([Date]) BETWEEN 2000 AND 2022
-- result w/o cache: 230 000 entries in 5 sec
-- result with cache: 230 000 entries in 1 sec


--task 2------------------------------------------------------------------
CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

CREATE INDEX IDX_Logs_Date ON Logs([Date])

SELECT * FROM Logs
WHERE YEAR([Date]) BETWEEN 2000 AND 2022
-- result w/o cache: 3 sec

DROP INDEX Logs.IDX_Logs_Date


--task 3-----------------------------------------------------------------
CREATE FULLTEXT CATALOG LogsFullTextCatalog
WITH ACCENT_SENSITIVITY = OFF

CREATE FULLTEXT INDEX ON Logs([Text])
KEY INDEX PK_Logs
ON LogsFullTextCatalog
WITH CHANGE_TRACKING AUTO

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT * FROM Logs
WHERE CONTAINS([Text], 'Text')
-- result with full-text index (no cache): 7 sec
-- result with full-text index (cache): 5 sec

DROP FULLTEXT INDEX ON Logs
DROP FULLTEXT CATALOG LogsFullTextCatalog

SELECT * FROM Logs
WHERE [Text] LIKE 'Text%'
-- result without index: 9 sec
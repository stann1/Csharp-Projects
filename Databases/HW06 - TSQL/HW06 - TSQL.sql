-- task 1: Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance). 
-- Insert few records for testing. Write a stored procedure that selects the full names of all persons.
USE [master]
GO

CREATE DATABASE BankDB
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BankDB', FILENAME = N'C:\DBtests\BankDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BankDB_log', FILENAME = N'C:\DBtests\BankDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

-- inserting tables and data
USE [BankDB]
GO
CREATE TABLE Persons(
	PersonId int IDENTITY(1,1) NOT NULL,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	SSN nvarchar(50) NOT NULL,
	CONSTRAINT PK_Persons PRIMARY KEY(PersonId),
)
CREATE TABLE Accounts(
	AccountId int IDENTITY(1,1) NOT NULL,
	PersonId int NOT NULL,
	Balance money NULL,	
	CONSTRAINT PK_Accounts PRIMARY KEY(AccountId),
	CONSTRAINT FK_Accounts_Persons FOREIGN KEY(PersonId) REFERENCES Persons(PersonId)
)

INSERT INTO Persons(FirstName, LastName, SSN)
VALUES 
('Jack', 'Sparrow', '114n2398c'),
('Capt.', 'Crunch', '1122334455'),
('Pesho', 'Lekia', '224b2348d')

INSERT INTO Accounts(Balance, PersonId)
VALUES
(1240, 2), (3000, 1), (11000, 3)

-- creating store procedure
CREATE PROC dbo.usp_SelectFullNamesOfPersons
AS
	SELECT FirstName + ' ' + LastName AS FullName FROM Persons
GO

-- executing procedure
EXEC usp_SelectFullNamesOfPersons
GO

-- task 2: Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.
CREATE PROC dbo.usp_SelectPersonWithBalanceAbove(@amount money)
AS
	SELECT * FROM Persons p JOIN Accounts a
		ON p.PersonId = a.PersonId
	WHERE a.Balance >= @amount
GO

EXEC usp_SelectPersonWithBalanceAbove 2000

-- task 3: Create a function that accepts as parameters – sum, yearly interest rate and number of months. It should calculate and return the new sum. 
-- Write a SELECT to test whether the function works as expected.
ALTER FUNCTION dbo.ufn_CalculateInterest(@sum money, @yearlyInterest float, @numOfMonths int )
	RETURNS money
AS
BEGIN
	RETURN @sum * (1 + (@numOfMonths/12.0)*@yearlyInterest)
END

SELECT dbo.ufn_CalculateInterest(1000, 0.07, 18) AS SumWithInterest

-- task 4: Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month. 
-- It should take the AccountId and the interest rate as parameters.
CREATE PROC usp_SetOneMonthInterestOnAccount(@accountId int, @interest float)
AS
	UPDATE Accounts
	SET Balance = dbo.ufn_CalculateInterest(Balance, @interest, 1)
	WHERE AccountId = @accountId
GO

EXEC usp_SetOneMonthInterestOnAccount 2, 0.1

-- task 5: Add two more stored procedures WithdrawMoney( AccountId, money) and DepositMoney (AccountId, money) that operate in transactions.
CREATE PROC usp_WithdrawMoney(@accountId int, @amount money)
AS
	DECLARE @balance money = (
		SELECT Balance FROM Accounts
		WHERE AccountId = @accountId
	)
	IF(@balance >= @amount)
	BEGIN
		UPDATE Accounts
		SET Balance = Balance - @amount
		WHERE AccountId = @accountId
	END
	ELSE
	BEGIN
        RAISERROR ('Insufficient balance on account.', 16, 1)
        ROLLBACK TRAN
    END
GO

CREATE PROC usp_DepositMoney(@accountId int, @amount money)
AS
	IF(@amount > 0)
	BEGIN
		UPDATE Accounts
		SET Balance = Balance + @amount
		WHERE AccountId = @accountId
	END
	ELSE
	BEGIN
        RAISERROR ('Cannot deposit non-positive ammounts.', 16, 1)
        ROLLBACK TRAN
    END
	
GO

-- task 6: Create another table – Logs(LogID, AccountID, OldSum, NewSum). Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an account changes.
USE [BankDB]
GO
CREATE TABLE Logs(
	LogId int IDENTITY(1,1) NOT NULL,
	AccountId int NOT NULL,
	OldSum money NULL,
	NewSum money NOT NULL,
	CONSTRAINT PK_Logs PRIMARY KEY(LogId),
	CONSTRAINT FK_Logs_Accounts FOREIGN KEY(AccountId) REFERENCES Accounts(AccountId)
)

-- create trigger
CREATE TRIGGER tr_LogOnBalanceChange ON Accounts FOR UPDATE
AS
	DECLARE @accountId int = (SELECT AccountId FROM deleted)
	DECLARE @oldSum money = (SELECT Balance FROM deleted)
	DECLARE @newSum money = (SELECT Balance FROM inserted)

	INSERT INTO Logs(AccountId, OldSum, NewSum)
	VALUES (@accountId, @oldSum, @newSum)
GO

-- test trigger
EXEC usp_SetOneMonthInterestOnAccount 2, 0.1
EXEC usp_WithdrawMoney 3, 3000

-- task 7: Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or last name) and all town's names that are 
-- comprised of given set of letters. Example 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.
USE [TelerikAcademy]
GO
-- general function for searching in the name string
CREATE FUNCTION dbo.ufn_NameContainingLetters(@name NVARCHAR(50), @letters NVARCHAR(50))
    RETURNS bit
AS
	BEGIN
		DECLARE @contains bit = 1		
		DECLARE @curLetter NVARCHAR(1)
		DECLARE @counter INT = 1		
 
		WHILE(@counter <= LEN(@name))
				BEGIN
					SET @curLetter = SUBSTRING(@name, @counter, 1)
					IF (CHARINDEX(@curLetter, @letters) = 0)
						SET @contains = 0
					SET @counter = @counter + 1
				END
		RETURN @contains
	END
GO

-- functions for each name type
CREATE PROC dbo.ufn_FindFirstNamesFromString(@letters NVARCHAR(50))
AS
	SELECT FirstName FROM Employees
	WHERE 1 = (SELECT dbo.ufn_NameContainingLetters(FirstName, @letters))
GO

CREATE PROC dbo.ufn_FindMiddleNamesFromString(@letters NVARCHAR(50))
AS
	SELECT MiddleName FROM Employees
	WHERE 1 = (SELECT dbo.ufn_NameContainingLetters(MiddleName, @letters))
GO

CREATE PROC dbo.ufn_FindLastNamesFromString(@letters NVARCHAR(50))
AS
	SELECT LastName FROM Employees
	WHERE 1 = (SELECT dbo.ufn_NameContainingLetters(LastName, @letters))
GO

CREATE PROC dbo.ufn_FindTownNamesFromString(@letters NVARCHAR(50))
AS
	SELECT Name AS TownName FROM Towns
	WHERE 1 = (SELECT dbo.ufn_NameContainingLetters(Name, @letters))
GO

-- testing the procedures
EXEC ufn_FindFirstNamesFromString 'oistmiahf'
EXEC ufn_FindTownNamesFromString 'oistmiahf'

-- task 8: Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.
DECLARE empCursor CURSOR READ_ONLY FOR
SELECT e.FirstName, e.LastName, t.Name, o.FirstName, o.LastName
FROM Employees e
    INNER JOIN Addresses a
            ON a.AddressID = e.AddressID
    INNER JOIN Towns t
            ON t.TownID = a.TownID,
	Employees o
    INNER JOIN Addresses a1
            ON a1.AddressID = o.AddressID
    INNER JOIN Towns t1
            ON t1.TownID = a1.TownID          

OPEN empCursor
	DECLARE @firstName nvarchar(50), @lastName nvarchar(50), @town nvarchar(50), @firstName2 nvarchar(50), @lastName2 nvarchar(50)
	FETCH NEXT FROM empCursor INTO @firstName, @lastName, @town, @firstName2, @lastName2

	WHILE @@FETCH_STATUS = 0
	  BEGIN
		PRINT @firstName + ' ' + @lastName + ' -- ' + @town + ' -- ' + @firstName2 + ' ' + @lastName2
		FETCH NEXT FROM empCursor INTO @firstName, @lastName, @town, @firstName2, @lastName2
	  END

CLOSE empCursor
DEALLOCATE empCursor

-- task 10: Define a .NET aggregate function StrConcat that takes as input a sequence of strings and return a single string that consists of the input strings separated by ','. For example the following SQL statement should return a single string:
DECLARE @name nvarchar(MAX);
SET @name = N'';
SELECT @name += e.FirstName+N','
FROM Employees e
SELECT LEFT(@name,LEN(@name)-1);
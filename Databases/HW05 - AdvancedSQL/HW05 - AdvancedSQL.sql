-- task 1: Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company. 
-- Use a nested SELECT statement.
SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary = (SELECT MIN(Salary) FROM Employees)

-- task 2: Write a SQL query to find the names and salaries of the employees that have a salary 
-- that is up to 10% higher than the minimal salary for the company.
SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary <= (SELECT MIN(Salary)*1.1 FROM Employees)

-- task 3: Write a SQL query to find the full name, salary and department of the employees that
-- take the minimal salary in their department. Use a nested SELECT statement.
SELECT FirstName, LastName, Salary, d.Name
FROM Employees e
	JOIN Departments d
		ON e.DepartmentId = d.DepartmentId
WHERE Salary = (
    SELECT MIN(Salary) FROM Employees
    WHERE DepartmentId = d.DepartmentId
	)

-- task 4: Write a SQL query to find the average salary in the department #1.
SELECT AVG(Salary) AS [AvgSalary of Dept1] FROM Employees
WHERE DepartmentID = 1

-- task 5: Write a SQL query to find the average salary  in the "Sales" department.
SELECT AVG(Salary) AS [AvgSalary of Sales] 
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- task 6: Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(EmployeeID) AS [Employees in Sales] 
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- task 7: Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(EmployeeID) AS [Employees With Man] 
FROM Employees e
WHERE ManagerID IS NOT NULL

-- task 8: Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(EmployeeID) AS [Employees W/o Man] 
FROM Employees e
WHERE ManagerID IS NULL

-- task 9: Write a SQL query to find all departments and the average salary for each of them.
SELECT d.Name AS Department, AVG(Salary) AS [AvgSalary] 
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
ORDER BY AvgSalary DESC

-- task 10: Write a SQL query to find the count of all employees in each department and for each town.
SELECT d.Name AS Department, t.Name AS Town, COUNT(*) AS [Total Employees] 
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
	JOIN Addresses a
		ON e.AddressID = a.AddressID
	JOIN Towns t
		ON t.TownID = a.TownID
GROUP BY d.Name, t.Name

-- task 11: Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
SELECT m.FirstName, m.LastName FROM Employees e
	JOIN Employees m
		ON e.ManagerId = m.EmployeeId
GROUP BY m.EmployeeId, m.FirstName, m.LastName
HAVING COUNT(*) = 5

-- task 12: Write a SQL query to find all employees along with their managers. For employees that 
-- do not have manager display the value "(no manager)".
SELECT e.FirstName, e.LastName, 
	CASE 
		WHEN e.ManagerID IS NULL THEN '(no manager)' ELSE m.LastName 
	END 
	AS [Manager Name] 
FROM Employees e
	LEFT JOIN Employees m
		ON e.ManagerId = m.EmployeeId


-- task 13: Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. 
-- Use the built-in LEN(str) function.
SELECT * FROM Employees
WHERE LEN(LastName) = 5

-- task 14: Write a SQL query to display the current date and time in the following format 
-- "day.month.year hour:minutes:seconds:milliseconds". Search in  Google to find how to format dates in SQL Server.
SELECT CONVERT(nvarchar(30), GETDATE(), 113)

-- task 15: Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
-- Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint. 
-- Define the primary key column as identity to facilitate inserting records. Define unique constraint to avoid repeating usernames. 
-- Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE Users(
	 UserId int IDENTITY(1,1) NOT NULL,
	 UserName nvarchar(50) NOT NULL,
	 Password nvarchar(50) NOT NULL CHECK(LEN(Password)>=5),
	 FullName nvarchar(50) NULL,
	 LastLogin datetime NOT NULL,
	 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED(UserId ASC),	
	 CONSTRAINT [UQ_Users] UNIQUE NONCLUSTERED(UserName ASC)	
)

--task 16: Write a SQL statement to create a view that displays the users from the Users table that have been in the system today. 
--Test if the view works correctly.
CREATE VIEW [dbo].UsersLoggedToday
AS
SELECT * FROM Users
WHERE DAY(LastLogin) = DAY(GETDATE())

INSERT Users VALUES ('stavri', '12345', 'Bai Stavri', GETDATE())
INSERT Users VALUES ('mun12', '67890', 'Bai Muncho', DATEADD(DAY, -1, GETDATE()))
SELECT * FROM UsersLoggedToday;

--task 17: Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint). Define primary key and identity column.
CREATE TABLE Groups (
	GroupId int IDENTITY,
	Name nvarchar(50) NOT NULL,
	CONSTRAINT PK_Group PRIMARY KEY(GroupId),
	CONSTRAINT UQ_Name UNIQUE(Name)
)

--task 18: Write a SQL statement to add a column GroupID to the table Users. Fill some data in this new column and as well in the Groups table.
--Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.
ALTER TABLE Users
	ADD GroupId int NULL

ALTER TABLE Users
	ADD CONSTRAINT FK_Users_Groups FOREIGN KEY(GroupId)
	REFERENCES Groups(GroupId) 

--task 19: Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Users (Username, Password, FullName, LastLogin)
VALUES ('sty134', 'qwerty', 'Stamat Shopa', GETDATE()), 
	   ('mfmfm', 'qwerty123', 'Bad Mofo', DATEADD(DAY, -10, GETDATE()))

INSERT INTO Groups (Name)
VALUES ('Playas'), ('AutoDzhambaz')

--task 20: Write SQL statements to update some of the records in the Users and Groups tables.
UPDATE Users
SET FullName = 'Stamat Phd.' WHERE FullName LIKE 'Stamat%'
UPDATE Groups
SET Name = 'MnooUmni' WHERE Name LIKE 'Auto%'

--task 21: Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE FROM Users
WHERE FullName LIKE '%Muncho%'
DELETE FROM Groups
WHERE Name = 'MnooUmni'

--task 22: Write SQL statements to insert in the Users table the names of all employees from the Employees table. 
--Combine the first and last names as a full name. For username use the first letter of the first name + the last name (in lowercase). 
--Use the same for the password, and NULL for last login time.
INSERT INTO Users(UserName, Password, FullName, LastLogin)
SELECT 
	 LOWER(LEFT(FirstName, 3)) + LOWER(LastName),				--the first 3 characters are used because of the constraint in task 15						
	 LOWER(LEFT(FirstName, 1)) + LOWER(LastName) + '12345',        --the number is added because of the constraint in task 15
	 FirstName + ' ' + LastName,
	 NULL
FROM Employees

--task 23: Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.
UPDATE Users
SET Password = NULL WHERE LastLogin < CONVERT(DATE, '10.03.2010', 104)

--task 24: Write a SQL statement that deletes all users without passwords (NULL password).
DELETE FROM Users
WHERE Password IS NULL

--task 25: Write a SQL query to display the average employee salary by department and job title.
SELECT d.Name, e.JobTitle, AVG(Salary) AS AvgSalary
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY d.Name

--task 26: Write a SQL query to display the minimal employee salary by department and job title along with the name of
--some of the employees that take it.
SELECT d.Name, e.JobTitle, e.FirstName + ' ' + e.LastName as FullName, e.Salary AS MinSalary
FROM Employees e
	JOIN Departments d 
		ON e.DepartmentID = d.DepartmentID
WHERE e.Salary IN (
	SELECT MIN(em.Salary)
		FROM Employees em
		JOIN Departments de on em.DepartmentID = de.DepartmentID
		WHERE d.DepartmentID = de.DepartmentID AND e.JobTitle = em.JobTitle
		GROUP BY de.Name, em.JobTitle
)

--task 27: Write a SQL query to display the town where maximal number of employees work.
SELECT TOP 1  t.Name AS TownName, COUNT(*) AS EmployeesFrom
FROM Employees e
	JOIN Addresses a
		ON e.AddressID = a.AddressID
	JOIN Towns t 
		ON a.TownID = t.TownID
GROUP BY t.TownID, t.Name
ORDER BY COUNT(*) DESC

--task 28: Write a SQL query to display the number of managers from each town.
SELECT t.Name AS TownName, COUNT(ManagerID) AS ManagersFrom
FROM Employees e
	JOIN Addresses a
		ON e.AddressID = a.AddressID
	JOIN Towns t 
		ON a.TownID = t.TownID
WHERE e.EmployeeID IN (SELECT DISTINCT ManagerID from Employees)
GROUP BY t.Name

--task 29: Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments). 
--Don't forget to define  identity, primary key and appropriate foreign key. 
--Issue few SQL statements to insert, update and delete of some data in the table.
--Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers. For each change keep the old record data, 
--the new record data and the command (insert / update / delete).
CREATE TABLE WorkHours(
	EmployeeID int IDENTITY,
	[Date] datetime,
	Task nvarchar(50),
	[Hours] int,
	Comment nvarchar(50),
	CONSTRAINT PK_WorkHours PRIMARY KEY(EmployeeID),
	CONSTRAINT FK_WorkHours_Employees FOREIGN KEY(EmployeeID) REFERENCES Employees(EmployeeID)
)

--task 30: Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables. At the end rollback the transaction.
--task 31: Start a database transaction and drop the table EmployeesProjects. Now how you could restore back the lost table data?
--task 32: Find how to use temporary tables in SQL Server. Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table.





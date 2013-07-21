-- task 4: Write a SQL query to find all information about all departments (use "TelerikAcademy" database).--
SELECT * FROM Departments

-- task 5:  Write a SQL query to find all department names. --
SELECT Name FROM Departments

-- task 6: Write a SQL query to find the salary of each employee. --
SELECT FirstName, LastName, Salary FROM Employees

-- task 7: Write a SQL to find the full name of each employee.
SELECT FirstName, MiddleName, LastName FROM Employees

-- task 8: Write a SQL query to find the email addresses of each employee (by his first and last name). 
-- Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". 
-- The produced column should be named "Full Email Addresses".--
SELECT FirstName, LastName, FirstName + '.' + LastName + '@telerik.com' as [Full Email Addresses] FROM Employees

-- task 9: Write a SQL query to find all different employee salaries.
SELECT DISTINCT Salary FROM Employees

-- task 10: Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
SELECT * FROM Employees
WHERE JobTitle = 'Sales Representative'

-- task 11: Write a SQL query to find the names of all employees whose first name starts with "SA".
SELECT * FROM Employees
WHERE FirstName LIKE 'SA%'

-- task 12: Write a SQL query to find the names of all employees whose last name contains "ei".
SELECT * FROM Employees
WHERE LastName LIKE '%ei%'

-- task 13: Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
SELECT * FROM Employees
WHERE Salary BETWEEN 20000 AND 30000

-- task 14: Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
SELECT * FROM Employees
WHERE Salary IN (25000, 14000, 12500, 23600)
ORDER BY Salary

-- task 15: Write a SQL query to find all employees that do not have manager.
SELECT * FROM Employees
WHERE ManagerID IS NULL

-- task 16: Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
SELECT * FROM Employees
WHERE Salary >= 50000
ORDER BY Salary

-- task 17: Write a SQL query to find the top 5 best paid employees.
SELECT TOP 5 Salary, FirstName, LastName FROM Employees
ORDER BY Salary DESC

-- task 18: Write a SQL query to find all employees along with their address. Use inner join with ON clause.
SELECT e.*, a.AddressText 
FROM Employees AS e INNER JOIN Addresses AS a
ON e.AddressID = a.AddressID

-- task 19: Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
SELECT e.*, a.AddressText 
FROM Employees AS e, Addresses AS a
WHERE e.AddressID = a.AddressID

-- task 20: Write a SQL query to find all employees along with their manager.
SELECT e.LastName AS EmployeeLastName, m.EmployeeId AS ManagerId, m.LastName AS ManagerLastName
FROM Employees AS e INNER JOIN Employees AS m
ON e.ManagerID = m.EmployeeID

-- task 21: Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.
SELECT e.LastName AS EmployeeLastName, m.EmployeeId AS ManagerId, m.LastName AS ManagerLastName,
a.AddressText AS [Home Address] 
FROM Employees AS e 
INNER JOIN Employees AS m
	ON e.ManagerID = m.EmployeeID
INNER JOIN Addresses AS a
	ON e.AddressID = a.AddressID 

-- task 22: Write a SQL query to find all departments and all region names, country names and city names as a single list. Use UNION.
-- There is no table with countries/regions!
SELECT Name AS DeptName FROM Departments
UNION
SELECT Name AS TownName FROM Towns

-- task 23: Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. User right outer join. Rewrite the query to use left outer join.
-- right
SELECT e.LastName AS EmployeeLastName, m.EmployeeId AS ManagerId, m.LastName AS ManagerLastName
FROM Employees m RIGHT JOIN Employees e
ON e.ManagerID = m.EmployeeID

-- left
SELECT e.LastName AS EmployeeLastName, m.EmployeeId AS ManagerId, m.LastName AS ManagerLastName
FROM Employees e LEFT JOIN Employees m
ON e.ManagerID = m.EmployeeID

-- task 24: Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2000.
-- note: there is no employee from these departments, who is hired in the requested year - so I changed the dates in the SQL
SELECT e.*, d.Name AS Department
FROM Employees e 
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN ('Sales', 'Finance') AND (e.HireDate BETWEEN '1995-1-1' AND '2003-12-31')



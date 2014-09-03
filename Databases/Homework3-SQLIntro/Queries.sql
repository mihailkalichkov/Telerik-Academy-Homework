--Task4 Write a SQL query to find all information about all departments (use "TelerikAcademy" database).

SELECT *
FROM TelerikAcademy.dbo.Departments

--Task5 Write a SQL query to find all department names.

SELECT Name
FROM TelerikAcademy.dbo.Departments

--Task6 Write a SQL query to find the salary of each employee.

SELECT FirstName + ' ' + LastName AS FullName , Salary
FROM TelerikAcademy.dbo.Employees

--Task7 Write a SQL to find the full name of each employee.

SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS FullName
FROM TelerikAcademy.dbo.Employees
WHERE MiddleName IS NOT NULL
UNION
SELECT FirstName + ' ' + LastName AS FullName
FROM TelerikAcademy.dbo.Employees
WHERE MiddleName IS NULL

/*Task8 Write a SQL query to find the email addresses of each employee (by his first and last name).
 Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com".
 The produced column should be named "Full Email Addresses".*/

SELECT FirstName + '.' + LastName + '@telerik.com' AS [Full Email Addresses]
FROM TelerikAcademy.dbo.Employees

--Task9 Write a SQL query to find all different employee salaries.

SELECT DISTINCT Salary
FROM TelerikAcademy.dbo.Employees

--Task10 Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

SELECT *
FROM TelerikAcademy.dbo.Employees
WHERE JobTitle = 'Sales Representative'

--Task 11 Write a SQL query to find the names of all employees whose first name starts with "SA".

SELECT FirstName + LastName as Name
FROM TelerikAcademy.dbo.Employees
WHERE FirstName LIKE 'SA%'

--Task 12 Write a SQL query to find the names of all employees whose last name contains "ei".

SELECT FirstName + LastName as Name
FROM TelerikAcademy.dbo.Employees
WHERE LastName LIKE '%ei%'

--Task 13 Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

SELECT FirstName + LastName as Name, Salary
FROM TelerikAcademy.dbo.Employees
WHERE Salary BETWEEN 20000 AND 30000

--Task 14 Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

SELECT FirstName + LastName as Name, Salary
FROM TelerikAcademy.dbo.Employees
WHERE Salary IN (25000, 14000, 12500, 23600)

--Task 15 Write a SQL query to find all employees that do not have manager.

SELECT FirstName + LastName as Name, Salary
FROM TelerikAcademy.dbo.Employees
WHERE ManagerID IS NULL

/*Task 16 Write a SQL query to find all employees that have salary more than 50000.
Order them in decreasing order by salary.*/

SELECT FirstName + LastName as Name, Salary
FROM TelerikAcademy.dbo.Employees
WHERE Salary > 50000
ORDER BY Salary Desc

--Task 17 Write a SQL query to find the top 5 best paid employees.

SELECT TOP 5 FirstName + LastName as Name, Salary
FROM TelerikAcademy.dbo.Employees
ORDER BY Salary Desc

/*Task 18 Write a SQL query to find all employees along with their address.
Use inner join with ON clause.*/

SELECT FirstName + ' ' + LastName as Name, addr.AddressText as Address
FROM TelerikAcademy.dbo.Employees emp
JOIN TelerikAcademy.dbo.Addresses addr ON emp.AddressID = addr.AddressID

/*Task 19 Write a SQL query to find all employees and their address.
Use equijoins (conditions in the WHERE clause).*/

SELECT FirstName + ' ' + LastName as Name, addr.AddressText as Address
FROM TelerikAcademy.dbo.Employees emp , TelerikAcademy.dbo.Addresses addr
WHERE emp.AddressID = addr.AddressID

--Task 20 Write a SQL query to find all employees along with their manager.

SELECT employee.FirstName + ' ' + employee.LastName as Name, manager.FirstName + ' ' + manager.LastName as Manager
FROM TelerikAcademy.dbo.Employees employee
JOIN TelerikAcademy.dbo.Employees manager ON employee.ManagerID = manager.EmployeeID

/*Task 21 Write a SQL query to find all employees, along with their manager and their address.
Join the 3 tables: Employees e, Employees m and Addresses a.*/

SELECT employee.FirstName + ' ' + employee.LastName as Name, manager.FirstName + ' ' + manager.LastName as Manager, a.AddressText as Address
FROM TelerikAcademy.dbo.Employees employee
JOIN TelerikAcademy.dbo.Employees manager ON employee.ManagerID = manager.EmployeeID
JOIN TelerikAcademy.dbo.Addresses a ON employee.AddressID = a.AddressID

--Task 22 Write a SQL query to find all departments and all town names as a single list. Use UNION.

SELECT Name FROM TelerikAcademy.dbo.Departments
UNION 
SELECT Name FROM TelerikAcademy.dbo.Towns

/*Task 23 Write a SQL query to find all the employees and the manager for each of them along with
the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.*/

SELECT emp.FirstName + ' ' + emp.LastName AS EmployeeName, m.FirstName + ' ' + m.LastName AS Manager
FROM TelerikAcademy.dbo.Employees m
RIGHT JOIN TelerikAcademy.dbo.Employees emp ON emp.ManagerID = m.EmployeeID

SELECT emp.FirstName + ' ' + emp.LastName AS EmployeeName, m.FirstName + ' ' + m.LastName AS Manager
FROM TelerikAcademy.dbo.Employees emp
LEFT JOIN TelerikAcademy.dbo.Employees m ON emp.ManagerID = m.EmployeeID

/*Task 24 Write a SQL query to find the names of all employees from the departments
"Sales" and "Finance" whose hire year is between 1995 and 2005*/

SELECT emp.FirstName + ' ' + emp.LastName AS EmployeeName, d.Name, emp.HireDate
FROM TelerikAcademy.dbo.Employees emp
JOIN TelerikAcademy.dbo.Departments d ON emp.DepartmentID = d.DepartmentID
WHERE d.Name IN ('Sales', 'Finance') AND (YEAR(emp.HireDate) > 1995 AND YEAR(emp.HireDate) < 2005)
-- Part 1a
SELECT *
FROM Customers
WHERE Country = 'Finland'

-- Part 1b
SELECT CustomerID
FROM Customers
WHERE CompanyName = 'Que Delícia'

SELECT *
FROM Orders
WHERE CustomerID = 'QUEDE'

-- Part 1c
SELECT *
FROM Employees
WHERE City = 'London' AND Country = 'UK'


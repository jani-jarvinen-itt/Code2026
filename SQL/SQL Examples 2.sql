-- Part 2a
SELECT COUNT(*)
FROM Customers

-- Part 2b
SELECT ProductName, UnitPrice, UnitsInStock, UnitPrice * UnitsInStock
FROM Products

SELECT SUM(UnitPrice * UnitsInStock)
FROM Products

-- Part 2c
SELECT ProductID, ProductName
FROM Products
WHERE ProductName = 'Tofu'

SELECT SUM(UnitPrice * Quantity * (1 - Discount))
FROM [Order Details]
WHERE ProductID = 14 OR ProductID = 74


SELECT *
FROM [Order Details]
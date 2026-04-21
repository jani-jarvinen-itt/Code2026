-- example of INNER JOIN
SELECT Orders.OrderID, Customers.CompanyName, Orders.OrderDate
FROM Orders
JOIN Customers ON Orders.CustomerID = Customers.CustomerID

-- example without JOINs
SELECT Orders.OrderID, Customers.CompanyName, Orders.OrderDate
FROM Orders, Customers
WHERE Orders.CustomerID = Customers.CustomerID

-- products and Categories
SELECT ProductID, ProductName, CategoryName, UnitPrice
FROM Products
JOIN Categories ON Products.CategoryID = Categories.CategoryID

-- customers and order counts
SELECT COUNT(*) AS OrderCount
FROM Orders
WHERE CustomerID = 'ALFKI'






SELECT CompanyName, COUNT(*)
FROM Customers
JOIN Orders ON Orders.CustomerID = Customers.CustomerID
GROUP BY Orders.CustomerID
















-- Updating data example
UPDATE Orders
SET ShipCountry = 'Sweden'
WHERE OrderID = 13724

-- Updating data example 2
UPDATE [Order Details]
SET Quantity = 8
WHERE OrderID = 10248 AND Quantity = 5

-- Updating data example 3
UPDATE [Order Details]
SET Discount = 0.10
WHERE OrderID = 10248 AND Quantity = 8

-- Delete an ORDER
DELETE FROM Orders
WHERE OrderID = 12345

-- Delete a Customer
DELETE FROM Customers
WHERE CustomerID = 'MYNEW'

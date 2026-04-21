SELECT *
FROM Orders
WHERE CustomerID = (SELECT CustomerID
                    FROM Customers
                    WHERE CompanyName = 'Que Delícia')

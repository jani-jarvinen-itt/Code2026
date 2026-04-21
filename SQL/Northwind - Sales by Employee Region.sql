SELECT 
    r.RegionDescription AS Region,
    SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) AS TotalSales
FROM Orders o
JOIN "Order Details" od 
    ON o.OrderID = od.OrderID
JOIN Employees e 
    ON o.EmployeeID = e.EmployeeID
JOIN EmployeeTerritories et 
    ON e.EmployeeID = et.EmployeeID
JOIN Territories t 
    ON et.TerritoryID = t.TerritoryID
JOIN Regions r 
    ON t.RegionID = r.RegionID
WHERE strftime('%Y', o.OrderDate) = '2016'
GROUP BY r.RegionDescription
ORDER BY TotalSales DESC;
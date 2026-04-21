import sqlite3
import matplotlib.pyplot as plt

# Connect to SQLite database
conn = sqlite3.connect("northwind.db")
cursor = conn.cursor()

# SQL query to calculate total sales per region for a specific year
query = """
WITH EmployeeRegion AS (
    SELECT DISTINCT 
        e.EmployeeID,
        r.RegionDescription
    FROM Employees e
    JOIN EmployeeTerritories et 
        ON e.EmployeeID = et.EmployeeID
    JOIN Territories t 
        ON et.TerritoryID = t.TerritoryID
    JOIN Regions r 
        ON t.RegionID = r.RegionID
)
SELECT 
    er.RegionDescription AS Region,
    SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) AS TotalSales
FROM Orders o
JOIN "Order Details" od 
    ON o.OrderID = od.OrderID
JOIN EmployeeRegion er 
    ON o.EmployeeID = er.EmployeeID
WHERE strftime('%Y', o.OrderDate) = ?
GROUP BY er.RegionDescription
ORDER BY TotalSales DESC;
"""

# Execute query with year parameter
year = "2016"
cursor.execute(query, (year,))

# Fetch results
rows = cursor.fetchall()

# Close connection
conn.close()

# Separate data into lists
regions = [row[0] for row in rows]
sales = [row[1] for row in rows]

# Plot
plt.figure()
plt.bar(regions, sales)

plt.xlabel("Region")
plt.ylabel("Total Sales")
plt.title(f"Total Sales per Region ({year})")

plt.xticks(rotation=45)
plt.tight_layout()

plt.show()

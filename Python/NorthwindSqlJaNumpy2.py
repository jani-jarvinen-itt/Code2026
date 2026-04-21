import sqlite3
import numpy as np

# Connect to SQLite database
conn = sqlite3.connect("northwind.db")
cursor = conn.cursor()

# Fetch Customers
cursor.execute("SELECT CustomerID, CompanyName FROM Customers")
customers_data = cursor.fetchall()

# Fetch Orders
cursor.execute("SELECT OrderID, CustomerID FROM Orders")
orders_data = cursor.fetchall()

conn.close()

# Convert to NumPy arrays
customers = np.array(customers_data, dtype=[('CustomerID', 'U10'), ('CompanyName', 'U100')])
orders = np.array(orders_data, dtype=[('OrderID', 'i4'), ('CustomerID', 'U10')])

# Extract CustomerIDs from orders
order_customer_ids = orders['CustomerID']

# Count orders per customer using NumPy
unique_customers, counts = np.unique(order_customer_ids, return_counts=True)

# Sort customers by order count (descending)
sorted_indices = np.argsort(counts)[::-1]

top_n = 5
top_customers_ids = unique_customers[sorted_indices][:top_n]
top_counts = counts[sorted_indices][:top_n]

# Match with customer names
# Create a dictionary for quick lookup
customer_dict = {cust['CustomerID']: cust['CompanyName'] for cust in customers}

# Print results
print("Top 5 customers by number of orders:")
for cust_id, count in zip(top_customers_ids, top_counts):
    print(f"{customer_dict.get(cust_id, 'Unknown')} ({cust_id}) - {count} orders")

import matplotlib.pyplot as plt
import pandas as pd

# Load the Excel file
df = pd.read_excel("Forestfires.xlsx", skiprows=3, usecols="B:N")

# Calculate the frequencies of fires by day
counts = df["day"].value_counts()
print(counts)

# Reorder the counts to match the order of days
day_order = ["mon", "tue", "wed", "thu", "fri", "sat", "sun"]
counts = counts.reindex(day_order)
print(counts)

# Create a bar chart
plt.figure()
plt.bar(counts.index, counts.values)

plt.xlabel("Day of the Week")
plt.ylabel("Number of Fires")
plt.title("Number of Forest Fires by Day")

plt.show()

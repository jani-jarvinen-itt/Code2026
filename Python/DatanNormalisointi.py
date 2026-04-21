import random

data_length = 100000
data = []
for i in range(data_length):
    data.append(random.randint(1, 10000))

# print(data[:100])
print(f"Created {data_length} data points.")

# normalize the data between -2..+2
mean = sum(data) / len(data)
std = (sum((x - mean)**2 for x in data) / len(data))**0.5
print(f"Mean = {mean}.")
print(f"Std = {std}.")
normalized = []
for x in data:
    normalized.append((x - mean) / std)

# print(normalized[:100])
print(f"Max = {max(normalized)}.")
print(f"Min = {min(normalized)}.")

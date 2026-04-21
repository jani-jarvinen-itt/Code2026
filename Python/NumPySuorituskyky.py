import numpy as np
import random
import time

print("Starting to create random data...")
data_length = 50000000 # fifty million
data = []
for i in range(data_length):
    data.append(random.randint(1, 10000))

# print(data[:100])
print(f"Created {data_length} data points.")

# normalize the data between -2..+2
print("------ PYTHON LOOP ------")
start = time.time()
mean = sum(data) / len(data)
std = (sum((x - mean)**2 for x in data) / len(data))**0.5
normalized = []
for x in data:
    normalized.append((x - mean) / std)
end = time.time()
print("Loop took:", end - start)

# print(normalized[:100])
print(f"Max = {max(normalized)}.")
print(f"Min = {min(normalized)}.")
print()

# ---------------------------
print("------ NUMPY ------")
arr = np.array(data)

start = time.time()
normalized = (arr - arr.mean()) / arr.std()
end = time.time()
print("Vectorization took:", end - start)
# print(normalized[:100])
print(f"Max = {max(normalized)}.")
print(f"Min = {min(normalized)}.")

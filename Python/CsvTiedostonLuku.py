filename = "Data.csv"

# read the CSV file line by line and print all lines
# where the column 0 value is larger than 50
with open(filename, "r") as file:
    for line in file:
        parts = line.strip().split(",")
        if int(parts[0]) > 50:
            print(line.strip())

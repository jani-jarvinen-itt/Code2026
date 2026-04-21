import sqlite3

# yhteyden avaus
con = sqlite3.connect("Northwind.db")

# tietojen haku ja tulostus
cur = con.cursor()
cur.execute("SELECT * FROM Customers WHERE Country='Finland'")
for rivi in cur:
    print(rivi)

# yhteyden sulkeminen
con.close()
print("Tietokantayhteys suljettu.")

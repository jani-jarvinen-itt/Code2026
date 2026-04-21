import sqlite3

# yhteyden avaus
con = sqlite3.connect("Esimerkki.db")

# tietokantataulun luonti ja tietojen lisääminen
cur = con.cursor()
cur.execute("CREATE TABLE henkilöt(nimi TEXT, ikä INTEGER)")
cur.execute("INSERT INTO henkilöt VALUES('Matti', 30)")
cur.execute("INSERT INTO henkilöt VALUES('Maija', 27)")
con.commit()
print("Tietokantataulu luotu ja tiedot lisätty.")

# tietojen haku ja tulostus
cur.execute("SELECT * FROM henkilöt")
for rivi in cur:
    print(rivi)

# yhteyden sulkeminen
con.close()
print("Tietokantayhteys suljettu.")

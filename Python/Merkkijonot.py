syöte = "ABCDEFGHIJK"

# 1. Tulosta merkkijonon pituus ruudulle
print(len(syöte))

# 2. Tulosta merkkijono kokonaan isoin kirjaimin (all caps)
print(syöte.upper())

# 3. Tulosta merkkijono kolmannesta merkistä eteenpäin
print(syöte[2:])

# 4. Tulosta merkkijono viidenteen merkkiin saakka
print(syöte[:5])

# 5. Tulosta merkkijonon joka toinen kirjain
print(syöte[::2])

# 6. Vertaile, onko merkkijono sama myös väärinpäin, eli palindromi.
väärinpäin = syöte[::-1]
if syöte == väärinpäin:
    print("Merkkijono on palindromi.")

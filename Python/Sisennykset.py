def oma_funktio(luku: float):
    print("Tämä on oma funktio")


luku_a = 100
luku_b = 200

if luku_a < luku_b:
    print("Luku A on pienempi kuin Luku B")
    if luku_a < 50:
        print("Luku A on myös pienempi kuin 50")
    else:
        print("Luku A on suurempi tai yhtä suuri kuin 50")

luku_a = "ABCD"
oma_funktio("ABCD")
print(luku_a)

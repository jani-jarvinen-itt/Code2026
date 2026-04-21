import random

# Alustukset
arvauskertoja = 0

# Kone arpoo luvun 1..20.
oikea = random.randint(1, 20)
# print(oikea)

while arvauskertoja < 3:
    arvauskertoja += 1

    # Kysytään käyttäjältä arvaus
    print("Anna arvauksesi välillä 1-20:")
    arvaus = int(input())

    # Oliko arvaus oikein?
    if arvaus == oikea:
        print("Jee, arvasit oikein, voitit pelin!")

        print("Anna nimesi pelitilastoja varten:")
        nimi = input()

        tiedosto = open("Tulokset.txt", "a")
        rivi = f"{nimi},{arvauskertoja}\n"
        tiedosto.write(rivi)
        tiedosto.close()

        break

    elif arvaus < oikea:
        print("Oikea luku on suurempi.")
    else:
        print("Oikea luku on pienempi.")

print("Peli on päättynyt.")

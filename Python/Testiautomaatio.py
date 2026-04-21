def laske_summa(a, b):
    return a + b

# testi 1
odotettu_tulos = 5
tulos = laske_summa(2, 3)
if tulos == odotettu_tulos:
    print("PASS: Testi 1 onnistui!")
else:
    print("FAIL: Testi 1 epäonnistui. Odotettu:", odotettu_tulos, "Saatu:", tulos)

# testi 2
odotettu_tulos = -5
tulos = laske_summa(-2, -3)
if tulos == odotettu_tulos:
    print("PASS: Testi 2 onnistui!")
else:
    print("FAIL: Testi 2 epäonnistui. Odotettu:", odotettu_tulos, "Saatu:", tulos)

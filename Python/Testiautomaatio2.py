import unittest

def laske_summa(a, b):
    return a + b

class SummanLaskenta(unittest.TestCase):

    def test_laske_summa(self):
        self.assertEqual(laske_summa(2, 3), 5)
        self.assertEqual(laske_summa(-2, -3), -5)
        self.assertEqual(laske_summa(0, 0), 0)

if __name__ == '__main__':
    unittest.main()

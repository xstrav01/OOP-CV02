using System;
using System.Collections.Generic;
using System.Text;

namespace CV02
{
    class TestComplex
    {
        private const double Epsilon = 0.000001;

        public static bool Test(Complex skutecna, Complex ocekavana, string nazev) {

            Complex rozdíl = skutecna - ocekavana;

            if (rozdíl.Realna < Epsilon && rozdíl.Imaginarni < Epsilon)
            {
                Console.WriteLine(nazev + ":" + "OK");
                return true;
            }
            else
            Console.WriteLine(nazev + ":" + "Chyba, skutečná hodnota: {0}, očekávaná hodnota: {1}",skutecna,ocekavana);
            return false;
        }
    }
}

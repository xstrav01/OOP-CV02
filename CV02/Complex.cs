using System;
using System.Collections.Generic;
using System.Text;

namespace CV02
{
    class Complex
    {   public double Realna;
        public double Imaginarni;

        public Complex(double realna, double imaginarni)
        {
            Realna = realna;
            Imaginarni = imaginarni;
        }

        public static Complex operator +(Complex a, Complex b) {
            return new Complex(a.Realna + b.Realna, a.Imaginarni + b.Imaginarni);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Realna - b.Realna, a.Imaginarni - b.Imaginarni);
        }
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex((a.Realna * b.Realna)-(a.Imaginarni * b.Imaginarni), (a.Realna * b.Imaginarni + b.Realna * a.Imaginarni));
        }
        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex(a.Realna / b.Realna, a.Imaginarni / b.Imaginarni);
        }
        public static bool operator ==(Complex a, Complex b)
        {
            if ((a.Realna == b.Realna) && (a.Imaginarni == b.Imaginarni))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Complex a, Complex b)
        {
            if ((a.Realna != b.Realna) && (a.Imaginarni != b.Imaginarni))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            if(Imaginarni > 0)
            {
                return string.Format("{0} + {1}i", Realna, Imaginarni);
            }
            else
                return string.Format("{0} - {1}i", Realna, -Imaginarni);

        }

        public Complex Sdruzene() {
            return new Complex(Realna, -Imaginarni);
        }
        public double Modul()
        {
            return Math.Sqrt(Math.Pow(Realna, 2) + Math.Pow(Imaginarni, 2));
        }
        public double Argument()
        {
            return Math.Asin(Realna / Imaginarni);
        }


    }
}

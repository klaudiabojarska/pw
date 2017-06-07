using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7z3
{
    class Beczka
    {
        private int pojemnosc;
        private int zawartosc;

        public Beczka (int pojemnosc, int zawartosc)
        {
            this.pojemnosc = pojemnosc;
            this.zawartosc = zawartosc;
        }

        public static int operator +
            (Beczka beczka, int dolej)
        {
            if (beczka.pojemnosc >= beczka.zawartosc + dolej)
            {
                beczka.zawartosc += dolej;
                return 0;
            }
            else
            {
                beczka.zawartosc += dolej;
                int t = beczka.zawartosc - beczka.pojemnosc;
                beczka.zawartosc = beczka.pojemnosc;
                return t;
            }
        }

        public static bool operator *
           (Beczka b1, Beczka b2)
        {
            return (b1.zawartosc >= b2.zawartosc) ? true : false ;
        }
    }
}

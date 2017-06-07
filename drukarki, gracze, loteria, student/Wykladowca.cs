using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Wykladowca
    {
        public string imie;
        public string nazwisko;
        public int semestr;

        public Wykladowca(string imie, string nazwisko, int semestr)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.semestr = semestr;
        }
    }
}

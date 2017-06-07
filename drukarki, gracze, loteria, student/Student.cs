using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Student
    {
        string imie;
        string nazwisko;
        int album;
        DateTime rokUro;
        int semestr;
        float srednia;

        public Student(string imie, string nazwisko, int album, DateTime rokUro, int semestr, float srednia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.album = album;
            this.rokUro = rokUro;
            this.semestr = semestr;
            this.srednia = srednia;
        }
    }
}

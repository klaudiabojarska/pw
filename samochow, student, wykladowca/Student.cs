using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Student
    {
        public string imie;
        public string nazwisko;
        public int album;
        public int rokUro;
        public int semestr;
        public float srednia;

        public Student(string imie, string nazwisko, int album, int rokUro, int semestr, float srednia)
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

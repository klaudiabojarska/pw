using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using static System.Math;

namespace ConsoleApplication3
{
    class Program
    {
        public static Random rand = new Random();

        public void work()
        {
            Dictionary<char, Action<Samochod[], int>> actions = new Dictionary<char, Action<Samochod[], int>>();

            FileStream data = File.Create("Baza.txt");

            Samochod s = new Samochod("Ford", 1990, 10000);
            s.saveToFile(data);
            (new Samochod("Ford", 1990, 10000)).saveToFile(data);
            (new Samochod("Ford", 1990, 10000)).saveToFile(data);
            (new Samochod("Ford", 1990, 10000)).saveToFile(data);
            (new Samochod("Ford", 1990, 10000)).saveToFile(data);
            (new Samochod("Ford", 1990, 10000)).saveToFile(data);
            (new Samochod("Ford", 1990, 10000)).saveToFile(data);

            data.Close();
            //Samochod.loadDataFromFile();


            while (true)
            {

                char command = ReadLine()[0];
                //if(options.Contains(command)) options[command](tab,tab...)
            }
        }
        /*
         
        */

        static void Main(string[] args)
    {
        // Z9/5a-e

        /*List<Student> studenci = new List<Student>();
        List<Wykladowca> wykladowcy = new List<Wykladowca>();

        int index = 12221;
        const int maxSem = 10;
        studenci.Add(new Student("Marcin", "Marcinkowski", index++, 1995, 1, 5.0f));
        studenci.Add(new Student("Kamil", "Kamiński", index++, 1995, rand.Next(1, maxSem), 4.0f));
        studenci.Add(new Student("Daniela", "Danielewska", index++, 1995, rand.Next(1, maxSem), 3.0f));
        studenci.Add(new Student("Renata", "Rentowska", index++, 1995, rand.Next(1, maxSem), 5.0f));
        studenci.Add(new Student("Adam", "Adamski", index++, 1995, rand.Next(1, maxSem), 5.0f));
        studenci.Add(new Student("Patryk", "Petrow", index++, 1990, rand.Next(1, maxSem), 3.5f));
        studenci.Add(new Student("Jessica", "Jones", index++, 1990, rand.Next(1, maxSem), 4.5f));
        studenci.Add(new Student("Dominika", "Dominikańska", index++, 1995, rand.Next(1, maxSem), 5.0f));
        studenci.Add(new Student("Mikołaj", "Święty", index++, 1990, rand.Next(1, maxSem), 4.0f));
        studenci.Add(new Student("Jadwiga", "Jadwigowska", index++, 1995, rand.Next(1, maxSem), 3.5f));
        */

        // podpunkt A, nie zrobiony LINQ

        /*studenci = studenci.OrderBy(o => o.semestr).ToList();
        foreach (var student in studenci)
        {
            WriteLine($"student {student.imie} jest na semestrze {student.semestr}");
        }*/

        // podpunkt B

        /*
        var studenci_pierwszego_semestru = from student in studenci where ((student.semestr > 0) && (student.semestr <= 7)) orderby student.album select new { imie = student.imie, nazwisko = student.nazwisko };

        foreach (var student in studenci_pierwszego_semestru)
        {
            WriteLine($"student {student.imie} {student.nazwisko}");
        }
        */

        // podpunkt C
        /*
        var mezczyzni = from student in studenci where (!student.imie.EndsWith("a")) select student;
        var mezczyzni_powyzej_26_lat = mezczyzni.Any(st => st.rokUro < 1991);
        WriteLine(mezczyzni_powyzej_26_lat);
        */

        //podpunkt D
        /*
        var studentki_7_semestru = from student in studenci where ((student.imie.EndsWith("a")) && (student.semestr == 7)) select student;

        foreach (var student in studentki_7_semestru)
        {
            WriteLine($"studentka {student.imie} {student.nazwisko}");
        }
        */

        //podpunkt E
        /*
        var studenci_II_stopnia = from student in studenci where ((student.semestr >= 8) && (student.semestr <= 10)) select student;
        float suma = 0;
        int liczba = 0;
        foreach (var student in studenci_II_stopnia)
        {
            liczba++;
            suma += student.srednia;
        }
        WriteLine($"srednia = {suma / liczba}");
        */

        // Z7/7

        // generujemy sobie samochody

        new Program().work();
        }
    }
}


/* to bylo ostatnio
Loteria loteria = new Loteria();

Gracz g1 = new Gracz(loteria);
Gracz g2 = new Gracz(loteria);
Gracz g3 = new Gracz(loteria);

while( !( g1.wygral() || g2.wygral() || g3.wygral() ))
{
    g1.graj();
    g2.graj();
    g3.graj();

    loteria.losuj();
}

WriteLine($"{g1.id}: {g1.wynik}");
WriteLine($"{g2.id}: {g2.wynik}");
WriteLine($"{g3.id}: {g3.wynik}");
*/

/*
List<Drukarka> drukarki = new List<Drukarka>();
drukarki.Add(new Drukarka(true, 12));
drukarki.Add(new Drukarka(false, 300));
drukarki.Add(new Drukarka(true, 22));
drukarki.Add(new Drukarka(false, 30));
drukarki.Add(new Drukarka(true, 52));
drukarki.Add(new Drukarka(false, 31));
drukarki.Add(new Drukarka(true, 2));
drukarki.Add(new Drukarka(false, 200));
drukarki.Sort();

foreach (Drukarka drukarka in drukarki)
{
    WriteLine( $"{drukarka.Kolor}, {drukarka.PredkoscDruku}" );
}
*/

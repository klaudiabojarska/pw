using System;
using System.Collections.Generic;
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
        static void Main(string[] args)
        {
            List<Student> studenci = new List<Student>();
            List<Wykladowca> wykladowcy = new List<Wykladowca>();

            int index = 12221;
            studenci.Add(new Student("Marcin", "Marcinkowski", index++, 1995, rand.Next(1,5), 5.0f));
            studenci.Add(new Student("Kamil", "Kamiński", index++, 1995, rand.Next(1, 5), 4.0f));
            studenci.Add(new Student("Daniela", "Danielewska", index++, 1995, rand.Next(1, 5), 3.0f));
            studenci.Add(new Student("Renata", "Rentowska", index++, 1995, rand.Next(1, 5), 5.0f));
            studenci.Add(new Student("Adam", "Adamski", index++, 1995, rand.Next(1, 5), 5.0f));
            studenci.Add(new Student("Patryk", "Petrow", index++, 1995, rand.Next(1, 5), 3.5f));
            studenci.Add(new Student("Jessica", "Jones", index++, 1995, rand.Next(1, 5), 4.5f));
            studenci.Add(new Student("Dominika", "Dominikańska", index++, 1995, rand.Next(1, 5), 5.0f));
            studenci.Add(new Student("Mikołaj", "Święty", index++, 1995, rand.Next(1, 5), 4.0f));
            studenci.Add(new Student("Jadwiga", "Jadwigowska", index++, 1995, rand.Next(1, 5), 3.5f));

            /*
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
        }
    }
}

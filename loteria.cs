using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Loteria
    {
        public event Action L1;
        public event Action L2;
        public event Action L3;

        public void Losowanie()
        {
            
            switch (Program.rand.Next(1, 3))
            {
                case 0: L1?.Invoke(); break;
                case 1: L2?.Invoke(); break;
                case 2: L3?.Invoke(); break;

            }
            L1 = L2 = L3 = null;
        }
    }
        
    class Gracz
    {
        public int wynik = 0;
        static int counter = 0;
        public int id = 0;
        private Loteria loteria;

        public Gracz(Loteria loteria)
        {
            counter++;
            id = counter;
            this.loteria = loteria;
        }
        public void Zaklad()
        {
            wynik++;
        }
        public void Graj()
        {
            
            switch (Program.rand.Next(1, 3))
            {
                case 0: loteria.L1 += Zaklad; break;
                case 1: loteria.L2 += Zaklad; break;
                case 2: loteria.L3 += Zaklad; break;

            }
        }
        public bool wygral()
        {
            if (wynik >= 100)
                return true;
            else return false;
        }
    }
    
    class Program
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {
            Loteria l = new Loteria();

            Gracz g1 = new Gracz(l);
            Gracz g2 = new Gracz(l);
            Gracz g3 = new Gracz(l);

            int i = 0;
            while (!g1.wygral() && !g2.wygral() && !g3.wygral())
            {
                Console.WriteLine(i++);
                g1.Graj();
                g2.Graj();
                g3.Graj();
                l.Losowanie();
            }
            Console.WriteLine($"{g1.id}: {g1.wynik}");
            Console.WriteLine($"{g2.id}: {g2.wynik}");
            Console.WriteLine($"{g3.id}: {g3.wynik}");
            Console.ReadLine();
        }
    }
}

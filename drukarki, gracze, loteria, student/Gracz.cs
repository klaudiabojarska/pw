using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
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

        public void graj()
        {
            switch (Program.rand.Next(1, 3))
            {
                case 1:
                    loteria.L1 += zaklad;
                    break;
                case 2:
                    loteria.L2 += zaklad;
                    break;
                case 3:
                    loteria.L3 += zaklad;
                    break;
            }
        }

        public void zaklad()
        {
            wynik++;
            //System.Console.WriteLine( $"wygrywa {id}" );
        }

        public bool wygral()
        {
            return wynik >= 100 ? true : false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Drukarka : IComparable<Drukarka>
    {
        private bool _kolor;
        public bool Kolor
        {
            get { return _kolor; }
        }

        private double _PredkoscDruku;
        public double PredkoscDruku
        {
            get { return _PredkoscDruku; }
            set {
                if ((value >= 1) && (value <= 100))
                {
                    _PredkoscDruku = value;
                }
            }
        }

        public Drukarka(bool Kolor, double PredkoscDruku)
        {
            this._kolor = Kolor;
            this.PredkoscDruku = PredkoscDruku;
        }

        public int CompareTo(Drukarka temp)
        {
            if (this.Kolor!=temp.Kolor)
            {
                return Kolor ? 1 : -1;
            }
            else if (this.PredkoscDruku != temp.PredkoscDruku)
            {
                return this.PredkoscDruku > temp.PredkoscDruku ? 1 : -1;
            }
            return 0;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7z3
{
    class PojazdSilnikowy
    {
        public int moc;

        public PojazdSilnikowy(int moc)
        {
            this.moc = moc;
        }

        public virtual void Pokaz()
        {
            System.Console.WriteLine(moc);
        }

    }
}

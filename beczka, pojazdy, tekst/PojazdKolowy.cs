using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7z3
{
    class PojazdKolowy : PojazdSilnikowy
    {
        public int LiczbaKol;
        public PojazdKolowy(int moc, int LiczbaKol) : base (moc)
        {
            this.LiczbaKol = LiczbaKol;
        }

        public override void Pokaz()
        {
            System.Console.WriteLine($"moc = {moc} kola = {LiczbaKol}");
        }

    }
}

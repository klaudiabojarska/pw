using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7z3
{
    class SamochodOsobowy : PojazdKolowy
    {
        int LiczbaPasazerow;
        public SamochodOsobowy(int moc, int LiczbaKol, int LiczbaPasazerow) : base (moc, LiczbaKol)
        {
            this.LiczbaPasazerow = LiczbaPasazerow;
        }
   
        public override void Pokaz()
        {
            System.Console.WriteLine($"moc = {moc} kola = {LiczbaKol} pasazerowie = {LiczbaPasazerow}");
        }
    }
}

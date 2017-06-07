using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace _7z3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beczka B1 = new Beczka(1000, 250);
            //Beczka B2 = new Beczka(1500, 100);
            //int t = B1 + 850;
            //    t = B2 + 400;
            //WriteLine((B1 * B2) ? "B1" : "B2");

            /*
            String napis_wielowyrazowy = ReadLine();
            String ciag_wyrazow_zastpwanych = ReadLine();
            String ciag_wyrazow_zastepujacych = ReadLine();
            
            Tekst sentence = new Tekst(napis_wielowyrazowy);
            Tekst before = new Tekst(ciag_wyrazow_zastpwanych);
            Tekst after = new Tekst(ciag_wyrazow_zastepujacych);

            for(int i = 0; i < before.length; i++)
            {
                for (int j = 0; j < sentence.length; j++)
                {
                    sentence[j] = (sentence[j] == before[i]) ? after[i] : sentence[j];
                }
            }
            for (int j = 0; j < sentence.length; j++)
            {
                Write(sentence[j]+" ");
            }
            WriteLine("");
            */

            //PojazdSilnikowy ps = new PojazdSilnikowy(1);
            //ps.Pokaz();
            //ps = new PojazdKolowy(1,2);
            //ps.Pokaz();
            //ps = new SamochodOsobowy(1,2,4);
            //ps.Pokaz();

            
            String[] text = System.IO.File.ReadAllLines(@"Eden.txt");
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
            Dictionary<String, int> d = new Dictionary<String, int>();
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
             = text.Split()
            
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}

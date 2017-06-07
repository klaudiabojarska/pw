using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

using static System.Console;
using static System.Math;
using System.Threading;

namespace ConsoleApplication4
{

    class Program
    {
        public static void zadanie9_10()
        {
            Stopwatch watch = new Stopwatch();
            Random rand = new Random();
            double[] T1 = new double[1000000];
            for (int i = 0; i < 1000000; i++) T1[i] = rand.Next();
            double[] T2 = new double[1000000];

            Write("Liczenie sekwencyjne");
            watch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                T2[i] = Pow(Sin(T1[i] - 12.5), 2) +
                        Pow(Cos(T1[i] - 15.7), 2);
            }
            watch.Stop();
            WriteLine($" - czas wykonywania {watch.ElapsedMilliseconds} milisekund");

            Write("Liczenie równoległe na dwóch wątkach");
            watch.Reset();
            watch.Start();
            Parallel.For(0, 2, j =>
            {
                for (int i = j * 500000; i < (j + 1) * 500000; i++)
                {
                    T2[i] = Pow(Sin(T1[i] - 12.5), 2) +
                            Pow(Cos(T1[i] - 15.7), 2);
                }
            });
            watch.Stop();
            WriteLine($" - czas wykonywania {watch.ElapsedMilliseconds} milisekund");

            Write("Liczenie równoległe na milionie wątków");
            watch.Reset();
            watch.Start();
            Parallel.For(0, 1000000, j =>
            {
                for (int i = j; i < j + 1; i++)
                {
                    T2[i] = Pow(Sin(T1[i] - 12.5), 2) +
                            Pow(Cos(T1[i] - 15.7), 2);
                }
            });
            watch.Stop();
            WriteLine($" - czas wykonywania {watch.ElapsedMilliseconds} milisekund");

        }

        public static void zadanie9_11()
        {
            var directory = new DirectoryInfo("data");
            var fileList = directory.GetFiles();
            int counter = 0;
            Stopwatch watch = new Stopwatch();

            Write("Liczenie sekwencyjne"); counter = 0; watch.Reset(); watch.Start();
            foreach (var file in fileList)
            {
                counter = (from c in File.ReadAllText("data/" + file.Name).ToCharArray() where c == 'e' select c).Count();
            }
            watch.Stop(); WriteLine($" = {counter} - czas wykonywania {watch.ElapsedMilliseconds} milisekund");

            Write("Liczenie równoległe"); counter = 0; watch.Reset(); watch.Start();
            Parallel.ForEach<FileInfo>(fileList, file =>
            {
                counter = (from c in File.ReadAllText("data/" + file.Name).ToCharArray() where c == 'e' select c).Count();
            });
            watch.Stop(); WriteLine($" = {counter} - czas wykonywania {watch.ElapsedMilliseconds} milisekund");

        }

        static Object obb = new Object();
        private static void pionek()
        {
            Pionek p = new Pionek();
            p.obj = obb;
            Thread job = new Thread(new ThreadStart(p.run));
            job.Start();
        }

        static void Main(string[] args)
        {
            for(int i = 0; i < 30; i++)
            {
                pionek();
            }
        }
    }
}

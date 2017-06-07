using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApplication3
{
    class clasa
    {
        public static void a()
        {
            WriteLine("funkcja a");
        }
        public static void b()
        {
            WriteLine("funkcja b");
        }
        public static void c()
        {
            WriteLine("funkcja c");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, Action> lista = new Dictionary<int, Action> { { 1, clasa.a } };
            lista.Add(2, clasa.b);
            lista.Add(3, clasa.c);
            do
            {
                if(Console.ReadKey(true).Key == ConsoleKey.A)
                {
                    lista[1]();
                }
                if (Console.ReadKey(true).Key == ConsoleKey.B)
                {
                    lista[2]();
                }
                if (Console.ReadKey(true).Key == ConsoleKey.C)
                {
                    lista[3]();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            ReadLine();

        }

        
    }
        
}


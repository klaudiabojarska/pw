using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace ConsoleApplication4
{
    class Pionek
    {
        private static bool gameIsOn = true;
        private static Random rand = new Random();
        private const int limit = 100;
        private static int _id = 0;
        private int id;
        public int x = 0;
        public Object obj;
        public Pionek()
        {
            id = _id++;
        }


        public void run()
        {
            while(x < limit)
            {
                x += rand.Next(-4, 6);
                Thread.Sleep(250);
                draw();
                if (!gameIsOn) return;
            }
            gameIsOn = false;
            System.Console.WriteLine($"{id} WYGRYWA!");
        }

        private void draw()
        {
            lock (obj)
            {
                if (x < 0) return;
                if (id == 0) System.Console.Clear();
                Console.CursorVisible = false;
                System.Console.SetCursorPosition(0,id);
                for(int i = 0; i < limit; i++)
                {
                
                    if (i == x)
                    {
                        System.Console.Write(id);
                    }
                    else
                    {
                        System.Console.Write(' ');
                    }
                }
            }
            
        }
    }
}

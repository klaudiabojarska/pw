using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using static System.Math;

namespace ConsoleApplication2
{
    class Program
    {
        static double[,] matrix;
        static bool matrix_initialized = false;
        static int n = 0;
        static int m = 0;
        static void loadMatrix()
        {
            Write("m=");
            m = int.Parse(ReadLine());
            if (m >= 20) return;

            Write("n=");
            n = int.Parse(ReadLine());
            if (n >= 20) return;

            matrix = new double[n, m];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Write($"[{i},{j}] = ");
                    matrix[i,j] = int.Parse(ReadLine());
                }
            }

            matrix_initialized = true;
        }

        static void sumRows()
        {
            if (!matrix_initialized) return;
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += matrix[i, j];
                }
                WriteLine($"Suma wiersza {i} wynosi {sum}");
            }
        }
        static void sumCols()
        {
            if (!matrix_initialized) return;
            for (int j = 0; j < m; j++)
            {
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += matrix[i, j];
                }
                WriteLine($"Suma kolumny {j} wynosi {sum}");
            }
        }

        static void Main(string[] args)
        {
            String st;
            bool dalej = true;
            while(dalej)
            {
                st = ReadLine();
                switch (st[0] & 0x5F)
                {
                    case 'N':
                        loadMatrix();
                        break;
                    case 'W':
                        sumRows();
                        break;
                    case 'K':
                        sumCols();
                        break;
                    case 'Q':
                        return;
                        break;
                }
            }
        }
    }
}
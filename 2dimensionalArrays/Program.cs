using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dimensionalArrays
{
    class Program
    {
        static int[,]  Matrix = new int[8,8];
        static void Main(string[] args)
        {
            InitMatrix2();
            PrintMatrix2();
            Console.ReadLine();
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                Console.Write(Environment.NewLine);
                for (int column = 0; column < Matrix.GetLength(1); column++)
                {
                    Console.Write("{0,2} ", Matrix[row, column]);
                }
            }
        }

        private static void PrintMatrix2()
        {
            int i = 0;
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                
                for (int column = 0; column < Matrix.GetLength(1); column++)
                {
                    if (column == i || column == Matrix.GetLength(1) - (i+1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write("{0,2} ", Matrix[row, column]);
                }
                Console.Write(Environment.NewLine);
                i++;
            }
        }

        public static void InitMatrix2()
        {
            int row = 0;
            for (int getal = 0; getal < 64; getal++)
            {
                if (getal%8 == 0 && getal != 0)
                {
                    row++;
                    Matrix[row, 0] = getal+1;
                }
                else
                {
                    Matrix[row, getal%8] = getal + 1;
                }
            }
        }

        public static void InitMatrix()
        {
            int i = 1;
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int column = 0; column < Matrix.GetLength(1); column++)
                {
                    Matrix[row, column] = i;
                    i++;
                }   
            }
        }
    }
}

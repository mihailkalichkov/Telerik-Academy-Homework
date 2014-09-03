using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01c_LowerDiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            int[,] LowerDiagonalMatrix = new int[n, n];
            int rows = n - 1;
            int columns = 0;
            int count = 1;
            int step=1;
            while(true)
            {
                if (rows == n - 1 && rows != columns)
                {
                    LowerDiagonalMatrix[rows, columns] = count;
                    count++;
                    rows -= step;
                    columns = 0;
                    step++;
                }
                else if (rows != n - 1)
                {
                    LowerDiagonalMatrix[rows, columns] = count;
                   count++;
                    rows++;
                    columns++;
                }
                else if (rows == n - 1 && columns == rows)
                {
                    LowerDiagonalMatrix[rows, columns] = count;
                    rows = 0;
                    columns = 1;
                    count++;
                    break;
                }
            }
            step = 1;
            while(true)
                if (columns==n-1 && rows!=0)
                {
                    LowerDiagonalMatrix[rows, columns] = count;
                    count++;
                    step++;
                    columns = step;
                    rows = 0;
                }
                else if (columns!=n-1)
                {
                    LowerDiagonalMatrix[rows, columns] = count;
                    count++;
                    rows++;
                    columns++;
                }
                else if (columns==n-1&&rows==0)
                {
                    LowerDiagonalMatrix[rows, columns] = count;
                    break;
                }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0} ", LowerDiagonalMatrix[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
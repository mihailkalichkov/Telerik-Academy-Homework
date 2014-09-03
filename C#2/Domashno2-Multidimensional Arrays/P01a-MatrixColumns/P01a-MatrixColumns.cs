using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01a_MatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            int rows=n;int columns= n;
            int[,] MatrixColumns=new int[rows,columns];

            for (int column = 0,count=1; column < n; column++)
            {
                for (int row = 0; row < n; row++)
                {
                    MatrixColumns[row, column] = count++;
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write("{0} ", MatrixColumns[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

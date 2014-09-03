namespace DSAComplexity
{
    using System;
    class Program
    {
        /* Complexity 0(n*m)
         The first loop has a complexity of n, then we have an if condition that we fulfil at a constant rate
         and the second loop has a complexity of m. In the average case we have 0(n/2*m). In the worst case we have 0(n*m) if we have only odd numbers in the first column of the matrix. In the best case we have 0(n) if we have only even numbers in the first column of the matrix*/
        long CalcCount(int[,] matrix)
        {
            long count = 0;
            //first loop
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, 0] % 2 == 0)
                {
                    //second loop
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] > 0)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
namespace DSAComplexity
{
    using System;
    class Program
    {
        /*Complexity 0(n*n)
        /We have 2 loops - 1 is the for loop that makes n cycles, 2 is the while loop that makes
         n-1 cycles because it starts at start which is 0 and stops at arr.Length-1 which is n-1 cycles*/

        long Compute(int[] arr)
        {
            long count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int start = 0, end = arr.Length - 1;
                while (start < end)
                    if (arr[start] < arr[end])
                    { 
                        start++; count++;
                    }
                    else
                    {
                        end--;
                    }  
            }
            return count;
        }
    }
}

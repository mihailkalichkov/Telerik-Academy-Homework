using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int Element = 7;// the number we are searching for
            int left= 0;
            int right=array.Length;
            int center=(left+right)/2;

            while (left <= center)
            {
                left++;
                if (array[left] == Element)
                {
                    Console.WriteLine("The index is {0}", left);
                    return;
                }
            }
            while (right<center)
            {
                right--;
                if (array[right]==Element)
                {
                    Console.WriteLine("The index is {0}", right);
                    return;
                }
            }

        }
    }
}

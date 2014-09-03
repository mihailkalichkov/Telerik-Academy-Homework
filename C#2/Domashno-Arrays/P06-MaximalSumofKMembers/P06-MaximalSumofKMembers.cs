using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_MaximalSumofKMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K:");
            int K = int.Parse(Console.ReadLine());
            int[] ArrayN= new int[N];
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter member number {0}:",i);
                ArrayN[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(ArrayN);//Sorting the array in increasing order

            for (int i = 1; i <= K; i++)// sum of the last K members
            {
                sum += ArrayN[N - i];
            }
            Console.WriteLine(sum);
        }
    }
}

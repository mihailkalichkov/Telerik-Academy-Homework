using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_MinMaxSumAverageProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the integer sequence: ");
            int sequenceLength = int.Parse(Console.ReadLine());

            if (sequenceLength <= 0)
            {
                Console.WriteLine("The length you have entered is invalid.");
            }
            else
            {
                int[] sequence = new int[sequenceLength];
                Console.WriteLine("Enter the elements of the sequence:");

                for (int i = 0; i < sequenceLength; ++i)
                {
                    sequence[i] = int.Parse(Console.ReadLine());
                }

                int average = CalculateAverage(sequence);
                Console.WriteLine("The average is: {0}", average);
                int min = Minimum(sequence);
                Console.WriteLine("The minimuim is: {0}", min);
                int max = Maximum(sequence);
                Console.WriteLine("The maximum is: {0}", max);
                long sum = Sum(sequence);
                Console.WriteLine("The sum is : {0}", sum);
                long product = Product(sequence);
                Console.WriteLine("The product is: {0}", product);
                
            }
        }
        static int CalculateAverage(int[] sequence)
        {
            int sequenceLength = sequence.GetLength(0);
            int sum = 0;
            foreach (int x in sequence)
            {
                sum += x;
            }

            return sum / sequenceLength;
        }
        static int Minimum(params int[] sequence)
        {
            int min = sequence[0];
            for (int i = 0; i < sequence.Length; i++)
            {
              if (sequence[i]<min)
              {
                  min = sequence[i];
              }
            }
            return min;
        }
        static int Maximum(params int[] sequence)
        {
            int max = sequence[0];
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i]>max)
                {
                    max=sequence[i];
                }
            }
            return max;
        }
        static long Sum(params int[] sequence)
        {
            long sum=0;
            foreach (int element in sequence)
                sum+=element;
            return sum;
        }
        static long Product(params int[] sequence)
        {
            long product = 1;
            foreach (int element in sequence)
                product *= element;
            return product;
        }

    }
}

  
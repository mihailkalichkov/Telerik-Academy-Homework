﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01_NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int number = int.Parse(Console.ReadLine());

            int[] vector = new int[number];
            ExcuteNestedLoops(number - 1, vector);
        }

        private static void ExcuteNestedLoops(int index, int[] vector)
        {
            if (index == -1)
            {
                // bottom of recursion found and the vector is printed due to no more combination like this
                Print(vector);
            }
            else
            {
                for (int i = 1; i <= vector.Length; i++)
                {
                    vector[index] = i;
                    ExcuteNestedLoops(index - 1, vector);
                }
            }
        }

        private static void Print(int[] vector)
        {
            Console.WriteLine(string.Join(" ", vector));
        }
    }
}

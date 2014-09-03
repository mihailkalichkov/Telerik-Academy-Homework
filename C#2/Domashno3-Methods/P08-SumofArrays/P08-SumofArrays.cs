using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_SumofArrays
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first positive integer: ");
            string Input = Console.ReadLine();
            int[] firstNumber = new int[Input.Length];
            int length = Input.Length;
            for (int i = 0; i < length; i++)
            {
                firstNumber[i] = int.Parse(Input[length - 1 - i].ToString());
            }
            Console.Write("Enter second positive integer: ");
            Input = Console.ReadLine();
            int[] secondNumber = new int[Input.Length];
            length = Input.Length;
            for (int i = 0; i < length; i++)
            {
                secondNumber[i] = int.Parse(Input[length - 1 - i].ToString());
            }
            int[] result = Sum(firstNumber, secondNumber);
            Console.Write("The sum is: ");
            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }

        private static int[] Sum(int[] firstNumber, int[] secondNumber)
        {

            List<int> result = new List<int>(Math.Max(firstNumber.Length, secondNumber.Length) + 1);
            int min = Math.Min(firstNumber.Length, secondNumber.Length);
            int add = 0;
            for (int i = 0; i < min; i++)
            {
                result.Add((firstNumber[i] + secondNumber[i] + add) % 10);
                add = ((firstNumber[i] + secondNumber[i] + add) / 10) % 10;
            }
            if (firstNumber.Length > min)
            {
                for (int i = min; i < firstNumber.Length; i++)
                {
                    result.Add((firstNumber[i] + add) % 10);
                    add = ((firstNumber[i] + add) / 10) % 10;
                }
            }
            if (secondNumber.Length > min)
            {
                for (int i = min; i < secondNumber.Length; i++)
                {
                    result.Add((secondNumber[i] + add) % 10);
                    add = ((secondNumber[i] + add) / 10) % 10;
                }
            }
            if (add > 0)
            {
                result.Add(add);
            }
            return result.ToArray();
        }
    }
}
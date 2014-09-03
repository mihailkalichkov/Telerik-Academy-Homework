using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_ArrayComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first array length");
            int FirstArrayLength= int.Parse(Console.ReadLine());
            int[] FirstArray = new int[FirstArrayLength];
            Console.WriteLine("Enter second array length");
            int SecondArrayLength = int.Parse(Console.ReadLine());
            int[] SecondArray = new int[SecondArrayLength];
            bool Equality = false;
            if (FirstArrayLength!=SecondArrayLength)
            {
                Console.WriteLine("The arrays have different legths");
            }
            else
            {
                for (int i = 0; i < FirstArrayLength; i++)
                {
                    Console.WriteLine("Enter first array element with index {0}", i);
                    FirstArray[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < SecondArrayLength; i++)
                {
                    Console.WriteLine("Enter second array element with index {0}", i);
                    SecondArray[i]=int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < FirstArrayLength ; i++)
			    {
			        if(FirstArray[i]==SecondArray[i])
                    {
                        Equality= true;
                    }
                    else
                    {
                       Equality=false;
                       break;
                    }                 
			    }
                Console.WriteLine("The arrays are equal - {0}", Equality);
            }
        }

        
    }
}

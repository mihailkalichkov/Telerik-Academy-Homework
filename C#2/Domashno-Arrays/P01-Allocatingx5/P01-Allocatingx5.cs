using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Allocatingx5
{
    class Program
    {
        static void Main()
        {
            int[] Arrayx5= new int[20];

            for (int i = 0; i < 20; i++)
            {
                Arrayx5[i] = i * 5; 
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Arrayx5[i]); 
            }
        }
    }
}

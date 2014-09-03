using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_HelloUser
{
    class Program
    {
        static void Hello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter you name:");
            Hello(Console.ReadLine());
        }
    }
}

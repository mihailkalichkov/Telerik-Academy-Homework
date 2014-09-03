using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;

            var queue = new Queue<int>();

            queue.Enqueue(n);

            for (int i = 0; i < 50; i++)
            {
                int currentMember = queue.Dequeue();

                Console.WriteLine(currentMember);

                queue.Enqueue(currentMember + 1);
                queue.Enqueue(2 * currentMember + 1);
                queue.Enqueue(currentMember + 2);
            }
        }
    }
}

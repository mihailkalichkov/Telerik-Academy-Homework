using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_RemovingNegativeNumbersFromSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = "1 2 -5 8 -7 -1 -1 6 7 4 -8";

            string[] sequenceArray = sequence.Split(' ');

            var sequenceLinkedList = new LinkedList<int>();

            foreach (var item in sequenceArray)
            {
                sequenceLinkedList.AddLast(int.Parse(item));
            }

            Console.WriteLine("Sequence before filtering:");
            Console.WriteLine(string.Join(" ", sequenceArray));

            var node = sequenceLinkedList.First;

            while (node != null)
            {
                var next = node.Next;

                if (node.Value < 0)
                {
                    sequenceLinkedList.Remove(node);
                }

                node = next;
            }

            Console.WriteLine("Sequence after filtering: ");
            Console.WriteLine(string.Join(" ",sequenceLinkedList));
        }
    }
}

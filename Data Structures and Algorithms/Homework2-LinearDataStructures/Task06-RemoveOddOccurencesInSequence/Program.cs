using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_RemoveOddOccurencesInSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = "4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2";

            string[] sequenceArray = sequence.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);

            var sequenceList = new List<int>();

            foreach (var item in sequenceArray)
            {
                sequenceList.Add(int.Parse(item));
            }

            var filteredSequence = new Dictionary<int, int>();

            foreach (var item in sequenceList)
            {
                if (!filteredSequence.Keys.Contains(item))
                {
                    filteredSequence.Add(item, 1);
                }
                else
                {
                    filteredSequence[item]++;
                }
            }

            foreach (var pair in filteredSequence)
	        {
	            if (pair.Value % 2 != 0)
                {
                    sequenceList.RemoveAll(x => x == pair.Key);
                }
	        }

            Console.WriteLine(string.Join(", ", sequenceList));
        }
    }
}

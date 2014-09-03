using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class BitArray64 : IEnumerable<int>
    {
        private readonly int[] bits = new int[64];

        public ulong Number { get; private set; }

        // constructor
        public BitArray64(ulong number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Enter positive 64bit number!");
            }
            this.Number = number;
            GetBits(number);
        }

        // indexer
        public int this[int index]
        {
            get
            {
                return this.bits[index];
            }
            set
            {
                this.bits[index] = value;
            }
        }

        // get the bits of the number entered
        private void GetBits(ulong number)
        {
            for (int i = 0; i < 64; i++)
            {
                int bit = (int)(number >> i & 1);
                if (bit == 1) bits[i] = 1;
                else bits[i] = 0;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return i;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            string num = obj as String;
            if (num == null)
            {
                return false;
            }

            int[] numBits = new int[64];
            for (int i = num.Length - 1, j = 0; i >= 0; i--, j++)
            {
                numBits[j] = int.Parse(num[i].ToString());
            }

            for (int i = 0; i < 64; i++)
            {
                if (numBits[i] != this.bits[i]) return false;
            }

            return true;
        }

        public static Boolean operator ==(BitArray64 number, string bits)
        {
            return Equals(number, bits);
        }

        public static Boolean operator !=(BitArray64 number, string bits)
        {
            return !Equals(number, bits);
        }

        public override int GetHashCode()
        {
            return this.bits.GetHashCode();
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            for (int i = 0; i < bits.Length; i++)
            {
                str.Insert(0, bits[i]);
            }

            return str.ToString();
        }
    }
}
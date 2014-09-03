using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic
{
    public class GenericList<T>
        where T : IComparable
    {
        private int index = 0;
        private T[] array;

        public GenericList(uint length = 4)
        {
            this.array = new T[length];
        }

        public T this[int index]
        {
            get
            {
                return this.array[index];
            }
            set
            {
                this.array[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.index <= this.array.Length - 1)
            {
                this.array[this.index] = element;
            }
            else
            {
                T[] tempArr = new T[this.array.Length];
                Array.Copy(array, tempArr, array.Length);
                array = new T[tempArr.Length * 2];
                Array.Copy(tempArr, array, tempArr.Length);
                this.array[this.index] = element;
            }
            index++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > array.Length - 1)
            {
                throw new ArgumentException(string.Format("Index {0} doesn't exists!", index));
            }

            var temp = new T[this.array.Length];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != index)
                {
                    temp[j] = array[i];
                    j++;
                }
            }
            array = temp.ToArray<T>();
        }

        public void InsertAt(int index, T item)
        {
            if (index < 0 || index > array.Length - 1)
            {
                throw new ArgumentException(string.Format("Index {0} doesn't exists!", index));
            }

            var temp = new T[this.array.Length + 1];
            int i = 0;
            while (i < index)
            {
                temp[i] = array[i];
                i++;
            }
            temp[i] = item;
            i++;
            for (int j = i - 1; j < array.Length; j++, i++)
            {
                temp[i] = array[j];
            }
            array = temp.ToArray<T>();
        }

        public void Clear()
        {
            this.array = new T[0];
        }

        public int Find(T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            var temp = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                temp.AppendLine(array[i].ToString());
            }
            return temp.ToString().Trim();
        }

        public T Min()
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Empty list!");
            }

            T start = array[0];
            if (array.Length > 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (start.CompareTo(array[i]) > 0)
                    {
                        start = array[i];
                    }
                }
                return start;
            }
            else return start;
        }

        public T Max()
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Empty list!");
            }

            T start = array[0];
            if (array.Length > 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (start.CompareTo(array[i]) < 0)
                    {
                        start = array[i];
                    }
                }
                return start;
            }
            else return start;
        }
    }
}
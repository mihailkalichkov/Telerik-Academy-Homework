using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Extensions
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder text, int index, int length)
        {
            if (index >= text.Length || index < 0)
            {
                throw new ArgumentException("Incorrect index entered!");
            }
            if (length + index > text.Length || length < 0)
            {
                throw new ArgumentException("Incorrect length entered!");
            }
            var temp = new StringBuilder();
            for (int i = index; i < length + index; i++)
            {
                temp.Append(text[i]);
            }
            return temp;
        }

        public static T Sum<T>(this IEnumerable<T> array)
            where T : struct,IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            T sum = array.First();
            for (int i = 1; i < array.Count<T>(); i++)
            {
                sum += (dynamic)array.ToArray()[i];
            }
            return sum;
        }

        public static T Min<T>(this IEnumerable<T> array)
            where T : struct,IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            T min = array.First();
            for (int i = 1; i < array.Count<T>(); i++)
            {
                if (min.CompareTo(array.ToArray()[i]) > 0)
                {
                    min = array.ToArray()[i];
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> array)
            where T : struct,IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            T max = array.First();
            for (int i = 1; i < array.Count<T>(); i++)
            {
                if (max.CompareTo(array.ToArray()[i]) < 0)
                {
                    max = array.ToArray()[i];
                }
            }
            return max;
        }

        public static double Average<T>(this IEnumerable<T> array)
            where T : struct,IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            double average = Extensions.Sum(array).ToDouble(CultureInfo.InvariantCulture.NumberFormat);
            average /= array.ToArray().Length;
            return average;
        }

        public static T Product<T>(this IEnumerable<T> array)
            where T : struct,IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            T product = array.First();
            for (int i = 1; i < array.Count<T>(); i++)
            {
                product *= (dynamic)array.ToArray()[i];
            }
            return product;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions
{
    public class InvalidRangeException<T> : ApplicationException
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private T startValue;
        private T endValue;

        public InvalidRangeException(T startValue, T endValue)
        {
            this.startValue = startValue;
            this.endValue = endValue;
        }

        public InvalidRangeException(string message, T startValue, T endValue)
            : base(message)
        {
            this.startValue = startValue;
            this.endValue = endValue;
        }

        public InvalidRangeException(string message, T startValue, T endValue, Exception inner)
            : base(message, inner)
        {
            this.startValue = startValue;
            this.endValue = endValue;
        }

        public T StartValue
        {
            get { return this.startValue; }
        }

        public T EndValue
        {
            get { return this.endValue; }
        }
    }
}
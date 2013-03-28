using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CustomException
{
    public class InvalidRangeException<T> : ApplicationException
    {
        public T MinValue { get; set; }
        public T MaxValue { get; set; }

        public InvalidRangeException(T start, T end, string message)
            : base(message)
        {
            this.MinValue = start;
            this.MaxValue = end;
        }

        public InvalidRangeException(T start, T end): this(start, end, null)
        {
        }

    }
}

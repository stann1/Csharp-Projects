using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitArray
{
    //This is only needed to perform Inemuration operations on the transformed number (aka foreach)

    class BitArray64Enumerator : IEnumerator
    {
        int position = -1;
        public int[] values;

        public BitArray64Enumerator(int[] values)
        {
            this.values = values;
        }

        public bool MoveNext()
        {
            position++;
            return (position < values.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                try
                {
                    return values[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}

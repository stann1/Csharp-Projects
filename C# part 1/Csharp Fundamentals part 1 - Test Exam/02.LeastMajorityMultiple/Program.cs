using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LeastMajorityMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            
            int noRemainder = 0;
            int[] array = { a, b, c, d, e };
            Array.Sort(array);
            int compare = array[2];

            while (noRemainder < 3)
            {
                noRemainder = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (compare % array[i] == 0)
                    {
                        noRemainder++;
                        if (noRemainder == 3)
                        {
                            Console.WriteLine(compare);
                            break;
                        }
                    }
                }
                compare++;
            }
        }
    }
}

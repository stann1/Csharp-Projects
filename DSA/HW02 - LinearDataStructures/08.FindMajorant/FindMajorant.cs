using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FindMajorant
{
    class FindMajorant
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int>() { 3, 4, 1, 3, 3, 3, 11, 11, 11, 3, 3 };           
            int minMajorantLength = (sequence.Count / 2) + 1;
            bool majorantFound = false;

            for (int i = 0; i < sequence.Count; i++)
            {
                int number = sequence[i];

                int count = sequence.FindAll(x => x == number).Count;
                
                if (count >= minMajorantLength)                
                {
                    Console.WriteLine("The majorant is: {0} --> {1} times", number, count);
                    majorantFound = true;
                    break;
                }
            }

            if (!majorantFound)
            {
                Console.WriteLine("There is no majorant in the array");
            }
            
        }
    }
}

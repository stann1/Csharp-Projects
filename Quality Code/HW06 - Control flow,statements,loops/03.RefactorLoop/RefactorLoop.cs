using System;
using System.Linq;

/*Implementation of the undefined classes and methods is not included because the purpose of the excercise is different
and the task itself is very simple*/

namespace _03.RefactorLoop
{
    class RefactorLoop
    {
        static void Main(string[] args)
        {
            bool foundExpectedValue = false;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);       //avoiding repetition of code in all conditional checks

                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        foundExpectedValue = true;
                        break;
                    }                   
                }                
            }

            // More code here

            if (foundExpectedValue)
            {
                Console.WriteLine("Value Found");
            }

        }
    }
}

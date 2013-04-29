using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Implementation of the undefined classes and methods is not included because the purpose of the excercise is different
and the task itself is very simple*/

namespace _02.RefactorConditionals
{
    class RefactorConditionals
    {
        static void Main(string[] args)
        {           
        }

        //task 2A
        static void PrepareMeal()
        {
            Potato potato = new Potato();
            //... 
            if (potato != null)
            {
                bool isWhole = potato.HasNotBeenPeeled;
                bool isRotten = potato.IsRotten;

                if (!(isWhole || isRotten))
                {
                    Cook(potato);
                }
            }
        }

        //task 2B
        static void VisitValidatedCell()
        {
            if (IsInRange(x, MIN_X, MAX_X) && IsInRange(y, MIN_Y, MAX_Y) && validCell)
            {
               VisitCell();
            }

        }

        static bool IsInRange(int value, int minValue, int maxValue)
        {
            if (minValue <= value && value <= maxValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

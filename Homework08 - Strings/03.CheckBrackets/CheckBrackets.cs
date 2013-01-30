using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CheckBrackets
{
    class CheckBrackets
    {
        static void Main(string[] args)
        {
            string expression = "((a+b)/5-d)";
            int countOpen = 0;
            bool correct = true;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    countOpen++;
                }
                if (expression[i] == ')')
                {
                    if (i > 0 && expression[i-1] == '(')              //This catches brakets around empty space
                    {
                        correct = false;
                        break;
                    }
                    countOpen--;
                }
                if (countOpen < 0)
                {
                    correct = false;
                    break;
                }
            }

            if (countOpen > 0)
            {
                correct = false;
            }
            Console.WriteLine("The brackets are correct? " + correct);
        }
    }
}

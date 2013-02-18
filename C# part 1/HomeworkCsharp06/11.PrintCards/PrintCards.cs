using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PrintCards
{
    class PrintCards
    {
        static void Main(string[] args)
        {
            int cardValue = 1;
            string[] cardShape = new string[] { "Clubs", "Diamonds", "Spades", "Hearts" };

            foreach (string shape in cardShape)
            {
                for (int i = 1; i < 14; i++)
                {
                    cardValue = i;
                    switch (cardValue)
                    {
                        case 1: Console.WriteLine("Ace of" + " " + shape);
                            break;
                        case 2: Console.WriteLine("Two of" + " " + shape);
                            break;
                        case 3: Console.WriteLine("Three of" + " " + shape);
                            break;
                        case 4: Console.WriteLine("Four of" + " " + shape);
                            break;
                        case 5: Console.WriteLine("Five of" + " " + shape);
                            break;
                        case 6: Console.WriteLine("Six of" + " " + shape);
                            break;
                        case 7: Console.WriteLine("Seven of" + " " + shape);
                            break;
                        case 8: Console.WriteLine("Eight of" + " " + shape);
                            break;
                        case 9: Console.WriteLine("Nine of" + " " + shape);
                            break;
                        case 10: Console.WriteLine("Ten of" + " " + shape);
                            break;
                        case 11: Console.WriteLine("Jack of" + " " + shape);
                            break;
                        case 12: Console.WriteLine("Queen of" + " " + shape);
                            break;
                        case 13: Console.WriteLine("King of" + " " + shape);
                            break;
                        default:
                            break;
                    }

                }
            }
        }
    }
}

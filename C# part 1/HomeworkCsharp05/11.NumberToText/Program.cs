using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number in the range 0 - 999");
            string userInput = Console.ReadLine();
            int numberGiven = int.Parse(userInput);
            bool specialNumber = false;
            bool wholeNumber = false;


            if (numberGiven < 0 || numberGiven > 999)
            {
                Console.WriteLine("The number you have entered is not in the desired range");
            }
            else
            {
                if (numberGiven % 100 == 0)
                {
                    wholeNumber = true;
                }
                int checkHundreds = numberGiven / 100;
                switch (checkHundreds)
                {
                    case 0:
                        break;
                    case 1: Console.Write("One hundred" + (wholeNumber ? "\n" : " " + "and" + " "));
                        break;
                    case 2: Console.Write("Two hundred" + (wholeNumber ? "\n" : " " + "and" + " "));
                        break;
                    case 3: Console.Write("Three hundred" + (wholeNumber ? "\n" : " " + "and" + " "));
                        break;
                    case 4: Console.Write("Four hundred" + (wholeNumber ? "\n" : " " + "and" + " "));
                        break;
                    case 5: Console.Write("Five hundred" + (wholeNumber ? "\n" : " " + "and" + " "));
                        break;
                    case 6: Console.Write("Six hundred" + (wholeNumber ? "\n" : " " + "and" + " "));
                        break;
                    case 7: Console.Write("Seven hundred" + (wholeNumber ? "\n" : " " + "and" + " "));
                        break;
                    case 8: Console.Write("Eight hundred" + (wholeNumber ? "\n" : " " + "and" + " "));
                        break;
                    case 9: Console.Write("Nine hundred" + (wholeNumber ? "\n" : " " + "and" + " "));
                        break;
                    default:
                        break;
                }

                int checkTens = numberGiven % 100;
                checkTens = checkTens / 10;
                switch (checkTens)
                {
                    case 0:
                        break;
                    case 1: specialNumber = true;
                        switch (numberGiven % 100)
                        {
                            case 10: Console.Write("Ten");
                                break;
                            case 11: Console.Write("Eleven");
                                break;
                            case 12: Console.Write("Twelve");
                                break;
                            case 13: Console.Write("Thirteen");
                                break;
                            case 14: Console.Write("Fourteen");
                                break;
                            case 15: Console.Write("Fifteen");
                                break;
                            case 16: Console.Write("Sixteen");
                                break;
                            case 17: Console.Write("Seventeen");
                                break;
                            case 18: Console.Write("Eighteen");
                                break;
                            case 19: Console.Write("Nineteen");
                                break;
                        }
                        break;
                    case 2: Console.Write("Twenty" + " ");
                        break;
                    case 3: Console.Write("Thirty" + " ");
                        break;
                    case 4: Console.Write("Fourty" + " ");
                        break;
                    case 5: Console.Write("Fifty" + " ");
                        break;
                    case 6: Console.Write("Sixty" + " ");
                        break;
                    case 7: Console.Write("Seventy" + " ");
                        break;
                    case 8: Console.Write("Eighty" + " ");
                        break;
                    case 9: Console.Write("Ninety" + " ");
                        break;
                    default:
                        break;
                }
                if (specialNumber == false)
                {
                    int checkOnes = (numberGiven % 100) % 10;
                    switch (checkOnes)
                    {
                        case 0:
                            break;
                        case 1: Console.Write("One" + "\n");
                            break;
                        case 2: Console.Write("Two" + "\n");
                            break;
                        case 3: Console.Write("Three" + "\n");
                            break;
                        case 4: Console.Write("Four" + "\n");
                            break;
                        case 5: Console.Write("Five" + "\n");
                            break;
                        case 6: Console.Write("Six" + "\n");
                            break;
                        case 7: Console.Write("Seven" + "\n");
                            break;
                        case 8: Console.Write("Eight" + "\n");
                            break;
                        case 9: Console.Write("Nine" + "\n");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}

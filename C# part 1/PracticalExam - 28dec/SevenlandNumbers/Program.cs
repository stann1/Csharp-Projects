using System;


namespace SevenlandNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int lastDigit = number % 10;
            int middleDigit = (number / 10) % 10;
            int firsDigit = number / 100;

          
            switch (lastDigit)
            {
                case 0: 
                case 1:
                case 2:
                case 3:
                case 4:
                case 5: number += 1;
                    break;
                case 6: if (number < 10) number = 10;
                        else
                        {
                            switch (middleDigit)
                            {
                                case 0:
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5: number += 4;
                                    break;
                                case 6: if (number < 100) number = 100;
                                        else
                                        {
                                            switch (firsDigit)
                                            {
                                                case 0:
                                                case 1:
                                                case 2:
                                                case 3:
                                                case 4:
                                                case 5: number += 34;
                                                    break;
                                                case 6: number = 1000;
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                    break;
                                default:
                                    break;
                            }
                        }
                
                    break;
                default:
                    break;
            }
            Console.WriteLine(number);
        }
    }
}

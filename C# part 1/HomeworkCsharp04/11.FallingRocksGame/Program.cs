using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _11.FallingRocksGame
{

    struct Object
    {
        public int x;
        public int y;
        public char c;
        public string str;
        public ConsoleColor color;
    }
    class Program
    {
        static Random randGenerator = new Random();
        static ConsoleColor tempColor = ConsoleColor.White;
        static char tempChar = '@';
        static string tempStr = "";

        static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void PrintOnPosition(int x, int y, char c, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }
        static void GenerateRandoms()                    // random colors, characters and size for the different rocks
        {
            int randColor = randGenerator.Next(0, 5);

            switch (randColor)
            {
                case 0: tempColor = ConsoleColor.Blue;
                    break;
                case 1: tempColor = ConsoleColor.Green;
                    break;
                case 2: tempColor = ConsoleColor.Red;
                    break;
                case 3: tempColor = ConsoleColor.Magenta;
                    break;
                case 4: tempColor = ConsoleColor.DarkYellow;
                    break;
                case 5: tempColor = ConsoleColor.Cyan;
                    break;
                default:
                    break;
            }

            int randChar = randGenerator.Next(0, 6);

            switch (randChar)
            {
                case 0: tempChar = '@';
                    break;
                case 1: tempChar = '#';
                    break;
                case 2: tempChar = '$';
                    break;
                case 3: tempChar = '%';
                    break;
                case 4: tempChar = '^';
                    break;
                case 5: tempChar = '&';
                    break;
                case 6: tempChar = ';';
                    break;
                default:
                    break;
            }

            int randStr = randGenerator.Next(1, 3);

        }

        static void Main(string[] args)
        {

            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Object dwarf = new Object();
            dwarf.x = (Console.WindowWidth / 2) - 1;
            dwarf.y = Console.WindowHeight - 1;
            dwarf.str = "(0)";
            dwarf.color = ConsoleColor.White;
            List<Object> rocks = new List<Object>();
            int gameSpeed = 0;
            byte livesCount = 3;


            while (true)
            {
                gameSpeed += 1;                     //set speed
                if (gameSpeed >= 350)
                {
                    gameSpeed = 350;
                }
                bool collision = false;

                //Draw rocks
                Object newRock = new Object();
                GenerateRandoms();
                newRock.x = randGenerator.Next(0, Console.WindowWidth);
                newRock.y = 0;
                newRock.c = tempChar;
                newRock.color = tempColor;
                rocks.Add(newRock);


                //move rocks
                List<Object> newList = new List<Object>();
                for (int i = 0; i < rocks.Count; i++)
                {
                    Object oldRock = rocks[i];
                    Object newObj = new Object();
                    newObj.x = oldRock.x;
                    newObj.y = oldRock.y + 1;
                    newObj.c = oldRock.c;
                    newObj.color = oldRock.color;
                    if (newObj.y == dwarf.y && (newObj.x >= dwarf.x && newObj.x <= dwarf.x + 2))
                    {
                        livesCount--;
                        collision = true;
                        gameSpeed = 0;
                        if (livesCount <= 0)
                        {
                            Console.Clear();
                            PrintStringOnPosition((Console.WindowWidth / 2) - 5, Console.WindowHeight / 2, "Game over!", ConsoleColor.Red);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                    if (newObj.y < Console.WindowHeight)
                    {
                        newList.Add(newObj);
                    }

                }
                rocks = newList;

                //move dwarf
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                    if (keyPressed.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.x > 0)
                        {
                            dwarf.x -= 1;
                        }
                    }
                    else if (keyPressed.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.x < Console.WindowWidth - 3)
                        {
                            dwarf.x += 1;
                        }

                    }
                }


                //redraw:
                Console.Clear();

                if (collision == true)
                {
                    rocks.Clear();
                    PrintStringOnPosition(dwarf.x, dwarf.y, "XXX", ConsoleColor.Red);
                }
                else
                {
                    PrintStringOnPosition(dwarf.x, dwarf.y, dwarf.str, dwarf.color);    //draw dwarf
                }


                foreach (Object rock in rocks)
                {
                    PrintOnPosition(rock.x, rock.y, rock.c, rock.color);        //draw rocks

                }

                //- print info
                PrintStringOnPosition(0, 0, "Lives:" + livesCount.ToString(), ConsoleColor.White);
                PrintStringOnPosition(9, 0, "Speed:" + gameSpeed.ToString(), ConsoleColor.White);

                Thread.Sleep(500 - gameSpeed);
            }


        }




    }

}

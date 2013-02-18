using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.BallInCubois
{
    class Program
    {
        static short[] CheckTeleportCase(string teleport)
        {
            string[] teleportData = teleport.Split();
            string letter = teleportData[0];
            short coordW = short.Parse(teleportData[1]);
            short coordD = short.Parse(teleportData[2]);

            short[] coordinates = { coordW, coordD };
            return coordinates;
        }

        static void Main(string[] args)
        {

            // Read the cuboid size
            string cuboidSize = Console.ReadLine();
            string[] sizes = cuboidSize.Split();
            short width = short.Parse(sizes[0]);
            short height = short.Parse(sizes[1]);
            short depth = short.Parse(sizes[2]);
            string[, ,] cuboid = new string[width, height, depth];

            // Read the cuboid data==============================

            for (int he = 0; he < height; he++)
            {
                string line = Console.ReadLine();
                string[] sequences = line.Split('|');
                for (int de = 0; de < depth; de++)
                {
                    string pattern = @"(?<=\().+?(?=\))";
                    MatchCollection matches = Regex.Matches(sequences[de], pattern);
                    string[] directions = new string[matches.Count];

                    for (int i = 0; i < matches.Count; i++)
                    {
                        directions[i] = matches[i].ToString();
                    }

                    for (int wi = 0; wi < width; wi++)
                    {
                        cuboid[wi, he, de] = directions[wi];
                    }
                }
            }

            //Get initial ball=======================================
            string initial = Console.ReadLine();
            string[] ballInput = initial.Split();
            short ballW = short.Parse(ballInput[0]);
            short ballD = short.Parse(ballInput[1]);

            //Solve the task==========================================

            bool wentThrough = false;
            bool stuckBall = false;
            string initialDrop = cuboid[ballW, 0, ballD];

            string nextDrop = initialDrop;
            short w = ballW;
            short h = 0;
            short d = ballD;

            short oldW = 0;
            short oldH = 0;
            short oldD = 0;

            while (wentThrough == false && stuckBall == false)            //loops until 1 condition is met
            {
                oldW = w;
                oldH = h;
                oldD = d;

                nextDrop = cuboid[w, h, d];
                bool possibleExit = false;

                switch (nextDrop)
                {
                    case "S L": w--; h++; possibleExit = true;
                        break;
                    case "S R": w++; h++; possibleExit = true;
                        break;
                    case "S F": d--; h++; possibleExit = true;
                        break;
                    case "S B": d++; h++; possibleExit = true;
                        break;
                    case "S FL": w--; d--; h++; possibleExit = true;
                        break;
                    case "S FR": w++; d--; h++; possibleExit = true;
                        break;
                    case "S BL": w--; d++; h++; possibleExit = true;
                        break;
                    case "S BR": w++; d++; h++; possibleExit = true;
                        break;
                    case "E": h++; possibleExit = true;
                        break;
                    case "B": stuckBall = true;
                        break;
                    default: short[] telCoordinates = CheckTeleportCase(cuboid[w, h, d]);      //case for teleport
                        w = telCoordinates[0];
                        d = telCoordinates[1];                        
                        break;
                }

                if (stuckBall)
                {
                    break;
                }

                if (w < 0)
                {
                    stuckBall = true;                    
                    break;
                }
                if (w >= width)
                {
                    stuckBall = true;                    
                    break;
                }
                if (d < 0)
                {
                    stuckBall = true;                    
                    break;
                }
                if (d >= depth)
                {
                    stuckBall = true;                    
                    break;
                }
                if (h >= height - 1)
                {
                    if (possibleExit)
                    {
                        wentThrough = true;
                        break;
                    }
                    else
                    {
                        stuckBall = true;
                        break;
                    }
                }

            }

            //Print solution==========
            if (wentThrough)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0} {1} {2}", oldW, oldH, oldD);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0} {1} {2}", oldW, oldH, oldD);
            }

        }


    }
}
using System;


namespace _01.ShipDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            int shipX1 = int.Parse(Console.ReadLine());
            int shipY1 = int.Parse(Console.ReadLine());
            int shipX2 = int.Parse(Console.ReadLine());
            int shipY2 = int.Parse(Console.ReadLine());
            int horizon = int.Parse(Console.ReadLine());
            int catapultX1 = int.Parse(Console.ReadLine());
            int catapultY1 = int.Parse(Console.ReadLine());
            int catapultX2 = int.Parse(Console.ReadLine());
            int catapultY2 = int.Parse(Console.ReadLine());
            int catapultX3 = int.Parse(Console.ReadLine());
            int catapultY3 = int.Parse(Console.ReadLine());
            int totalDamage = 0;
            int topY = 0;
            int bottomY = 0;
            int leftX = 0;
            int rightX = 0;

            // find square coordinates:
            int maxX = Math.Max(shipX1, shipX2);
            int minX = Math.Min(shipX1, shipX2);
            int maxY = Math.Max(shipY1, shipY2);
            int minY = Math.Min(shipY1, shipY2);

            //find mirror points:
            catapultY1 = 2 * horizon - catapultY1;
            catapultY2 = 2 * horizon - catapultY2;
            catapultY3 = 2 * horizon - catapultY3;
           

            //Catapult 1
            if (catapultY1 == maxY || catapultY1 == minY)  // Y on the line
            {
                if (catapultX1 == maxX || catapultX1 == minX)      //X on the corner
                {
                    totalDamage += 25;
                }
                else if (catapultX1 > minX && catapultX1 < maxX)   //X on the horizontal side
                {
                    totalDamage += 50;
                }
            }
            else if (catapultY1 > minY && catapultY1 < maxY)    //Y inside the area
            {
                if (catapultX1 == minX || catapultX1 == maxX)      //X on the vertical side
                {
                    totalDamage += 50;
                }
                else if (catapultX1 > minX && catapultX1 < maxX)   //X inside the area
                {
                    totalDamage += 100;
                }
            }

            //Catapult 2
            if (catapultY2 == maxY || catapultY2 == minY)  // Y on the line
            {
                if (catapultX2 == maxX || catapultX2 == minX)      //X on the corner
                {
                    totalDamage += 25;
                }
                else if (catapultX2 > minX && catapultX2 < maxX)   //X on the horizontal side
                {
                    totalDamage += 50;
                }
            }
            else if (catapultY2 > minY && catapultY2 < maxY)    //Y inside the area
            {
                if (catapultX2 == minX || catapultX2 == maxX)      //X on the vertical side
                {
                    totalDamage += 50;
                }
                else if (catapultX2 > minX && catapultX2 < maxX)   //X inside the area
                {
                    totalDamage += 100;
                }
            }

            //Catapult 3
            if (catapultY3 == maxY || catapultY3 == minY)  // Y on the line
            {
                if (catapultX3 == maxX || catapultX3 == minX)      //X on the corner
                {
                    totalDamage += 25;
                }
                else if (catapultX3 > minX && catapultX3 < maxX)   //X on the horizontal side
                {
                    totalDamage += 50;
                }
            }
            else if (catapultY3 > minY && catapultY3 < maxY)    //Y inside the area
            {
                if (catapultX3 == minX || catapultX3 == maxX)      //X on the vertical side
                {
                    totalDamage += 50;
                }
                else if (catapultX3 > minX && catapultX3 < maxX)   //X inside the area
                {
                    totalDamage += 100;
                }
            }
           
            Console.WriteLine(totalDamage + "%");
        }
    }
}

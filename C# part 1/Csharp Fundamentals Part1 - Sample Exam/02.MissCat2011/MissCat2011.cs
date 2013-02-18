using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MissCat2011
{
    class MissCat2011
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] cats = new int[10];

            for (int i = 0; i < n; i++)
            {
                int catNumber = int.Parse(Console.ReadLine());
                switch (catNumber)
                {
                    case 1: cats[0]++;
                        break;
                    case 2: cats[1]++;
                        break;
                    case 3: cats[2]++;
                        break;
                    case 4: cats[3]++;
                        break;
                    case 5: cats[4]++;
                        break;
                    case 6: cats[5]++;
                        break;
                    case 7: cats[6]++;
                        break;
                    case 8: cats[7]++;
                        break;
                    case 9: cats[8]++;
                        break;
                    case 10: cats[9]++;
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < cats.Length; i++)
            {
                if (cats[i] == cats.Max())
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }
    }
}

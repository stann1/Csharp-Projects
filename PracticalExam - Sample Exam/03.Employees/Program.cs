using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            string[] position = new string[n];
            position[0] = "Trainee - 0";
            position[1] = "Owner - 100";

            int m = 3;
            string[] name = new string[m];
            name[0] = "Georgi Georgiev - Trainee";
            name[1] = "Jeorgi Georgiev - Trainee";
            name[2] = "Dimitar Dimitrov - Owner";

            string[] jobs = new string[n];
            string[] grades = new string[n];
            string[] lastNames = new string[m];            

            for (int i = 0; i < n; i++)
            {
                int index = position[i].IndexOf('-');
                jobs[i] = position[i].Substring(0, index - 1);
                grades[i] = position[i].Substring(index + 2);
            }

            string[] result = new string[m];
            for (int i = 0; i < m; i++)
            {
                int indexPos = name[i].IndexOf('-');
                int indexName = name[i].IndexOf(" ");
                string firstName = name[i].Substring(0, indexName);
                string lastName = name[i].Substring(indexName + 1, indexPos - 2 - indexName);
                lastNames[i] = lastName + "," + firstName;

                string job = name[i].Substring(indexPos + 2);
                for (int j = 0; j < n; j++)
                {
                    if (job == jobs[j])
                    {
                        result[i] = grades[j];
                    }
                }
            }

            
            Array.Sort(result, name,);
            

            for (int i = m - 1; i >= 0; i--)
            {
                Console.Write(lastNames[i] + " ");
                Console.Write(result[i]);
                Console.WriteLine();
            }
            
        }
    }
}

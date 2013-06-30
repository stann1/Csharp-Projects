using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaries
{
    class Program
    {
        static char[,] employees;
        static long[] salaries;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            salaries = new long[n];
            employees = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                for (int j = 0; j < n; j++)
                {
                    employees[i, j] = line[j];
                }
            }

            long totalSalaries = 0;

            for (int i = 0; i < n; i++)
            {
                totalSalaries += FindSalaryOfEmployee(i);
            }

            Console.WriteLine(totalSalaries);
        }

        private static long FindSalaryOfEmployee(int employee)
        {
            //If salary already found, do not recalculate
            if (salaries[employee] != 0)
            {
                return salaries[employee];
            }

            long salary = 0;

            for (int col = 0; col < employees.GetLength(0); col++)
            {
                if (employees[employee, col] == 'Y')
                {
                    salary += FindSalaryOfEmployee(col);
                }
            }

            //If employee does not have subordinates, set salary to 1
            if (salary == 0)
            {
                salary = 1;
            }
            salaries[employee] = salary;

            return salary;
        }
    }
}

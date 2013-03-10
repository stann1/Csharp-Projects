using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    class Worker : Human
    {
        public double WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        //Constructor
        public Worker(string firstName, string lastName, double weekSalary = 0, int workHoursPerDay = 0)             //default salary and hours are zero
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        //Methods
        public double MoneyPerHour()
        {
            double hourSalary = (this.WeekSalary / 5) / this.WorkHoursPerDay;
            return hourSalary;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.FirstName);
            sb.Append(" ");
            sb.Append(this.LastName);
            sb.AppendFormat(", salary: {0}, hours: {1}", this.WeekSalary, this.WorkHoursPerDay);

            return sb.ToString();
        }
    }
}

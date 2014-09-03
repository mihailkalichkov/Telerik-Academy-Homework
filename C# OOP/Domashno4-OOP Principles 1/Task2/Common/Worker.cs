using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            if (weekSalary < 0 || workHoursPerDay < 0)
            {
                throw new ArgumentException("Salary or work hours cannot be negative!");
            }
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour
        {
            get
            {
                return this.moneyPerHour(weekSalary, workHoursPerDay);
            }
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        private Func<decimal, decimal, decimal> moneyPerHour =
            (weekSalary, workHoursPerDay) => weekSalary / (workHoursPerDay * 5);

        public override string ToString()
        {
            var worker = new StringBuilder();
            worker.AppendLine(FirstName + " " + LastName);
            worker.AppendFormat("week salary: {0:F2}", WeekSalary);
            worker.AppendLine();
            worker.AppendFormat("work hours per day: {0}", WorkHoursPerDay);
            worker.AppendLine();
            worker.AppendFormat("money per hour: {0:F2}", MoneyPerHour);
            worker.AppendLine();

            return worker.ToString();
        }
    }
}
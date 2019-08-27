namespace Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public double WeekSalary
        {
            get => this.weekSalary;
            private set
            {
                if (value<=10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(this.weekSalary)}");
                }
                this.weekSalary = value;
            }
        }
        public double WorkHoursPerDay
        {
            get => this.workHoursPerDay;
            private set
            {
                if (value < 1 || value >12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(this.workHoursPerDay)}");
                }
                this.workHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base (firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");
            sb.AppendLine($"Salary per hour: {this.WeekSalary / this.WorkHoursPerDay /5:f2}");
            return sb.ToString();
        }
    }
}

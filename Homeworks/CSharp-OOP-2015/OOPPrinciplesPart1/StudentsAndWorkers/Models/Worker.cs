namespace StudentsAndWorkers.Models
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }

        public decimal WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / 7 / this.WorkHoursPerDay;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Weekly Salary = {0}, Work Hours per Day = {1}", this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}

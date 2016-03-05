namespace StudentsAndWorkers.Models
{
    using System;

    public class Student : Human
    {
        private uint grade;

        public Student(string firstName, string lastName, uint agrade) : base(firstName, lastName)
        {
            this.Grade = agrade;
        }

        public uint Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("The grade should be >= 2 and <=6!");
                }
                else
                {
                    this.grade = value;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Grade = {0}", this.Grade);
        }
    }
}
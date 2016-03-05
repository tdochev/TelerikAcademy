namespace School.Models
{
    public class Student : People 
    {
        public Student(string name, uint classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string name, uint classNumber, string comment)
            : this(name, classNumber)
        {
            this.Comment = comment;
        }

        public uint ClassNumber { get; private set; }
    }
}

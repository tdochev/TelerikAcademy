namespace School.Models
{
    using System.Collections.Generic;

    public class Teacher : People
    {
        public Teacher(string name) : base(name)
        {
            this.Disciplines = new List<Discipline>();
        }

        public Teacher(string name, string comment)
            : base(name, comment)
        {
            this.Disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines { get; set; }
    }
}

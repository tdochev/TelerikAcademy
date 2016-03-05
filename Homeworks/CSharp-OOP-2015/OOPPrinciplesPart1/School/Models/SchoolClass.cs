namespace School.Models
{
    using System.Collections.Generic;
    using School.Interfaces;

    public class SchoolClass : IComment
    {
        public SchoolClass(string identifier)
        {
            this.Identifier = identifier;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }

        public SchoolClass(string identifier, string comment)
            : this(identifier)
        {
            this.Comment = comment;
        }

        public string Identifier { get; set; }

        public List<Student> Students { get; set; }

        public List<Teacher> Teachers { get; set; }

        public string Comment { get; set; }
    }
}

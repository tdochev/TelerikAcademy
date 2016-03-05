namespace School
{
    using School.Models;

    internal class Start
    {
        private static void Main()
        {
            var firstDiscipline = new Discipline("Mathematic", 20, 3, "Some comment for math...");
            var secondDiscipline = new Discipline("Physics", 22, 4);
            var firstTeacher = new Teacher("Georgi Gerogiev", "Some comment for the teacher...");
            var secondTeacher = new Teacher("Ivan Ivanov");
            firstTeacher.Disciplines.Add(firstDiscipline);
            firstTeacher.Disciplines.Add(secondDiscipline);
            secondTeacher.Disciplines.Add(firstDiscipline);
            secondTeacher.Disciplines.Add(secondDiscipline);
            var firstStudent = new Student("Pesho Peshov", 112, "Some comment about the student...");
            var secondStudent = new Student("Gosho Goshov", 113);
            var exampleSchoolClass = new SchoolClass("Some unique ID", "Some comment...");
            exampleSchoolClass.Students.Add(firstStudent);
            exampleSchoolClass.Students.Add(secondStudent);
            exampleSchoolClass.Teachers.Add(firstTeacher);
            exampleSchoolClass.Teachers.Add(secondTeacher);
        }
    }
}
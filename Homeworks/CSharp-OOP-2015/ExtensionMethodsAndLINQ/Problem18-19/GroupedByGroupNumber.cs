////Problem 18. Grouped by GroupNumber
////Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
////Use LINQ.

namespace Problem18_19
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Problem09_16.Models;

    public class GroupedByGroupNumber
    {
        public static void Main()
        {
            List<Student> studentsList = new List<Student>()
            {
                new Student() { FirstName = "Gosho", LastName = "Goshov", GroupNumber = 2, Email = "gosho@abv.bg", Tel = "021234567", Marks = { 2, 3, 4 }, FN = 134506 },
                new Student() { FirstName = "Pesho", LastName = "Peshov", GroupNumber = 2, Email = "pesho@gmail.com", Tel = "+35929876543", Marks = { 2, 2 }, FN = 123507 },
                new Student() { FirstName = "Kotyo", LastName = "Kotev", GroupNumber = 3, Email = "kotyo@abv.bg", Tel = "032456789", Marks = { 4, 5, 6 }, FN = 387506 }
            };
            var groupedStudentsLINQ =
            from student in studentsList
            group student by student.GroupNumber into newGroup
            orderby newGroup.Key
            select newGroup;
            foreach (var nameGroup in groupedStudentsLINQ)
            {
                Console.WriteLine("Group: {0}", nameGroup.Key);
                foreach (var student in nameGroup)
                {
                    Console.WriteLine("\t{0} {1}", student.FirstName, student.LastName);
                }
            }
            ////Problem 19. Grouped by GroupName extensions
            ////Rewrite the previous using extension methods.
            var groupedStudents = studentsList.GroupBy(g => g.GroupNumber);
            foreach (var nameGroup in groupedStudents)
            {
                Console.WriteLine("Group: {0}", nameGroup.Key);
                foreach (var student in nameGroup)
                {
                    Console.WriteLine("\t{0} {1}", student.FirstName, student.LastName);
                }
            }
        }
    }
}

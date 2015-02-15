using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_ClassStudent;

namespace _13_StudentsByGroups
{
    public class StudentsByGroupsTest
    {
        static void Main(string[] args)
        {
            IList<Student> students = StudentsList.GetStudents();

            var studentsGroupNameQuery =
                from student in students
                group student by student.GroupName into groups
                orderby groups.Key
                select groups;

            Console.WriteLine("STUDENTS BY GROUP: ");
            Console.WriteLine();

            foreach (var groupName in studentsGroupNameQuery)
            {
                Console.WriteLine("GROUP NAME: {0}", groupName.Key);
                Console.WriteLine("=====================");

                foreach (var student in groupName)
                {
                    Console.WriteLine(student);
                    Console.WriteLine();
                }
            }
        }
    }
}

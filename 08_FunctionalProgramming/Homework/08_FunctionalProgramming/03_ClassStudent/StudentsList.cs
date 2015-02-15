﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace _03_ClassStudent
{
    public static class StudentsList
    {
        public static IList<Student> GetStudents()
        {
            IList<Student> students = new List<Student>
            {
                new Student("Bilbo", "Baggins", 19, "123", "245686", new MailAddress("bilbo@shiremail.sh"),
                new List<int> { 3, 4, 5, 6 }, "2"),
                new Student("Frodo", "Baggins", 21, "245", "684578", new MailAddress("frodo@underhill.sh"),
                new List<int> { 5, 5, 6, 6 }, "2"),
                new Student("Gandolf", "Thegray", 20, "789", "486515", new MailAddress("gandolf@wizards.org"),
                new List<int> { 6, 6, 6, 6 }, "1"),
                new Student("Sauron", "Unnamed", 26, "666", "123546", new MailAddress("sauron@mordormail.md"),
                new List<int> { 2, 3, 4, 2 }, "6"),
                new Student("Elrond", "Earendil", 23, "007", "888888", new MailAddress("elrond@rivendell.me"),
                new List<int> { 2, 3, 4, 2 }, "3"),
                new Student("Aragorn", "Arathorn", 22, "846", "435487", new MailAddress("theking@gondor.gr"),
                new List<int> { 6, 6, 5, 6 }, "3"),
            };

            return students;
        }
    }
}

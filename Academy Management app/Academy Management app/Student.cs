using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_Management_app
{
    public class Student
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; } = Role.Student;
        public string Name { get; set; }
        public Dictionary<string, string> Grades { get; set; }

        public Student(string username, string password, string name, Dictionary<string, string> grades)
        {
            Username = username;
            Password = password;
            Name = name;
            Grades = grades;
        }


    }
}

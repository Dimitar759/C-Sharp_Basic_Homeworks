using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student 
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Student(string username, string password, string role) 
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public string CurrentSubject { get; set; }

        public List<string> Grades { get; set; }

        
    }
}

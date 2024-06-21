using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_Management_app
{
    public class Admin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; } = Role.Admin;
        public string Name { get; set; }

        public Admin(string username, string password, string name)
        {
            Username = username;
            Password = password;
            Name = name;
        }
    }
}

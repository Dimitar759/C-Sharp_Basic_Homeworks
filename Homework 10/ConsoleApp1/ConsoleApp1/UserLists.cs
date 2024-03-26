using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class UserLists
    {
        public static List<Admin> Admins { get; } = new List<Admin>();
        public static List<Trainer> Trainers { get; } = new List<Trainer>();
        public static List<Student> Students { get; } = new List<Student>();
    }
}

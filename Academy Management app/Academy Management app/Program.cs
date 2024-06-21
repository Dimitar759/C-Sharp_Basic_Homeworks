namespace Academy_Management_app
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Admin> admins = new List<Admin>
            {
                new Admin("admin1", "admin123", "Kevin"),
                new Admin("admin2", "admin123", "Gwen"),
                new Admin("admin3", "admin123", "Cooper"),

            };



            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher("trainer1", "trainer123", "Ben"),
                new Teacher("trainer2", "trainer123", "Josh"),
                new Teacher("trainer3", "trainer123", "Mary"),

            };

            List<Student> students = new List<Student>
            {
                new Student("student1", "student123", "Albedo",new Dictionary < string, string > { { "Math", "B" }, { "Science", "C" } }),
                new Student("student2", "student123", "Rook", new Dictionary < string, string > { { "Math", "A" }, { "Science", "F" } }),
                new Student("student3", "student123", "Fistrick", new Dictionary < string, string > { { "Math", "F" }, { "Science", "B" } }),
                new Student("student4", "student123", "Stacey", new Dictionary < string, string > { { "Math", "C" }, { "Science", "A" } }),
                new Student("student5", "student123", "Brad", new Dictionary < string, string > { { "Math", "B" }, { "Science", "B" } }),
                new Student("student6", "student123", "Bob", new Dictionary < string, string > { { "Math", "A" }, { "Science", "A" } }),
                new Student("student7", "student123", "Carl", new Dictionary < string, string > { { "Math", "C" }, { "Science", "B" } }),
                new Student("student8", "student123", "Clancy", new Dictionary < string, string > { { "Math", "B" }, { "Science", "A" } }),
                new Student("student9", "student123", "Gorvan", new Dictionary < string, string > { { "Math", "F" }, { "Science", "F" } }),
                new Student("student10", "student123", "Clyde", new Dictionary < string, string > { { "Math", "A" }, { "Science", "C" } }),

            };

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Admin loggedInAdmin = admins.FirstOrDefault(a => a.Username == username && a.Password == password);

            if (loggedInAdmin != null)
            {
                Console.WriteLine($"Logged in as admin: {loggedInAdmin.Name}");

                foreach (var teacher in teachers)
                {
                    Console.WriteLine($"Teacher: {teacher.Name}");
                }
            }
            else
            {
                Teacher loggedInTeacher = teachers.FirstOrDefault(t => t.Username == username && t.Password == password);

                if (loggedInTeacher != null)
                {
                    Console.WriteLine($"Logged in as teacher: {loggedInTeacher.Name}");

                    // Access teacher-specific functionalities
                }
                else
                {
                    Student loggedInStudent = students.FirstOrDefault(s => s.Username == username && s.Password == password);

                    if (loggedInStudent != null)
                    {
                        // Successfully logged in as a student
                        Console.WriteLine($"Logged in as student: {loggedInStudent.Name}");

                        // Access student-specific functionalities
                    }
                    else
                    {
                        Console.WriteLine("Invalid username or password. Please try again.");
                    }
                }
            }
        }
    }
}


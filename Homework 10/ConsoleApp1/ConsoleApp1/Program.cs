using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {

            List<Admin> admins = new List<Admin>
            {
                new Admin("admin1", "admin123", "Admin"),
                new Admin("admin2", "admin123", "Admin"),
                new Admin("admin3", "admin123", "Admin"),
                new Admin("admin4", "admin123", "Admin"),
                new Admin("admin5", "admin123", "Admin")
            };



            List<Trainer> trainers = new List<Trainer>
            {
                new Trainer("trainer1", "trainer123", "Trainer"),
                new Trainer("trainer2", "trainer123", "Trainer"),
                new Trainer("trainer3", "trainer123", "Trainer"),
                new Trainer("trainer4", "trainer123", "Trainer"),
                new Trainer("trainer5", "trainer123", "Trainer"),

            };

            List<Student> students = new List<Student>
            {
                new Student("student1", "student123", "Student"),
                new Student("student2", "student123", "Student"),
                new Student("student3", "student123", "Student"),
                new Student("student4", "student123", "Student"),
                new Student("student5", "student123", "Student"),
                new Student("student6", "student123", "Student"),
                new Student("student7", "student123", "Student"),
                new Student("student8", "student123", "Student"),
                new Student("student9", "student123", "Student"),
                new Student("student10", "student123", "Student"),
                new Student("student11", "student123", "Student"),
                new Student("student12", "student123", "Student"),
                new Student("student13", "student123", "Student"),
                new Student("student14", "student123", "Student"),
                new Student("student15", "student123", "Student"),
                new Student("student16", "student123", "Student"),
                new Student("student17", "student123", "Student"),
                new Student("student18", "student123", "Student"),
                new Student("student19", "student123", "Student"),
                new Student("student20", "student123", "Student")
            };



            try
            {
                Console.WriteLine("Please enter your username:");
                string username = Console.ReadLine();

                Console.WriteLine("Please enter your password:");
                string password = Console.ReadLine();

                Console.WriteLine("Please enter your role (admin, trainer, or student):");
                string role = Console.ReadLine();

                switch (role.ToLower())
                {
                    case "admin":
                        Admin adminUser = admins.FirstOrDefault(user => user.Username == username && user.Password == password);
                        if (adminUser != null)
                        {
                            Console.WriteLine("Authentication successful! Welcome, Admin.");

                            HandleAdminFunctionalities(adminUser);
                        }
                        else
                        {
                            Console.WriteLine("Invalid username, password, or role. Please try again.");
                        }
                        break;

                    case "trainer":
                        Trainer trainerUser = trainers.FirstOrDefault(user => user.Username == username && user.Password == password);
                        if (trainerUser != null)
                        {
                            Console.WriteLine("Authentication successful! Welcome, Trainer.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid username, password, or role. Please try again.");
                        }
                        break;

                    case "student":
                        Student studentUser = students.FirstOrDefault(user => user.Username == username && user.Password == password);
                        if (studentUser != null)
                        {
                            Console.WriteLine("Authentication successful! Welcome, Student.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid username, password, or role. Please try again.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid role!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void HandleAdminFunctionalities(Admin adminUser)
        {
            Console.WriteLine("Choose one of the options (enter the number):");
            Console.WriteLine("1. Add an admin");
            Console.WriteLine("2. Remove an admin");
            Console.WriteLine("3. Add a teacher");
            Console.WriteLine("4. Remove a teacher");
            Console.WriteLine("5. Add a student");
            Console.WriteLine("6. Remove a student");
            string choice = Console.ReadLine();

            if (!string.IsNullOrEmpty(choice))
            {
                switch (choice)
                {
                    case "1":
                        string resultAddAdmin = adminUser.AddAdmin();
                        Console.WriteLine(resultAddAdmin);
                        break;
                    case "2":
                        string resultRemoveAdmin = adminUser.RemoveAdmin();
                        Console.WriteLine(resultRemoveAdmin);
                        break;
                    case "3":
                        string resultAddTeacher = adminUser.AddTeacher();
                        Console.WriteLine(resultAddTeacher);
                        break;
                    case "4":
                        string resultRemoveTeacher = adminUser.RemoveTeacher();
                        Console.WriteLine(resultRemoveTeacher);
                        break;
                    case "5":
                        string resultAddStudent = adminUser.AddStudent();
                        Console.WriteLine(resultAddStudent);
                        break;
                    case "6":
                        string resultRemoveStudent = adminUser.RemoveStudent();
                        Console.WriteLine(resultRemoveStudent);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
            }
        }

    }
    
}
